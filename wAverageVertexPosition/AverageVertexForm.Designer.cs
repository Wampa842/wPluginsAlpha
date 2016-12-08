namespace wAverageVertexPosition
{
    partial class AverageVertexForm
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
            this.scanButton = new System.Windows.Forms.Button();
            this.selectedVertsLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.thresholdNumber = new System.Windows.Forms.NumericUpDown();
            this.positionCheck = new System.Windows.Forms.CheckBox();
            this.normalCheck = new System.Windows.Forms.CheckBox();
            this.thresholdCheck = new System.Windows.Forms.CheckBox();
            this.infoLink = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(12, 12);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(88, 58);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "SCAN\r\n(Press this before \"Apply\")";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // selectedVertsLabel
            // 
            this.selectedVertsLabel.AutoSize = true;
            this.selectedVertsLabel.Location = new System.Drawing.Point(117, 22);
            this.selectedVertsLabel.Name = "selectedVertsLabel";
            this.selectedVertsLabel.Size = new System.Drawing.Size(96, 13);
            this.selectedVertsLabel.TabIndex = 1;
            this.selectedVertsLabel.Text = "0 vertices selected";
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(12, 76);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(88, 34);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // thresholdNumber
            // 
            this.thresholdNumber.DecimalPlaces = 3;
            this.thresholdNumber.Enabled = false;
            this.thresholdNumber.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.thresholdNumber.Location = new System.Drawing.Point(134, 67);
            this.thresholdNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.thresholdNumber.Name = "thresholdNumber";
            this.thresholdNumber.Size = new System.Drawing.Size(135, 20);
            this.thresholdNumber.TabIndex = 3;
            this.thresholdNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // positionCheck
            // 
            this.positionCheck.AutoSize = true;
            this.positionCheck.Checked = true;
            this.positionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.positionCheck.Location = new System.Drawing.Point(119, 93);
            this.positionCheck.Name = "positionCheck";
            this.positionCheck.Size = new System.Drawing.Size(63, 17);
            this.positionCheck.TabIndex = 4;
            this.positionCheck.Text = "Position";
            this.positionCheck.UseVisualStyleBackColor = true;
            // 
            // normalCheck
            // 
            this.normalCheck.AutoSize = true;
            this.normalCheck.Location = new System.Drawing.Point(188, 93);
            this.normalCheck.Name = "normalCheck";
            this.normalCheck.Size = new System.Drawing.Size(59, 17);
            this.normalCheck.TabIndex = 5;
            this.normalCheck.Text = "Normal";
            this.normalCheck.UseVisualStyleBackColor = true;
            // 
            // thresholdCheck
            // 
            this.thresholdCheck.AutoSize = true;
            this.thresholdCheck.Location = new System.Drawing.Point(119, 44);
            this.thresholdCheck.Name = "thresholdCheck";
            this.thresholdCheck.Size = new System.Drawing.Size(94, 17);
            this.thresholdCheck.TabIndex = 6;
            this.thresholdCheck.Text = "Use threshold:";
            this.thresholdCheck.UseVisualStyleBackColor = true;
            this.thresholdCheck.CheckedChanged += new System.EventHandler(this.thresholdCheck_CheckedChanged);
            // 
            // infoLink
            // 
            this.infoLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLink.AutoSize = true;
            this.infoLink.Location = new System.Drawing.Point(263, 94);
            this.infoLink.Name = "infoLink";
            this.infoLink.Size = new System.Drawing.Size(19, 13);
            this.infoLink.TabIndex = 7;
            this.infoLink.TabStop = true;
            this.infoLink.Text = "(?)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AverageVertexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoLink);
            this.Controls.Add(this.thresholdCheck);
            this.Controls.Add(this.normalCheck);
            this.Controls.Add(this.positionCheck);
            this.Controls.Add(this.thresholdNumber);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.selectedVertsLabel);
            this.Controls.Add(this.scanButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AverageVertexForm";
            this.Text = "wAverageVertexPosition";
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Label selectedVertsLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.NumericUpDown thresholdNumber;
        private System.Windows.Forms.CheckBox positionCheck;
        private System.Windows.Forms.CheckBox normalCheck;
        private System.Windows.Forms.CheckBox thresholdCheck;
        private System.Windows.Forms.LinkLabel infoLink;
        private System.Windows.Forms.Button button1;
    }
}