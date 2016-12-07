namespace wAverageVertexPosition
{
    partial class MainForm
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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ThresholdNumber = new System.Windows.Forms.NumericUpDown();
            this.AvgPosCheck = new System.Windows.Forms.CheckBox();
            this.AvgNormalCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(239, 97);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Threshold:";
            // 
            // ThresholdNumber
            // 
            this.ThresholdNumber.DecimalPlaces = 3;
            this.ThresholdNumber.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.ThresholdNumber.Location = new System.Drawing.Point(75, 7);
            this.ThresholdNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.ThresholdNumber.Name = "ThresholdNumber";
            this.ThresholdNumber.Size = new System.Drawing.Size(120, 20);
            this.ThresholdNumber.TabIndex = 2;
            this.ThresholdNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // AvgPosCheck
            // 
            this.AvgPosCheck.AutoSize = true;
            this.AvgPosCheck.Checked = true;
            this.AvgPosCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AvgPosCheck.Location = new System.Drawing.Point(12, 33);
            this.AvgPosCheck.Name = "AvgPosCheck";
            this.AvgPosCheck.Size = new System.Drawing.Size(142, 17);
            this.AvgPosCheck.TabIndex = 3;
            this.AvgPosCheck.Text = "Average vertex positions";
            this.AvgPosCheck.UseVisualStyleBackColor = true;
            // 
            // AvgNormalCheck
            // 
            this.AvgNormalCheck.AutoSize = true;
            this.AvgNormalCheck.Location = new System.Drawing.Point(12, 56);
            this.AvgNormalCheck.Name = "AvgNormalCheck";
            this.AvgNormalCheck.Size = new System.Drawing.Size(137, 17);
            this.AvgNormalCheck.TabIndex = 4;
            this.AvgNormalCheck.Text = "Average vertex normals";
            this.AvgNormalCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 132);
            this.Controls.Add(this.AvgNormalCheck);
            this.Controls.Add(this.AvgPosCheck);
            this.Controls.Add(this.ThresholdNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "wAverageVertexPosition";
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ThresholdNumber;
        private System.Windows.Forms.CheckBox AvgPosCheck;
        private System.Windows.Forms.CheckBox AvgNormalCheck;
    }
}