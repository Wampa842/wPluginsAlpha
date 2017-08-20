namespace wObjIO
{
    partial class ObjImportSettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.unitBaseGroup = new System.Windows.Forms.GroupBox();
            this.unitBaseMetric = new System.Windows.Forms.RadioButton();
            this.unitBaseInch = new System.Windows.Forms.RadioButton();
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
            this.importButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.otherSettingsGroup = new System.Windows.Forms.GroupBox();
            this.withBone = new System.Windows.Forms.CheckBox();
            this.yzSwap = new System.Windows.Forms.CheckBox();
            this.flipFacesCheck = new System.Windows.Forms.CheckBox();
            this.storeSettings = new System.Windows.Forms.CheckBox();
            this.materialNameSelect = new System.Windows.Forms.ComboBox();
            this.materialSettings = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bitmapActionSelect = new System.Windows.Forms.ComboBox();
            this.importHelp = new System.Windows.Forms.HelpProvider();
            this.importToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.unitBaseGroup.SuspendLayout();
            this.scaleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).BeginInit();
            this.otherSettingsGroup.SuspendLayout();
            this.materialSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitBaseGroup
            // 
            this.unitBaseGroup.Controls.Add(this.unitBaseMetric);
            this.unitBaseGroup.Controls.Add(this.unitBaseInch);
            this.unitBaseGroup.Location = new System.Drawing.Point(12, 12);
            this.unitBaseGroup.Name = "unitBaseGroup";
            this.unitBaseGroup.Size = new System.Drawing.Size(128, 76);
            this.unitBaseGroup.TabIndex = 0;
            this.unitBaseGroup.TabStop = false;
            this.unitBaseGroup.Text = "Length unit";
            // 
            // unitBaseMetric
            // 
            this.unitBaseMetric.AutoSize = true;
            this.unitBaseMetric.Location = new System.Drawing.Point(6, 42);
            this.unitBaseMetric.Name = "unitBaseMetric";
            this.unitBaseMetric.Size = new System.Drawing.Size(107, 17);
            this.unitBaseMetric.TabIndex = 1;
            this.unitBaseMetric.Text = "Centimeter-based";
            this.importToolTip.SetToolTip(this.unitBaseMetric, "Scale the model for centimeter-based units");
            this.unitBaseMetric.UseVisualStyleBackColor = true;
            // 
            // unitBaseInch
            // 
            this.unitBaseInch.AutoSize = true;
            this.unitBaseInch.Checked = true;
            this.unitBaseInch.Location = new System.Drawing.Point(6, 19);
            this.unitBaseInch.Name = "unitBaseInch";
            this.unitBaseInch.Size = new System.Drawing.Size(78, 17);
            this.unitBaseInch.TabIndex = 0;
            this.unitBaseInch.TabStop = true;
            this.unitBaseInch.Text = "Inch-based";
            this.importToolTip.SetToolTip(this.unitBaseInch, "Scale the model for inch-based units");
            this.unitBaseInch.UseVisualStyleBackColor = true;
            // 
            // scaleGroup
            // 
            this.scaleGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.scaleGroup.Location = new System.Drawing.Point(146, 12);
            this.scaleGroup.Name = "scaleGroup";
            this.scaleGroup.Size = new System.Drawing.Size(159, 172);
            this.scaleGroup.TabIndex = 2;
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
            this.importToolTip.SetToolTip(this.vFlip, "Mirror texture coordinates on the V (vertical) axis");
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
            this.importToolTip.SetToolTip(this.uFlip, "Mirror texture coordinates on the U (horizontal) axis");
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
            this.importToolTip.SetToolTip(this.uniformScale, "Scale by the same factor on all three axes");
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
            this.importToolTip.SetToolTip(this.zFlip, "Mirror the model on the Z axis");
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
            this.importToolTip.SetToolTip(this.zScale, "Scale factor on the Z axis");
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
            this.importToolTip.SetToolTip(this.yFlip, "Mirror the model on the Y axis");
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
            this.importToolTip.SetToolTip(this.yScale, "Scale factor on the Y axis");
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
            this.importToolTip.SetToolTip(this.xFlip, "Mirror the model on the X axis");
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
            this.importToolTip.SetToolTip(this.xScale, "Scale factor on the X axis");
            this.xScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xScale.ValueChanged += new System.EventHandler(this.ScaleValue_ValueChanged);
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.Location = new System.Drawing.Point(112, 268);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(114, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(232, 268);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // otherSettingsGroup
            // 
            this.otherSettingsGroup.Controls.Add(this.withBone);
            this.otherSettingsGroup.Controls.Add(this.yzSwap);
            this.otherSettingsGroup.Controls.Add(this.flipFacesCheck);
            this.otherSettingsGroup.Location = new System.Drawing.Point(18, 94);
            this.otherSettingsGroup.Name = "otherSettingsGroup";
            this.otherSettingsGroup.Size = new System.Drawing.Size(122, 90);
            this.otherSettingsGroup.TabIndex = 1;
            this.otherSettingsGroup.TabStop = false;
            this.otherSettingsGroup.Text = "Settings";
            // 
            // withBone
            // 
            this.withBone.AutoSize = true;
            this.withBone.Checked = true;
            this.withBone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.withBone.Location = new System.Drawing.Point(6, 65);
            this.withBone.Name = "withBone";
            this.withBone.Size = new System.Drawing.Size(107, 17);
            this.withBone.TabIndex = 2;
            this.withBone.Text = "Create new bone";
            this.importToolTip.SetToolTip(this.withBone, "Create a bone at the model\'s center of mass and weigh all vertices to it");
            this.withBone.UseVisualStyleBackColor = true;
            // 
            // yzSwap
            // 
            this.yzSwap.AutoSize = true;
            this.yzSwap.Enabled = false;
            this.yzSwap.Location = new System.Drawing.Point(6, 42);
            this.yzSwap.Name = "yzSwap";
            this.yzSwap.Size = new System.Drawing.Size(100, 17);
            this.yzSwap.TabIndex = 1;
            this.yzSwap.Text = "Swap Y/Z axes";
            this.importToolTip.SetToolTip(this.yzSwap, "Swap between Y-up (right handed, MMD) and Z-up (left handed, Maya/3ds Max/Blender" +
        ") coordinate systems");
            this.yzSwap.UseVisualStyleBackColor = true;
            // 
            // flipFacesCheck
            // 
            this.flipFacesCheck.AutoSize = true;
            this.flipFacesCheck.Location = new System.Drawing.Point(6, 19);
            this.flipFacesCheck.Name = "flipFacesCheck";
            this.flipFacesCheck.Size = new System.Drawing.Size(71, 17);
            this.flipFacesCheck.TabIndex = 0;
            this.flipFacesCheck.Text = "Flip faces";
            this.importToolTip.SetToolTip(this.flipFacesCheck, "Reverse the facing direction of triangles");
            this.flipFacesCheck.UseVisualStyleBackColor = true;
            // 
            // storeSettings
            // 
            this.storeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.storeSettings.AutoSize = true;
            this.storeSettings.Location = new System.Drawing.Point(12, 274);
            this.storeSettings.Name = "storeSettings";
            this.storeSettings.Size = new System.Drawing.Size(90, 17);
            this.storeSettings.TabIndex = 4;
            this.storeSettings.Text = "Store settings";
            this.storeSettings.UseVisualStyleBackColor = true;
            // 
            // materialNameSelect
            // 
            this.materialNameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialNameSelect.Enabled = false;
            this.materialNameSelect.FormattingEnabled = true;
            this.materialNameSelect.Items.AddRange(new object[] {
            "From material library",
            "Bitmap file name",
            "OBJ name + number",
            "Custom name + number"});
            this.materialNameSelect.Location = new System.Drawing.Point(140, 19);
            this.materialNameSelect.Name = "materialNameSelect";
            this.materialNameSelect.Size = new System.Drawing.Size(147, 21);
            this.materialNameSelect.TabIndex = 0;
            this.importToolTip.SetToolTip(this.materialNameSelect, "The source of material names");
            // 
            // materialSettings
            // 
            this.materialSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSettings.Controls.Add(this.label5);
            this.materialSettings.Controls.Add(this.label4);
            this.materialSettings.Controls.Add(this.bitmapActionSelect);
            this.materialSettings.Controls.Add(this.materialNameSelect);
            this.materialSettings.Location = new System.Drawing.Point(12, 190);
            this.materialSettings.Name = "materialSettings";
            this.materialSettings.Size = new System.Drawing.Size(293, 72);
            this.materialSettings.TabIndex = 3;
            this.materialSettings.TabStop = false;
            this.materialSettings.Text = "Materials";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bitmaps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Material name:";
            // 
            // bitmapActionSelect
            // 
            this.bitmapActionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitmapActionSelect.Enabled = false;
            this.bitmapActionSelect.FormattingEnabled = true;
            this.bitmapActionSelect.Items.AddRange(new object[] {
            "Do nothing",
            "Copy",
            "Convert to PNG and copy",
            "Convert to JPG and copy",
            "Convert to TGA and copy",
            "Convert to DDS and copy"});
            this.bitmapActionSelect.Location = new System.Drawing.Point(140, 46);
            this.bitmapActionSelect.Name = "bitmapActionSelect";
            this.bitmapActionSelect.Size = new System.Drawing.Size(147, 21);
            this.bitmapActionSelect.TabIndex = 1;
            this.importToolTip.SetToolTip(this.bitmapActionSelect, "Action to perform when a diffuse bitmap is encountered");
            // 
            // ObjImportSettingsForm
            // 
            this.AcceptButton = this.importButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(317, 303);
            this.Controls.Add(this.materialSettings);
            this.Controls.Add(this.storeSettings);
            this.Controls.Add(this.otherSettingsGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.scaleGroup);
            this.Controls.Add(this.unitBaseGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjImportSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Obj import settings";
            this.Load += new System.EventHandler(this.ObjImportSettingsForm_Load);
            this.unitBaseGroup.ResumeLayout(false);
            this.unitBaseGroup.PerformLayout();
            this.scaleGroup.ResumeLayout(false);
            this.scaleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).EndInit();
            this.otherSettingsGroup.ResumeLayout(false);
            this.otherSettingsGroup.PerformLayout();
            this.materialSettings.ResumeLayout(false);
            this.materialSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox unitBaseGroup;
        private System.Windows.Forms.RadioButton unitBaseInch;
        private System.Windows.Forms.RadioButton unitBaseMetric;
        private System.Windows.Forms.GroupBox scaleGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xScale;
        private System.Windows.Forms.CheckBox xFlip;
        private System.Windows.Forms.CheckBox zFlip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown zScale;
        private System.Windows.Forms.CheckBox yFlip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown yScale;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox uniformScale;
        private System.Windows.Forms.GroupBox otherSettingsGroup;
        private System.Windows.Forms.CheckBox flipFacesCheck;
        private System.Windows.Forms.CheckBox uFlip;
        private System.Windows.Forms.CheckBox vFlip;
        private System.Windows.Forms.CheckBox yzSwap;
        private System.Windows.Forms.CheckBox storeSettings;
        private System.Windows.Forms.CheckBox withBone;
        private System.Windows.Forms.ComboBox materialNameSelect;
        private System.Windows.Forms.GroupBox materialSettings;
        private System.Windows.Forms.ComboBox bitmapActionSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HelpProvider importHelp;
        private System.Windows.Forms.ToolTip importToolTip;
    }
}