namespace wNameUtil
{
    partial class SelectByRegexForm
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
            this.languageBox = new System.Windows.Forms.GroupBox();
            this.matchEnglish = new System.Windows.Forms.RadioButton();
            this.matchJapanese = new System.Windows.Forms.RadioButton();
            this.matchModeBox = new System.Windows.Forms.GroupBox();
            this.matchRegex = new System.Windows.Forms.RadioButton();
            this.matchSimple = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.matchText = new System.Windows.Forms.TextBox();
            this.matchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.languageBox.SuspendLayout();
            this.matchModeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // languageBox
            // 
            this.languageBox.Controls.Add(this.matchEnglish);
            this.languageBox.Controls.Add(this.matchJapanese);
            this.languageBox.Location = new System.Drawing.Point(12, 12);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(119, 68);
            this.languageBox.TabIndex = 0;
            this.languageBox.TabStop = false;
            this.languageBox.Text = "Match language";
            // 
            // matchEnglish
            // 
            this.matchEnglish.AutoSize = true;
            this.matchEnglish.Location = new System.Drawing.Point(6, 42);
            this.matchEnglish.Name = "matchEnglish";
            this.matchEnglish.Size = new System.Drawing.Size(59, 17);
            this.matchEnglish.TabIndex = 1;
            this.matchEnglish.TabStop = true;
            this.matchEnglish.Text = "English";
            this.matchEnglish.UseVisualStyleBackColor = true;
            // 
            // matchJapanese
            // 
            this.matchJapanese.AutoSize = true;
            this.matchJapanese.Location = new System.Drawing.Point(6, 19);
            this.matchJapanese.Name = "matchJapanese";
            this.matchJapanese.Size = new System.Drawing.Size(71, 17);
            this.matchJapanese.TabIndex = 0;
            this.matchJapanese.TabStop = true;
            this.matchJapanese.Text = "Japanese";
            this.matchJapanese.UseVisualStyleBackColor = true;
            // 
            // matchModeBox
            // 
            this.matchModeBox.Controls.Add(this.matchRegex);
            this.matchModeBox.Controls.Add(this.matchSimple);
            this.matchModeBox.Location = new System.Drawing.Point(137, 12);
            this.matchModeBox.Name = "matchModeBox";
            this.matchModeBox.Size = new System.Drawing.Size(156, 68);
            this.matchModeBox.TabIndex = 1;
            this.matchModeBox.TabStop = false;
            this.matchModeBox.Text = "Match by...";
            // 
            // matchRegex
            // 
            this.matchRegex.AutoSize = true;
            this.matchRegex.Location = new System.Drawing.Point(6, 42);
            this.matchRegex.Name = "matchRegex";
            this.matchRegex.Size = new System.Drawing.Size(115, 17);
            this.matchRegex.TabIndex = 1;
            this.matchRegex.TabStop = true;
            this.matchRegex.Text = "Regular expression";
            this.matchRegex.UseVisualStyleBackColor = true;
            // 
            // matchSimple
            // 
            this.matchSimple.AutoSize = true;
            this.matchSimple.Location = new System.Drawing.Point(6, 19);
            this.matchSimple.Name = "matchSimple";
            this.matchSimple.Size = new System.Drawing.Size(56, 17);
            this.matchSimple.TabIndex = 0;
            this.matchSimple.TabStop = true;
            this.matchSimple.Text = "Simple";
            this.matchSimple.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Match string:";
            // 
            // matchText
            // 
            this.matchText.Location = new System.Drawing.Point(12, 99);
            this.matchText.Name = "matchText";
            this.matchText.Size = new System.Drawing.Size(281, 20);
            this.matchText.TabIndex = 3;
            // 
            // matchButton
            // 
            this.matchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.matchButton.Location = new System.Drawing.Point(12, 129);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(152, 23);
            this.matchButton.TabIndex = 4;
            this.matchButton.Text = "Match";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(170, 129);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SelectByRegexForm
            // 
            this.AcceptButton = this.matchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(305, 164);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.matchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchModeBox);
            this.Controls.Add(this.languageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectByRegexForm";
            this.Text = "Select by matching name";
            this.languageBox.ResumeLayout(false);
            this.languageBox.PerformLayout();
            this.matchModeBox.ResumeLayout(false);
            this.matchModeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox languageBox;
        private System.Windows.Forms.GroupBox matchModeBox;
        private System.Windows.Forms.RadioButton matchJapanese;
        private System.Windows.Forms.RadioButton matchEnglish;
        private System.Windows.Forms.RadioButton matchRegex;
        private System.Windows.Forms.RadioButton matchSimple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matchText;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Button cancelButton;
    }
}