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
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.flipFaces = new System.Windows.Forms.CheckBox();
            this.copyBitmaps = new System.Windows.Forms.CheckBox();
            this.yzSwap = new System.Windows.Forms.CheckBox();
            this.scaleGroup = new System.Windows.Forms.GroupBox();
            this.vFlip = new System.Windows.Forms.CheckBox();
            this.uFlip = new System.Windows.Forms.CheckBox();
            this.uniformScale = new System.Windows.Forms.CheckBox();
            this.zFlip = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zScale = new System.Windows.Forms.NumericUpDown();
            this.yFlip = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yScale = new System.Windows.Forms.NumericUpDown();
            this.xFlip = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xScale = new System.Windows.Forms.NumericUpDown();
            this.settingsBox.SuspendLayout();
            this.scaleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).BeginInit();
            this.SuspendLayout();
            // 
            // storeSettings
            // 
            this.storeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.storeSettings.AutoSize = true;
            this.storeSettings.Location = new System.Drawing.Point(12, 169);
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
            this.cancelButton.Location = new System.Drawing.Point(247, 165);
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
            this.exportButton.Location = new System.Drawing.Point(127, 165);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(114, 23);
            this.exportButton.TabIndex = 8;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // settingsBox
            // 
            this.settingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBox.Controls.Add(this.flipFaces);
            this.settingsBox.Controls.Add(this.copyBitmaps);
            this.settingsBox.Controls.Add(this.yzSwap);
            this.settingsBox.Location = new System.Drawing.Point(12, 12);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(143, 147);
            this.settingsBox.TabIndex = 11;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // flipFaces
            // 
            this.flipFaces.AutoSize = true;
            this.flipFaces.Location = new System.Drawing.Point(6, 64);
            this.flipFaces.Name = "flipFaces";
            this.flipFaces.Size = new System.Drawing.Size(71, 17);
            this.flipFaces.TabIndex = 1;
            this.flipFaces.Text = "Flip faces";
            this.flipFaces.UseVisualStyleBackColor = true;
            // 
            // copyBitmaps
            // 
            this.copyBitmaps.AutoSize = true;
            this.copyBitmaps.Location = new System.Drawing.Point(6, 41);
            this.copyBitmaps.Name = "copyBitmaps";
            this.copyBitmaps.Size = new System.Drawing.Size(89, 17);
            this.copyBitmaps.TabIndex = 1;
            this.copyBitmaps.Text = "Copy bitmaps";
            this.copyBitmaps.UseVisualStyleBackColor = true;
            // 
            // yzSwap
            // 
            this.yzSwap.AutoSize = true;
            this.yzSwap.Location = new System.Drawing.Point(6, 19);
            this.yzSwap.Name = "yzSwap";
            this.yzSwap.Size = new System.Drawing.Size(100, 17);
            this.yzSwap.TabIndex = 0;
            this.yzSwap.Text = "Swap Y/Z axes";
            this.yzSwap.UseVisualStyleBackColor = true;
            // 
            // scaleGroup
            // 
            this.scaleGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleGroup.Controls.Add(this.vFlip);
            this.scaleGroup.Controls.Add(this.uFlip);
            this.scaleGroup.Controls.Add(this.uniformScale);
            this.scaleGroup.Controls.Add(this.zFlip);
            this.scaleGroup.Controls.Add(this.label3);
            this.scaleGroup.Controls.Add(this.zScale);
            this.scaleGroup.Controls.Add(this.yFlip);
            this.scaleGroup.Controls.Add(this.label2);
            this.scaleGroup.Controls.Add(this.yScale);
            this.scaleGroup.Controls.Add(this.xFlip);
            this.scaleGroup.Controls.Add(this.label1);
            this.scaleGroup.Controls.Add(this.xScale);
            this.scaleGroup.Location = new System.Drawing.Point(161, 12);
            this.scaleGroup.Name = "scaleGroup";
            this.scaleGroup.Size = new System.Drawing.Size(159, 147);
            this.scaleGroup.TabIndex = 12;
            this.scaleGroup.TabStop = false;
            this.scaleGroup.Text = "Scale";
            // 
            // vFlip
            // 
            this.vFlip.AutoSize = true;
            this.vFlip.Location = new System.Drawing.Point(86, 121);
            this.vFlip.Name = "vFlip";
            this.vFlip.Size = new System.Drawing.Size(62, 17);
            this.vFlip.TabIndex = 9;
            this.vFlip.Text = "Mirror V";
            this.vFlip.UseVisualStyleBackColor = true;
            // 
            // uFlip
            // 
            this.uFlip.AutoSize = true;
            this.uFlip.Location = new System.Drawing.Point(17, 121);
            this.uFlip.Name = "uFlip";
            this.uFlip.Size = new System.Drawing.Size(63, 17);
            this.uFlip.TabIndex = 8;
            this.uFlip.Text = "Mirror U";
            this.uFlip.UseVisualStyleBackColor = true;
            // 
            // uniformScale
            // 
            this.uniformScale.AutoSize = true;
            this.uniformScale.Location = new System.Drawing.Point(6, 19);
            this.uniformScale.Name = "uniformScale";
            this.uniformScale.Size = new System.Drawing.Size(90, 17);
            this.uniformScale.TabIndex = 9;
            this.uniformScale.Text = "Uniform scale";
            this.uniformScale.UseVisualStyleBackColor = true;
            this.uniformScale.CheckedChanged += new System.EventHandler(this.uniformScale_CheckedChanged);
            // 
            // zFlip
            // 
            this.zFlip.AutoSize = true;
            this.zFlip.Location = new System.Drawing.Point(86, 96);
            this.zFlip.Name = "zFlip";
            this.zFlip.Size = new System.Drawing.Size(62, 17);
            this.zFlip.TabIndex = 7;
            this.zFlip.Text = "Mirror Z";
            this.zFlip.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z:";
            // 
            // zScale
            // 
            this.zScale.DecimalPlaces = 3;
            this.zScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.zScale.Location = new System.Drawing.Point(29, 95);
            this.zScale.Name = "zScale";
            this.zScale.Size = new System.Drawing.Size(51, 20);
            this.zScale.TabIndex = 6;
            this.zScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zScale.ValueChanged += new System.EventHandler(this.ScaleValue_ValueChanged);
            // 
            // yFlip
            // 
            this.yFlip.AutoSize = true;
            this.yFlip.Location = new System.Drawing.Point(86, 70);
            this.yFlip.Name = "yFlip";
            this.yFlip.Size = new System.Drawing.Size(62, 17);
            this.yFlip.TabIndex = 5;
            this.yFlip.Text = "Mirror Y";
            this.yFlip.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // yScale
            // 
            this.yScale.DecimalPlaces = 3;
            this.yScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yScale.Location = new System.Drawing.Point(29, 69);
            this.yScale.Name = "yScale";
            this.yScale.Size = new System.Drawing.Size(51, 20);
            this.yScale.TabIndex = 3;
            this.yScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yScale.ValueChanged += new System.EventHandler(this.ScaleValue_ValueChanged);
            // 
            // xFlip
            // 
            this.xFlip.AutoSize = true;
            this.xFlip.Location = new System.Drawing.Point(86, 44);
            this.xFlip.Name = "xFlip";
            this.xFlip.Size = new System.Drawing.Size(62, 17);
            this.xFlip.TabIndex = 2;
            this.xFlip.Text = "Mirror X";
            this.xFlip.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // xScale
            // 
            this.xScale.DecimalPlaces = 3;
            this.xScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xScale.Location = new System.Drawing.Point(29, 43);
            this.xScale.Name = "xScale";
            this.xScale.Size = new System.Drawing.Size(51, 20);
            this.xScale.TabIndex = 0;
            this.xScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xScale.ValueChanged += new System.EventHandler(this.ScaleValue_ValueChanged);
            // 
            // ObjExportSettingsForm
            // 
            this.AcceptButton = this.exportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(332, 200);
            this.Controls.Add(this.scaleGroup);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.storeSettings);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.exportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjExportSettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Obj export settings";
            this.Load += new System.EventHandler(this.ObjExportSettingsForm_Load);
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.scaleGroup.ResumeLayout(false);
            this.scaleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox storeSettings;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.GroupBox scaleGroup;
        private System.Windows.Forms.CheckBox vFlip;
        private System.Windows.Forms.CheckBox uFlip;
        private System.Windows.Forms.CheckBox uniformScale;
        private System.Windows.Forms.CheckBox zFlip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown zScale;
        private System.Windows.Forms.CheckBox yFlip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown yScale;
        private System.Windows.Forms.CheckBox xFlip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xScale;
        private System.Windows.Forms.CheckBox yzSwap;
        private System.Windows.Forms.CheckBox copyBitmaps;
        private System.Windows.Forms.CheckBox flipFaces;
    }
}