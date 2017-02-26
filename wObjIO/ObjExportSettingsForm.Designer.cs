namespace wObjIO
{
    partial class ObjExportSettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.storeSettings = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.scaleBox = new System.Windows.Forms.GroupBox();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // storeSettings
            // 
            this.storeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.storeSettings.AutoSize = true;
            this.storeSettings.Location = new System.Drawing.Point(12, 158);
            this.storeSettings.Name = "storeSettings";
            this.storeSettings.Size = new System.Drawing.Size(90, 17);
            this.storeSettings.TabIndex = 7;
            this.storeSettings.Text = "Store settings";
            this.storeSettings.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(229, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(109, 154);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(114, 23);
            this.exportButton.TabIndex = 8;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // scaleBox
            // 
            this.scaleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleBox.Location = new System.Drawing.Point(12, 12);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(139, 136);
            this.scaleBox.TabIndex = 10;
            this.scaleBox.TabStop = false;
            this.scaleBox.Text = "Scaling";
            // 
            // settingsBox
            // 
            this.settingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBox.Location = new System.Drawing.Point(157, 12);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(145, 136);
            this.settingsBox.TabIndex = 11;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // ObjExportSettingsForm
            // 
            this.AcceptButton = this.exportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(314, 189);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.storeSettings);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.exportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjExportSettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Obj export settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox storeSettings;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.GroupBox scaleBox;
        private System.Windows.Forms.GroupBox settingsBox;
    }
}