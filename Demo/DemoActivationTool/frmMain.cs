using System;
using System.IO;
using System.Windows.Forms;
using System.Security;
using DemoActivationTool.Properties;
using DemoLicense;
using Licensing;
using Licensing.GUI;

namespace DemoActivationTool
{
    public partial class frmMain : Form
    {
        private byte[] _certPrivateKeyData;
        private SecureString _certPwd = new SecureString();

        public frmMain()
        {
            InitializeComponent();

            _certPwd.AppendChar('d');
            _certPwd.AppendChar('e');
            _certPwd.AppendChar('m');
            _certPwd.AppendChar('o');
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Read private key from assembly
            _certPrivateKeyData = Resources.Licensing;

            //Initialize the path for the certificate to sign the XML license file
            licSettings.CertificatePrivateKeyData = _certPrivateKeyData;
            licSettings.CertificatePassword = _certPwd;

            //Initialize a new license object
            licSettings.License = new MyLicense(); 
        }

        private void licSettings_OnLicenseGenerated(object sender, LicenseGeneratedEventArgs e)
        {
            //Event raised when license string is generated. Just show it in the text box
            licString.LicenseString = e.LicenseBASE64String;
        }


        private void btnGenSvrMgmLic_Click(object sender, EventArgs e)
        {
            //Event raised when "Generate License" button is clicked. 
            //Call the core library to generate the license
            licString.LicenseString = LicenseHandler.GenerateLicenseBASE64String(
                new MyLicense(),
                _certPrivateKeyData,
                _certPwd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK && File.Exists(dialog.FileName))
            {
                var _certPubicKeyData = DemoLicense.Properties.Resource.Licensing;

                var _lic = LicenseHandler.ParseLicenseFromBASE64String(
                    typeof(MyLicense),
                    File.ReadAllText(dialog.FileName),
                    _certPubicKeyData,
                    out var _status,
                    out var _msg);

                licSettings.ShowLicense(_lic);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            licSettings.Generate();
        }
    }
}
