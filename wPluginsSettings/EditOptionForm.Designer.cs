namespace wPluginsSettings
{
    partial class EditOptionForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.optionNameLabel = new System.Windows.Forms.Label();
            this.optionText = new System.Windows.Forms.TextBox();
            this.optionCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(223, 68);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(142, 68);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // optionNameLabel
            // 
            this.optionNameLabel.AutoSize = true;
            this.optionNameLabel.Location = new System.Drawing.Point(12, 9);
            this.optionNameLabel.Name = "optionNameLabel";
            this.optionNameLabel.Size = new System.Drawing.Size(65, 13);
            this.optionNameLabel.TabIndex = 2;
            this.optionNameLabel.Text = "option name";
            // 
            // optionText
            // 
            this.optionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionText.Location = new System.Drawing.Point(15, 25);
            this.optionText.Name = "optionText";
            this.optionText.Size = new System.Drawing.Size(283, 20);
            this.optionText.TabIndex = 3;
            this.optionText.Text = "Text or number";
            // 
            // optionCheck
            // 
            this.optionCheck.AutoSize = true;
            this.optionCheck.Location = new System.Drawing.Point(15, 51);
            this.optionCheck.Name = "optionCheck";
            this.optionCheck.Size = new System.Drawing.Size(75, 17);
            this.optionCheck.TabIndex = 4;
            this.optionCheck.Text = "True/false";
            this.optionCheck.UseVisualStyleBackColor = true;
            // 
            // EditOptionForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(310, 103);
            this.Controls.Add(this.optionCheck);
            this.Controls.Add(this.optionText);
            this.Controls.Add(this.optionNameLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "EditOptionForm";
            this.Text = "EditOptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label optionNameLabel;
        private System.Windows.Forms.TextBox optionText;
        private System.Windows.Forms.CheckBox optionCheck;
    }
}