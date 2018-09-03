namespace Licensing.GUI
{
    partial class LicenseSettingsControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseSettingsControl));
            this.grpbxLicenseType = new System.Windows.Forms.GroupBox();
            this.chkTimeTrial = new System.Windows.Forms.CheckBox();
            this.dateValidUntil = new System.Windows.Forms.DateTimePicker();
            this.rdoVolumeLicense = new System.Windows.Forms.RadioButton();
            this.rdoSingleLicense = new System.Windows.Forms.RadioButton();
            this.grpbxUniqueID = new System.Windows.Forms.GroupBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.grpbxLicenseInfo = new System.Windows.Forms.GroupBox();
            this.pgLicenseSettings = new System.Windows.Forms.PropertyGrid();
            this.grpbxLicenseType.SuspendLayout();
            this.grpbxUniqueID.SuspendLayout();
            this.grpbxLicenseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLicenseType
            // 
            resources.ApplyResources(this.grpbxLicenseType, "grpbxLicenseType");
            this.grpbxLicenseType.Controls.Add(this.chkTimeTrial);
            this.grpbxLicenseType.Controls.Add(this.dateValidUntil);
            this.grpbxLicenseType.Controls.Add(this.rdoVolumeLicense);
            this.grpbxLicenseType.Controls.Add(this.rdoSingleLicense);
            this.grpbxLicenseType.Name = "grpbxLicenseType";
            this.grpbxLicenseType.TabStop = false;
            // 
            // chkTimeTrial
            // 
            resources.ApplyResources(this.chkTimeTrial, "chkTimeTrial");
            this.chkTimeTrial.Name = "chkTimeTrial";
            this.chkTimeTrial.UseVisualStyleBackColor = true;
            // 
            // dateValidUntil
            // 
            resources.ApplyResources(this.dateValidUntil, "dateValidUntil");
            this.dateValidUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateValidUntil.Name = "dateValidUntil";
            // 
            // rdoVolumeLicense
            // 
            resources.ApplyResources(this.rdoVolumeLicense, "rdoVolumeLicense");
            this.rdoVolumeLicense.Name = "rdoVolumeLicense";
            this.rdoVolumeLicense.UseVisualStyleBackColor = true;
            this.rdoVolumeLicense.CheckedChanged += new System.EventHandler(this.LicenseTypeRadioButtons_CheckedChanged);
            // 
            // rdoSingleLicense
            // 
            resources.ApplyResources(this.rdoSingleLicense, "rdoSingleLicense");
            this.rdoSingleLicense.Checked = true;
            this.rdoSingleLicense.Name = "rdoSingleLicense";
            this.rdoSingleLicense.TabStop = true;
            this.rdoSingleLicense.UseVisualStyleBackColor = true;
            this.rdoSingleLicense.CheckedChanged += new System.EventHandler(this.LicenseTypeRadioButtons_CheckedChanged);
            // 
            // grpbxUniqueID
            // 
            resources.ApplyResources(this.grpbxUniqueID, "grpbxUniqueID");
            this.grpbxUniqueID.Controls.Add(this.txtUID);
            this.grpbxUniqueID.Name = "grpbxUniqueID";
            this.grpbxUniqueID.TabStop = false;
            // 
            // txtUID
            // 
            resources.ApplyResources(this.txtUID, "txtUID");
            this.txtUID.Name = "txtUID";
            // 
            // grpbxLicenseInfo
            // 
            resources.ApplyResources(this.grpbxLicenseInfo, "grpbxLicenseInfo");
            this.grpbxLicenseInfo.Controls.Add(this.pgLicenseSettings);
            this.grpbxLicenseInfo.Name = "grpbxLicenseInfo";
            this.grpbxLicenseInfo.TabStop = false;
            // 
            // pgLicenseSettings
            // 
            resources.ApplyResources(this.pgLicenseSettings, "pgLicenseSettings");
            this.pgLicenseSettings.Name = "pgLicenseSettings";
            this.pgLicenseSettings.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            // 
            // LicenseSettingsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpbxLicenseType);
            this.Controls.Add(this.grpbxUniqueID);
            this.Controls.Add(this.grpbxLicenseInfo);
            this.Name = "LicenseSettingsControl";
            this.grpbxLicenseType.ResumeLayout(false);
            this.grpbxLicenseType.PerformLayout();
            this.grpbxUniqueID.ResumeLayout(false);
            this.grpbxUniqueID.PerformLayout();
            this.grpbxLicenseInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLicenseType;
        private System.Windows.Forms.RadioButton rdoVolumeLicense;
        private System.Windows.Forms.RadioButton rdoSingleLicense;
        private System.Windows.Forms.GroupBox grpbxUniqueID;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.GroupBox grpbxLicenseInfo;
        private System.Windows.Forms.PropertyGrid pgLicenseSettings;
        private System.Windows.Forms.DateTimePicker dateValidUntil;
        private System.Windows.Forms.CheckBox chkTimeTrial;
    }
}
