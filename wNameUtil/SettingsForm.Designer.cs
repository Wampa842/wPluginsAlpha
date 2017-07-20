namespace wNameUtil
{
    partial class SettingsForm
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
            this.updateUrlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.autoStartCheck = new System.Windows.Forms.CheckBox();
            this.autoUpdateCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customDictionary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateUrlText
            // 
            this.updateUrlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateUrlText.Location = new System.Drawing.Point(12, 56);
            this.updateUrlText.Name = "updateUrlText";
            this.updateUrlText.Size = new System.Drawing.Size(280, 20);
            this.updateUrlText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dictionary update URL:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(217, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(136, 157);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // autoStartCheck
            // 
            this.autoStartCheck.AutoSize = true;
            this.autoStartCheck.Location = new System.Drawing.Point(12, 12);
            this.autoStartCheck.Name = "autoStartCheck";
            this.autoStartCheck.Size = new System.Drawing.Size(190, 17);
            this.autoStartCheck.TabIndex = 4;
            this.autoStartCheck.Text = "Start when PMX Editor is launched";
            this.autoStartCheck.UseVisualStyleBackColor = true;
            // 
            // autoUpdateCheck
            // 
            this.autoUpdateCheck.AutoSize = true;
            this.autoUpdateCheck.Location = new System.Drawing.Point(12, 82);
            this.autoUpdateCheck.Name = "autoUpdateCheck";
            this.autoUpdateCheck.Size = new System.Drawing.Size(250, 17);
            this.autoUpdateCheck.TabIndex = 5;
            this.autoUpdateCheck.Text = "Update the dictionary when the plugin is started";
            this.autoUpdateCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Custom dictionary location:";
            // 
            // customDictionary
            // 
            this.customDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDictionary.Enabled = false;
            this.customDictionary.Location = new System.Drawing.Point(12, 128);
            this.customDictionary.Name = "customDictionary";
            this.customDictionary.Size = new System.Drawing.Size(280, 20);
            this.customDictionary.TabIndex = 6;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customDictionary);
            this.Controls.Add(this.autoUpdateCheck);
            this.Controls.Add(this.autoStartCheck);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateUrlText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox updateUrlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox autoStartCheck;
        private System.Windows.Forms.CheckBox autoUpdateCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customDictionary;
    }
}