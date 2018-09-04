using System;
using System.Windows.Forms;

namespace Licensing.GUI
{
    public partial class LicenseActivateControl : UserControl
    {
        public string AppName { get; set; }

        public byte[] CertificatePublicKeyData { private get; set; }

        public bool ShowMessageAfterValidation { get; set; }

        public Type LicenseObjectType { get; set; }

        public string LicenseBASE64String
        {
            get
            {
                return txtLicense.Text.Trim();
            }
        }

        public LicenseActivateControl()
        {
            InitializeComponent();

            ShowMessageAfterValidation = true;
        }

        public void ShowUID()
        {
            txtUID.Text = LicenseHandler.GenerateUID(AppName);
        }

        public bool ValidateLicense()
        {
            if (string.IsNullOrWhiteSpace(txtLicense.Text))
            {
                MessageBox.Show("Please input license", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Check the activation string
            var _lic = LicenseHandler.ParseLicenseFromBASE64String(LicenseObjectType, txtLicense.Text.Trim(), CertificatePublicKeyData, out LicenseStatus _licStatus);
            var _msg = _licStatus.GetDescription();

            switch (_licStatus)
            {
                case LicenseStatus.VALID:                   
                    if (ShowMessageAfterValidation)
                    {
                        MessageBox.Show(_msg, "Valid license", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return true;

                case LicenseStatus.TRIALEXPIRED:
                    if (ShowMessageAfterValidation)
                    {
                        MessageBox.Show(_msg, $"Activation expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return false;
                    
                case LicenseStatus.CRACKED:
                case LicenseStatus.INVALID:
                case LicenseStatus.UNDEFINED:
                    if (ShowMessageAfterValidation)
                    {
                        MessageBox.Show(_msg, "Invalid license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return false;

                default:
                    return false;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUID.Text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtLicense.Text = Clipboard.GetText();
        }
    }
}
