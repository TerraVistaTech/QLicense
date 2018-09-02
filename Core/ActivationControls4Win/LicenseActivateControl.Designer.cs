namespace Licensing.GUI
{
    partial class LicenseActivateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseActivateControl));
            this.grpbxLicense = new System.Windows.Forms.GroupBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.grpbxUID = new System.Windows.Forms.GroupBox();
            this.lblUIDTip = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.grpbxLicense.SuspendLayout();
            this.grpbxUID.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLicense
            // 
            resources.ApplyResources(this.grpbxLicense, "grpbxLicense");
            this.grpbxLicense.Controls.Add(this.btnPaste);
            this.grpbxLicense.Controls.Add(this.label1);
            this.grpbxLicense.Controls.Add(this.txtLicense);
            this.grpbxLicense.Name = "grpbxLicense";
            this.grpbxLicense.TabStop = false;
            // 
            // txtLicense
            // 
            resources.ApplyResources(this.txtLicense, "txtLicense");
            this.txtLicense.Name = "txtLicense";
            // 
            // grpbxUID
            // 
            resources.ApplyResources(this.grpbxUID, "grpbxUID");
            this.grpbxUID.Controls.Add(this.btnCopy);
            this.grpbxUID.Controls.Add(this.lblUIDTip);
            this.grpbxUID.Controls.Add(this.txtUID);
            this.grpbxUID.Name = "grpbxUID";
            this.grpbxUID.TabStop = false;
            // 
            // lblUIDTip
            // 
            resources.ApplyResources(this.lblUIDTip, "lblUIDTip");
            this.lblUIDTip.Name = "lblUIDTip";
            // 
            // txtUID
            // 
            resources.ApplyResources(this.txtUID, "txtUID");
            this.txtUID.Name = "txtUID";
            this.txtUID.ReadOnly = true;
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnPaste
            // 
            resources.ApplyResources(this.btnPaste, "btnPaste");
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // LicenseActivateControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpbxLicense);
            this.Controls.Add(this.grpbxUID);
            this.Name = "LicenseActivateControl";
            this.grpbxLicense.ResumeLayout(false);
            this.grpbxLicense.PerformLayout();
            this.grpbxUID.ResumeLayout(false);
            this.grpbxUID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLicense;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.GroupBox grpbxUID;
        private System.Windows.Forms.Label lblUIDTip;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Label label1;
    }
}
