namespace wApplyMorph
{
    partial class ApplyMorphForm
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
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.boneRadio = new System.Windows.Forms.RadioButton();
            this.vertexRadio = new System.Windows.Forms.RadioButton();
            this.scanButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.applyNegativeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.affectedBonesLabel = new System.Windows.Forms.Label();
            this.affectedVertsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.appliedCountLabel = new System.Windows.Forms.Label();
            this.jaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.morphList = new System.Windows.Forms.ListView();
            this.selectedNameLabel = new System.Windows.Forms.Label();
            this.typeBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeBox.Controls.Add(this.boneRadio);
            this.typeBox.Controls.Add(this.vertexRadio);
            this.typeBox.Location = new System.Drawing.Point(122, 12);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(210, 68);
            this.typeBox.TabIndex = 0;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "Type:";
            // 
            // boneRadio
            // 
            this.boneRadio.AutoSize = true;
            this.boneRadio.Location = new System.Drawing.Point(6, 42);
            this.boneRadio.Name = "boneRadio";
            this.boneRadio.Size = new System.Drawing.Size(50, 17);
            this.boneRadio.TabIndex = 1;
            this.boneRadio.TabStop = true;
            this.boneRadio.Text = "Bone";
            this.boneRadio.UseVisualStyleBackColor = true;
            this.boneRadio.CheckedChanged += new System.EventHandler(this.typeRadio_CheckedChanged);
            // 
            // vertexRadio
            // 
            this.vertexRadio.AutoSize = true;
            this.vertexRadio.Location = new System.Drawing.Point(6, 19);
            this.vertexRadio.Name = "vertexRadio";
            this.vertexRadio.Size = new System.Drawing.Size(75, 17);
            this.vertexRadio.TabIndex = 0;
            this.vertexRadio.TabStop = true;
            this.vertexRadio.Text = "Vertex/UV";
            this.vertexRadio.UseVisualStyleBackColor = true;
            this.vertexRadio.CheckedChanged += new System.EventHandler(this.typeRadio_CheckedChanged);
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(12, 12);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(104, 68);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "SCAN\r\n(Press this first)";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(202, 258);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(130, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply morph";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // applyNegativeButton
            // 
            this.applyNegativeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyNegativeButton.Location = new System.Drawing.Point(202, 287);
            this.applyNegativeButton.Name = "applyNegativeButton";
            this.applyNegativeButton.Size = new System.Drawing.Size(130, 23);
            this.applyNegativeButton.TabIndex = 3;
            this.applyNegativeButton.Text = "Apply negative (revert)";
            this.applyNegativeButton.UseVisualStyleBackColor = true;
            this.applyNegativeButton.Click += new System.EventHandler(this.applyNegativeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.selectedNameLabel);
            this.groupBox1.Controls.Add(this.affectedBonesLabel);
            this.groupBox1.Controls.Add(this.affectedVertsLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.appliedCountLabel);
            this.groupBox1.Location = new System.Drawing.Point(202, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected:";
            // 
            // affectedBonesLabel
            // 
            this.affectedBonesLabel.AutoSize = true;
            this.affectedBonesLabel.Location = new System.Drawing.Point(32, 64);
            this.affectedBonesLabel.Name = "affectedBonesLabel";
            this.affectedBonesLabel.Size = new System.Drawing.Size(24, 13);
            this.affectedBonesLabel.TabIndex = 4;
            this.affectedBonesLabel.Text = "TBI";
            // 
            // affectedVertsLabel
            // 
            this.affectedVertsLabel.AutoSize = true;
            this.affectedVertsLabel.Location = new System.Drawing.Point(32, 41);
            this.affectedVertsLabel.Name = "affectedVertsLabel";
            this.affectedVertsLabel.Size = new System.Drawing.Size(24, 13);
            this.affectedVertsLabel.TabIndex = 3;
            this.affectedVertsLabel.Text = "TBI";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Applied:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // appliedCountLabel
            // 
            this.appliedCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appliedCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appliedCountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.appliedCountLabel.Location = new System.Drawing.Point(6, 126);
            this.appliedCountLabel.Name = "appliedCountLabel";
            this.appliedCountLabel.Size = new System.Drawing.Size(118, 37);
            this.appliedCountLabel.TabIndex = 1;
            this.appliedCountLabel.Text = "0";
            this.appliedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jaName
            // 
            this.jaName.Text = "Japanese";
            this.jaName.Width = 89;
            // 
            // enName
            // 
            this.enName.Text = "English";
            this.enName.Width = 88;
            // 
            // morphList
            // 
            this.morphList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.morphList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.morphList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jaName,
            this.enName});
            this.morphList.FullRowSelect = true;
            this.morphList.GridLines = true;
            this.morphList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.morphList.Location = new System.Drawing.Point(12, 86);
            this.morphList.MultiSelect = false;
            this.morphList.Name = "morphList";
            this.morphList.Size = new System.Drawing.Size(184, 224);
            this.morphList.TabIndex = 12;
            this.morphList.UseCompatibleStateImageBehavior = false;
            this.morphList.View = System.Windows.Forms.View.Details;
            this.morphList.SelectedIndexChanged += new System.EventHandler(this.morphList_SelectedIndexChanged);
            // 
            // selectedNameLabel
            // 
            this.selectedNameLabel.Location = new System.Drawing.Point(7, 16);
            this.selectedNameLabel.Name = "selectedNameLabel";
            this.selectedNameLabel.Size = new System.Drawing.Size(123, 15);
            this.selectedNameLabel.TabIndex = 5;
            this.selectedNameLabel.Text = "None selected";
            // 
            // ApplyMorphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 322);
            this.Controls.Add(this.morphList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applyNegativeButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.typeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyMorphForm";
            this.Text = "wApplyMorph";
            this.Load += new System.EventHandler(this.ApplyMorphForm_Load);
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.RadioButton vertexRadio;
        private System.Windows.Forms.RadioButton boneRadio;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button applyNegativeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader jaName;
        private System.Windows.Forms.ColumnHeader enName;
        private System.Windows.Forms.ListView morphList;
        private System.Windows.Forms.Label appliedCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label affectedVertsLabel;
        private System.Windows.Forms.Label affectedBonesLabel;
        private System.Windows.Forms.Label selectedNameLabel;
    }
}