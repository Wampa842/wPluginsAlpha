namespace wNameUtil
{
    partial class NameUtilForm
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
            this.modeBox = new System.Windows.Forms.GroupBox();
            this.keepExisting = new System.Windows.Forms.CheckBox();
            this.modeTranslateJpEn = new System.Windows.Forms.RadioButton();
            this.modeCopyUnknown = new System.Windows.Forms.CheckBox();
            this.modeCopyJpEn = new System.Windows.Forms.RadioButton();
            this.modeTranslateEnJp = new System.Windows.Forms.RadioButton();
            this.modeCopyEnJp = new System.Windows.Forms.RadioButton();
            this.capitalizeSelect = new System.Windows.Forms.ComboBox();
            this.updateFileButton = new System.Windows.Forms.Button();
            this.subjectSelect = new System.Windows.Forms.GroupBox();
            this.affectSelected = new System.Windows.Forms.CheckBox();
            this.subjectJoint = new System.Windows.Forms.RadioButton();
            this.subjectBody = new System.Windows.Forms.RadioButton();
            this.subjectGroup = new System.Windows.Forms.RadioButton();
            this.subjectBone = new System.Windows.Forms.RadioButton();
            this.subjectMorph = new System.Windows.Forms.RadioButton();
            this.subjectMaterial = new System.Windows.Forms.RadioButton();
            this.selectList = new System.Windows.Forms.ListView();
            this.columnNameJp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameEn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectAll = new System.Windows.Forms.Button();
            this.selectRegex = new System.Windows.Forms.Button();
            this.selectInvert = new System.Windows.Forms.Button();
            this.selectNone = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.openSettings = new System.Windows.Forms.Button();
            this.modeBox.SuspendLayout();
            this.subjectSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // modeBox
            // 
            this.modeBox.Controls.Add(this.keepExisting);
            this.modeBox.Controls.Add(this.modeTranslateJpEn);
            this.modeBox.Controls.Add(this.modeCopyUnknown);
            this.modeBox.Controls.Add(this.modeCopyJpEn);
            this.modeBox.Controls.Add(this.modeTranslateEnJp);
            this.modeBox.Controls.Add(this.modeCopyEnJp);
            this.modeBox.Location = new System.Drawing.Point(12, 170);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(340, 115);
            this.modeBox.TabIndex = 9;
            this.modeBox.TabStop = false;
            this.modeBox.Tag = "";
            this.modeBox.Text = "Translation mode";
            // 
            // keepExisting
            // 
            this.keepExisting.AutoSize = true;
            this.keepExisting.Checked = true;
            this.keepExisting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepExisting.Location = new System.Drawing.Point(6, 88);
            this.keepExisting.Name = "keepExisting";
            this.keepExisting.Size = new System.Drawing.Size(123, 17);
            this.keepExisting.TabIndex = 5;
            this.keepExisting.Text = "Keep existing names";
            this.keepExisting.UseVisualStyleBackColor = true;
            // 
            // modeTranslateJpEn
            // 
            this.modeTranslateJpEn.AutoSize = true;
            this.modeTranslateJpEn.Location = new System.Drawing.Point(6, 42);
            this.modeTranslateJpEn.Name = "modeTranslateJpEn";
            this.modeTranslateJpEn.Size = new System.Drawing.Size(114, 17);
            this.modeTranslateJpEn.TabIndex = 1;
            this.modeTranslateJpEn.Tag = "3";
            this.modeTranslateJpEn.Text = "Translate JP to EN";
            this.modeTranslateJpEn.UseVisualStyleBackColor = true;
            // 
            // modeCopyUnknown
            // 
            this.modeCopyUnknown.AutoSize = true;
            this.modeCopyUnknown.Location = new System.Drawing.Point(6, 65);
            this.modeCopyUnknown.Name = "modeCopyUnknown";
            this.modeCopyUnknown.Size = new System.Drawing.Size(298, 17);
            this.modeCopyUnknown.TabIndex = 4;
            this.modeCopyUnknown.Text = "If there is no translation to a name, copy the name instead";
            this.modeCopyUnknown.UseVisualStyleBackColor = true;
            // 
            // modeCopyJpEn
            // 
            this.modeCopyJpEn.AutoSize = true;
            this.modeCopyJpEn.Checked = true;
            this.modeCopyJpEn.Location = new System.Drawing.Point(6, 19);
            this.modeCopyJpEn.Name = "modeCopyJpEn";
            this.modeCopyJpEn.Size = new System.Drawing.Size(94, 17);
            this.modeCopyJpEn.TabIndex = 0;
            this.modeCopyJpEn.TabStop = true;
            this.modeCopyJpEn.Tag = "1";
            this.modeCopyJpEn.Text = "Copy JP to EN";
            this.modeCopyJpEn.UseVisualStyleBackColor = true;
            // 
            // modeTranslateEnJp
            // 
            this.modeTranslateEnJp.AutoSize = true;
            this.modeTranslateEnJp.Location = new System.Drawing.Point(177, 42);
            this.modeTranslateEnJp.Name = "modeTranslateEnJp";
            this.modeTranslateEnJp.Size = new System.Drawing.Size(114, 17);
            this.modeTranslateEnJp.TabIndex = 3;
            this.modeTranslateEnJp.Tag = "4";
            this.modeTranslateEnJp.Text = "Translate EN to JP";
            this.modeTranslateEnJp.UseVisualStyleBackColor = true;
            // 
            // modeCopyEnJp
            // 
            this.modeCopyEnJp.AutoSize = true;
            this.modeCopyEnJp.Location = new System.Drawing.Point(177, 19);
            this.modeCopyEnJp.Name = "modeCopyEnJp";
            this.modeCopyEnJp.Size = new System.Drawing.Size(94, 17);
            this.modeCopyEnJp.TabIndex = 2;
            this.modeCopyEnJp.Tag = "2";
            this.modeCopyEnJp.Text = "Copy EN to JP";
            this.modeCopyEnJp.UseVisualStyleBackColor = true;
            // 
            // capitalizeSelect
            // 
            this.capitalizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.capitalizeSelect.FormattingEnabled = true;
            this.capitalizeSelect.Items.AddRange(new object[] {
            "Do not modify capitalization",
            "Convert to lowercase",
            "Convert to lowercase with uppercase initial",
            "Convert to uppercase"});
            this.capitalizeSelect.Location = new System.Drawing.Point(12, 291);
            this.capitalizeSelect.Name = "capitalizeSelect";
            this.capitalizeSelect.Size = new System.Drawing.Size(340, 21);
            this.capitalizeSelect.TabIndex = 10;
            // 
            // updateFileButton
            // 
            this.updateFileButton.Location = new System.Drawing.Point(12, 12);
            this.updateFileButton.Name = "updateFileButton";
            this.updateFileButton.Size = new System.Drawing.Size(195, 23);
            this.updateFileButton.TabIndex = 0;
            this.updateFileButton.Text = "Update dictionary file";
            this.updateFileButton.UseVisualStyleBackColor = true;
            this.updateFileButton.Click += new System.EventHandler(this.updateFileButton_Click);
            // 
            // subjectSelect
            // 
            this.subjectSelect.Controls.Add(this.affectSelected);
            this.subjectSelect.Controls.Add(this.subjectJoint);
            this.subjectSelect.Controls.Add(this.subjectBody);
            this.subjectSelect.Controls.Add(this.subjectGroup);
            this.subjectSelect.Controls.Add(this.subjectBone);
            this.subjectSelect.Controls.Add(this.subjectMorph);
            this.subjectSelect.Controls.Add(this.subjectMaterial);
            this.subjectSelect.Location = new System.Drawing.Point(12, 41);
            this.subjectSelect.Name = "subjectSelect";
            this.subjectSelect.Size = new System.Drawing.Size(340, 123);
            this.subjectSelect.TabIndex = 2;
            this.subjectSelect.TabStop = false;
            this.subjectSelect.Text = "Select subjects";
            // 
            // affectSelected
            // 
            this.affectSelected.AutoSize = true;
            this.affectSelected.Location = new System.Drawing.Point(6, 88);
            this.affectSelected.Name = "affectSelected";
            this.affectSelected.Size = new System.Drawing.Size(120, 17);
            this.affectSelected.TabIndex = 6;
            this.affectSelected.Text = "Only affect selected";
            this.affectSelected.UseVisualStyleBackColor = true;
            this.affectSelected.CheckedChanged += new System.EventHandler(this.affectSelected_CheckedChanged);
            // 
            // subjectJoint
            // 
            this.subjectJoint.AutoSize = true;
            this.subjectJoint.Location = new System.Drawing.Point(154, 65);
            this.subjectJoint.Name = "subjectJoint";
            this.subjectJoint.Size = new System.Drawing.Size(52, 17);
            this.subjectJoint.TabIndex = 5;
            this.subjectJoint.Text = "Joints";
            this.subjectJoint.UseVisualStyleBackColor = true;
            this.subjectJoint.CheckedChanged += new System.EventHandler(this.SelectSubjects_CheckedChanged);
            // 
            // subjectBody
            // 
            this.subjectBody.AutoSize = true;
            this.subjectBody.Location = new System.Drawing.Point(6, 65);
            this.subjectBody.Name = "subjectBody";
            this.subjectBody.Size = new System.Drawing.Size(83, 17);
            this.subjectBody.TabIndex = 4;
            this.subjectBody.Text = "Rigid bodies";
            this.subjectBody.UseVisualStyleBackColor = true;
            this.subjectBody.CheckedChanged += new System.EventHandler(this.SelectSubjects_CheckedChanged);
            // 
            // subjectGroup
            // 
            this.subjectGroup.AutoSize = true;
            this.subjectGroup.Location = new System.Drawing.Point(154, 42);
            this.subjectGroup.Name = "subjectGroup";
            this.subjectGroup.Size = new System.Drawing.Size(89, 17);
            this.subjectGroup.TabIndex = 3;
            this.subjectGroup.Text = "Frame groups";
            this.subjectGroup.UseVisualStyleBackColor = true;
            this.subjectGroup.CheckedChanged += new System.EventHandler(this.SelectSubjects_CheckedChanged);
            // 
            // subjectBone
            // 
            this.subjectBone.AutoSize = true;
            this.subjectBone.Location = new System.Drawing.Point(154, 19);
            this.subjectBone.Name = "subjectBone";
            this.subjectBone.Size = new System.Drawing.Size(55, 17);
            this.subjectBone.TabIndex = 1;
            this.subjectBone.Text = "Bones";
            this.subjectBone.UseVisualStyleBackColor = true;
            this.subjectBone.CheckedChanged += new System.EventHandler(this.SelectSubjects_CheckedChanged);
            // 
            // subjectMorph
            // 
            this.subjectMorph.AutoSize = true;
            this.subjectMorph.Location = new System.Drawing.Point(6, 42);
            this.subjectMorph.Name = "subjectMorph";
            this.subjectMorph.Size = new System.Drawing.Size(60, 17);
            this.subjectMorph.TabIndex = 2;
            this.subjectMorph.Text = "Morphs";
            this.subjectMorph.UseVisualStyleBackColor = true;
            this.subjectMorph.CheckedChanged += new System.EventHandler(this.SelectSubjects_CheckedChanged);
            // 
            // subjectMaterial
            // 
            this.subjectMaterial.AutoSize = true;
            this.subjectMaterial.Checked = true;
            this.subjectMaterial.Location = new System.Drawing.Point(6, 19);
            this.subjectMaterial.Name = "subjectMaterial";
            this.subjectMaterial.Size = new System.Drawing.Size(67, 17);
            this.subjectMaterial.TabIndex = 0;
            this.subjectMaterial.TabStop = true;
            this.subjectMaterial.Text = "Materials";
            this.subjectMaterial.UseVisualStyleBackColor = true;
            this.subjectMaterial.CheckedChanged += new System.EventHandler(this.SelectSubjects_CheckedChanged);
            // 
            // selectList
            // 
            this.selectList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.selectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectList.CheckBoxes = true;
            this.selectList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameJp,
            this.columnNameEn});
            this.selectList.FullRowSelect = true;
            this.selectList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.selectList.Location = new System.Drawing.Point(358, 12);
            this.selectList.MultiSelect = false;
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(234, 301);
            this.selectList.TabIndex = 4;
            this.selectList.UseCompatibleStateImageBehavior = false;
            this.selectList.View = System.Windows.Forms.View.Details;
            // 
            // columnNameJp
            // 
            this.columnNameJp.Text = "Japanese";
            this.columnNameJp.Width = 89;
            // 
            // columnNameEn
            // 
            this.columnNameEn.Text = "English";
            this.columnNameEn.Width = 132;
            // 
            // selectAll
            // 
            this.selectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectAll.Location = new System.Drawing.Point(382, 319);
            this.selectAll.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(42, 23);
            this.selectAll.TabIndex = 5;
            this.selectAll.Text = "All";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // selectRegex
            // 
            this.selectRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectRegex.Location = new System.Drawing.Point(521, 319);
            this.selectRegex.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.selectRegex.Name = "selectRegex";
            this.selectRegex.Size = new System.Drawing.Size(74, 23);
            this.selectRegex.TabIndex = 8;
            this.selectRegex.Text = "Regex...";
            this.selectRegex.UseVisualStyleBackColor = true;
            this.selectRegex.Click += new System.EventHandler(this.selectRegex_Click);
            // 
            // selectInvert
            // 
            this.selectInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectInvert.Location = new System.Drawing.Point(473, 319);
            this.selectInvert.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.selectInvert.Name = "selectInvert";
            this.selectInvert.Size = new System.Drawing.Size(48, 23);
            this.selectInvert.TabIndex = 7;
            this.selectInvert.Text = "Invert";
            this.selectInvert.UseVisualStyleBackColor = true;
            this.selectInvert.Click += new System.EventHandler(this.selectInvert_Click);
            // 
            // selectNone
            // 
            this.selectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectNone.Location = new System.Drawing.Point(424, 319);
            this.selectNone.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.selectNone.Name = "selectNone";
            this.selectNone.Size = new System.Drawing.Size(49, 23);
            this.selectNone.TabIndex = 6;
            this.selectNone.Text = "None";
            this.selectNone.UseVisualStyleBackColor = true;
            this.selectNone.Click += new System.EventHandler(this.selectNone_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applyButton.Location = new System.Drawing.Point(12, 318);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(171, 23);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(259, 318);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.refreshButton.Location = new System.Drawing.Point(189, 319);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(64, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // openSettings
            // 
            this.openSettings.Location = new System.Drawing.Point(213, 12);
            this.openSettings.Name = "openSettings";
            this.openSettings.Size = new System.Drawing.Size(139, 23);
            this.openSettings.TabIndex = 1;
            this.openSettings.Text = "Settings...";
            this.openSettings.UseVisualStyleBackColor = true;
            this.openSettings.Click += new System.EventHandler(this.openSettings_Click);
            // 
            // NameUtilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(604, 352);
            this.Controls.Add(this.openSettings);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.selectNone);
            this.Controls.Add(this.selectInvert);
            this.Controls.Add(this.selectRegex);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.subjectSelect);
            this.Controls.Add(this.updateFileButton);
            this.Controls.Add(this.capitalizeSelect);
            this.Controls.Add(this.modeBox);
            this.MinimumSize = new System.Drawing.Size(620, 390);
            this.Name = "NameUtilForm";
            this.Text = "wNameUtil";
            this.Load += new System.EventHandler(this.NameUtilForm_Load);
            this.modeBox.ResumeLayout(false);
            this.modeBox.PerformLayout();
            this.subjectSelect.ResumeLayout(false);
            this.subjectSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox modeBox;
        private System.Windows.Forms.RadioButton modeTranslateEnJp;
        private System.Windows.Forms.RadioButton modeCopyEnJp;
        private System.Windows.Forms.CheckBox modeCopyUnknown;
        private System.Windows.Forms.RadioButton modeTranslateJpEn;
        private System.Windows.Forms.RadioButton modeCopyJpEn;
        private System.Windows.Forms.ComboBox capitalizeSelect;
        private System.Windows.Forms.Button updateFileButton;
        private System.Windows.Forms.GroupBox subjectSelect;
        private System.Windows.Forms.RadioButton subjectGroup;
        private System.Windows.Forms.RadioButton subjectBone;
        private System.Windows.Forms.RadioButton subjectMorph;
        private System.Windows.Forms.RadioButton subjectMaterial;
        private System.Windows.Forms.RadioButton subjectJoint;
        private System.Windows.Forms.RadioButton subjectBody;
        private System.Windows.Forms.CheckBox affectSelected;
        private System.Windows.Forms.ListView selectList;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Button selectRegex;
        private System.Windows.Forms.Button selectInvert;
        private System.Windows.Forms.Button selectNone;
        private System.Windows.Forms.ColumnHeader columnNameJp;
        private System.Windows.Forms.ColumnHeader columnNameEn;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.CheckBox keepExisting;
        private System.Windows.Forms.Button openSettings;
    }
}