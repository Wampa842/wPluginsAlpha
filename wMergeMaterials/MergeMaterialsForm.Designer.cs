namespace wMergeMaterials
{
    partial class MergeMaterialsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.modeGroup = new System.Windows.Forms.GroupBox();
            this.selectCheck = new System.Windows.Forms.CheckBox();
            this.matchModeRadio = new System.Windows.Forms.RadioButton();
            this.anyModeRadio = new System.Windows.Forms.RadioButton();
            this.modeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(113, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Any: all materials with matching properties will be merged.\r\nMatch: only material" +
    "s that match the given properties will be merged.\r\nSelect: if checked, only sele" +
    "cted materials will be processed.";
            // 
            // modeGroup
            // 
            this.modeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeGroup.Controls.Add(this.selectCheck);
            this.modeGroup.Controls.Add(this.matchModeRadio);
            this.modeGroup.Controls.Add(this.anyModeRadio);
            this.modeGroup.Controls.Add(this.label1);
            this.modeGroup.Location = new System.Drawing.Point(12, 12);
            this.modeGroup.Name = "modeGroup";
            this.modeGroup.Size = new System.Drawing.Size(464, 92);
            this.modeGroup.TabIndex = 1;
            this.modeGroup.TabStop = false;
            this.modeGroup.Text = "Mode:";
            // 
            // selectCheck
            // 
            this.selectCheck.AutoSize = true;
            this.selectCheck.Location = new System.Drawing.Point(6, 65);
            this.selectCheck.Name = "selectCheck";
            this.selectCheck.Size = new System.Drawing.Size(56, 17);
            this.selectCheck.TabIndex = 3;
            this.selectCheck.Text = "Select";
            this.selectCheck.UseVisualStyleBackColor = true;
            this.selectCheck.CheckedChanged += new System.EventHandler(this.selectCheck_CheckedChanged);
            // 
            // matchModeRadio
            // 
            this.matchModeRadio.AutoSize = true;
            this.matchModeRadio.Location = new System.Drawing.Point(6, 42);
            this.matchModeRadio.Name = "matchModeRadio";
            this.matchModeRadio.Size = new System.Drawing.Size(55, 17);
            this.matchModeRadio.TabIndex = 2;
            this.matchModeRadio.TabStop = true;
            this.matchModeRadio.Text = "Match";
            this.matchModeRadio.UseVisualStyleBackColor = true;
            // 
            // anyModeRadio
            // 
            this.anyModeRadio.AutoSize = true;
            this.anyModeRadio.Location = new System.Drawing.Point(6, 19);
            this.anyModeRadio.Name = "anyModeRadio";
            this.anyModeRadio.Size = new System.Drawing.Size(43, 17);
            this.anyModeRadio.TabIndex = 1;
            this.anyModeRadio.TabStop = true;
            this.anyModeRadio.Text = "Any";
            this.anyModeRadio.UseVisualStyleBackColor = true;
            // 
            // MergeMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 340);
            this.Controls.Add(this.modeGroup);
            this.Name = "MergeMaterialsForm";
            this.Text = "wMergeMaterials";
            this.Move += new System.EventHandler(this.MergeMaterialsForm_Move);
            this.modeGroup.ResumeLayout(false);
            this.modeGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox modeGroup;
        private System.Windows.Forms.RadioButton matchModeRadio;
        private System.Windows.Forms.RadioButton anyModeRadio;
        private System.Windows.Forms.CheckBox selectCheck;
    }
}