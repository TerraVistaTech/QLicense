﻿using System;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace Licensing.GUI
{
    public delegate void LicenseSettingsValidatingHandler(object sender, LicenseSettingsValidatingEventArgs e);
    public delegate void LicenseGeneratedHandler(object sender, LicenseGeneratedEventArgs e);

    public partial class LicenseSettingsControl : UserControl
    {

        public event LicenseSettingsValidatingHandler OnLicenseSettingsValidating;
        public event LicenseGeneratedHandler OnLicenseGenerated;

        protected LicenseEntity _lic;

        public LicenseEntity License
        {
            set
            {
                _lic = value;
                pgLicenseSettings.SelectedObject = _lic;
            }
        }

        public byte[] CertificatePrivateKeyData { set; private get; }

        public SecureString CertificatePassword { set; private get; }

        public bool AllowVolumeLicense
        {
            get
            {
                return grpbxLicenseType.Enabled;
            }
            set
            {
                if (!value)
                {
                    rdoSingleLicense.Checked = true;
                }

                grpbxLicenseType.Enabled = value;
            }
        }

        public LicenseSettingsControl()
        {
            InitializeComponent();
        }


        private void LicenseTypeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            txtUID.Text = string.Empty;

            txtUID.Enabled = rdoSingleLicense.Checked;
        }

        public void Generate()
        {
            if (_lic == null) throw new ArgumentException("LicenseEntity is invalid");

            _lic.IsTimeTrial = false;
            _lic.ValidUntil = DateTime.MaxValue;
            _lic.CreateDateTime = DateTime.Now;

            if (rdoSingleLicense.Checked)
            {
                if (LicenseHandler.ValidateUIDFormat(txtUID.Text.Trim()))
                {
                    _lic.Type = LicenseTypes.Single;
                    _lic.UID = txtUID.Text.Trim();
                }
                else
                {
                    MessageBox.Show("License UID is blank or invalid", "Could not generate license", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rdoVolumeLicense.Checked)
            {
                _lic.Type = LicenseTypes.Volume;
                _lic.UID = string.Empty;
            }

            if (chkTimeTrial.Checked)
            {
                _lic.IsTimeTrial = true;
                _lic.ValidUntil = dateValidUntil.Value;
            }
            
            if (OnLicenseSettingsValidating != null)
            {
                var _args = new LicenseSettingsValidatingEventArgs() { License = _lic, CancelGenerating = false };

                OnLicenseSettingsValidating(this, _args);

                if (_args.CancelGenerating)
                {
                    return;
                }
            }

            if (OnLicenseGenerated != null)
            {
                var _licStr = LicenseHandler.GenerateLicenseBASE64String(_lic, CertificatePrivateKeyData, CertificatePassword);

                OnLicenseGenerated(this, new LicenseGeneratedEventArgs() { LicenseBASE64String = _licStr });
            }
        }

        public void ShowLicense(LicenseEntity _lic)
        {
            if (_lic != null)
            {
                License = _lic;
                rdoSingleLicense.Checked = rdoVolumeLicense.Checked = chkTimeTrial.Checked = false;
                dateValidUntil.Value = DateTime.Today;

                switch (_lic.Type)
                {
                    case LicenseTypes.Single:
                        rdoSingleLicense.Checked = true;
                        break;
                    case LicenseTypes.Volume:
                        rdoVolumeLicense.Checked = true;
                        break;
                    case LicenseTypes.Unknown:
                    default:
                        break;
                }

                if (_lic.IsTimeTrial)
                {
                    chkTimeTrial.Checked = true;
                    dateValidUntil.Value = _lic.ValidUntil;
                }

                txtUID.Text = _lic.UID;

                pgLicenseSettings.Refresh();
            }
        }
    }
}
