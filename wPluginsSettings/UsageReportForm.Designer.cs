namespace wPluginsSettings
{
    partial class UsageReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsageReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.versionText = new System.Windows.Forms.MaskedTextBox();
            this.englishTranslationCheck = new System.Windows.Forms.CheckBox();
            this.legacyCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pmxExperience = new System.Windows.Forms.ComboBox();
            this.generalExperience = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.generalExperience);
            this.groupBox1.Controls.Add(this.pmxExperience);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.legacyCheck);
            this.groupBox1.Controls.Add(this.englishTranslationCheck);
            this.groupBox1.Controls.Add(this.versionText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PMX version (w.x.y.z format):";
            // 
            // versionText
            // 
            this.versionText.Culture = new System.Globalization.CultureInfo("");
            this.versionText.Location = new System.Drawing.Point(155, 13);
            this.versionText.Mask = "0.0.0.0";
            this.versionText.Name = "versionText";
            this.versionText.PromptChar = '#';
            this.versionText.Size = new System.Drawing.Size(118, 20);
            this.versionText.TabIndex = 1;
            this.versionText.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // englishTranslationCheck
            // 
            this.englishTranslationCheck.AutoSize = true;
            this.englishTranslationCheck.Location = new System.Drawing.Point(279, 16);
            this.englishTranslationCheck.Name = "englishTranslationCheck";
            this.englishTranslationCheck.Size = new System.Drawing.Size(111, 17);
            this.englishTranslationCheck.TabIndex = 2;
            this.englishTranslationCheck.Text = "English translation";
            this.englishTranslationCheck.UseVisualStyleBackColor = true;
            // 
            // legacyCheck
            // 
            this.legacyCheck.AutoSize = true;
            this.legacyCheck.Location = new System.Drawing.Point(279, 39);
            this.legacyCheck.Name = "legacyCheck";
            this.legacyCheck.Size = new System.Drawing.Size(88, 17);
            this.legacyCheck.TabIndex = 3;
            this.legacyCheck.Text = "Legacy PMD";
            this.legacyCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your experience in using PMX/PMD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Your modeling experience in general:";
            // 
            // pmxExperience
            // 
            this.pmxExperience.DisplayMember = "Value";
            this.pmxExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pmxExperience.FormattingEnabled = true;
            this.pmxExperience.Items.AddRange(new object[] {
            "Beginner",
            "Amateur",
            "Skilled",
            "Expert",
            "Professional"});
            this.pmxExperience.Location = new System.Drawing.Point(206, 62);
            this.pmxExperience.Name = "pmxExperience";
            this.pmxExperience.Size = new System.Drawing.Size(215, 21);
            this.pmxExperience.TabIndex = 6;
            this.pmxExperience.ValueMember = "Value";
            // 
            // generalExperience
            // 
            this.generalExperience.DisplayMember = "Value";
            this.generalExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalExperience.FormattingEnabled = true;
            this.generalExperience.Items.AddRange(new object[] {
            "Beginner",
            "Amateur",
            "Skilled",
            "Expert",
            "Professional"});
            this.generalExperience.Location = new System.Drawing.Point(206, 89);
            this.generalExperience.Name = "generalExperience";
            this.generalExperience.Size = new System.Drawing.Size(215, 21);
            this.generalExperience.TabIndex = 7;
            this.generalExperience.ValueMember = "Value";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(12, 236);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(190, 30);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(208, 236);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(234, 30);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Close (do not submit)";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UsageReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 279);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UsageReportForm";
            this.Text = "UsageReportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox englishTranslationCheck;
        private System.Windows.Forms.MaskedTextBox versionText;
        private System.Windows.Forms.CheckBox legacyCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pmxExperience;
        private System.Windows.Forms.ComboBox generalExperience;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
    }
}