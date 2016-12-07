namespace wMorphScale
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
            System.Windows.Forms.LinkLabel inverseHelpLink;
            this.morphTypeGroup = new System.Windows.Forms.GroupBox();
            this.addNewCheck = new System.Windows.Forms.CheckBox();
            this.boneRotTypeCheck = new System.Windows.Forms.RadioButton();
            this.boneTypeCheck = new System.Windows.Forms.RadioButton();
            this.vertexTypeCheck = new System.Windows.Forms.RadioButton();
            this.transformsBox = new System.Windows.Forms.GroupBox();
            this.invertButton = new System.Windows.Forms.Button();
            this.negateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.zMultiplier = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.yMultiplier = new System.Windows.Forms.NumericUpDown();
            this.xMultiplier = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uniformMultiplier = new System.Windows.Forms.NumericUpDown();
            this.vectorScaleCheck = new System.Windows.Forms.RadioButton();
            this.scalarScaleCheck = new System.Windows.Forms.RadioButton();
            this.applyButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.morphList = new System.Windows.Forms.ListView();
            this.jaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vertexChannelChoice = new System.Windows.Forms.ComboBox();
            inverseHelpLink = new System.Windows.Forms.LinkLabel();
            this.morphTypeGroup.SuspendLayout();
            this.transformsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // inverseHelpLink
            // 
            inverseHelpLink.AutoSize = true;
            inverseHelpLink.Location = new System.Drawing.Point(111, 211);
            inverseHelpLink.Name = "inverseHelpLink";
            inverseHelpLink.Size = new System.Drawing.Size(13, 13);
            inverseHelpLink.TabIndex = 12;
            inverseHelpLink.TabStop = true;
            inverseHelpLink.Text = "?";
            inverseHelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inverseHelpLink_LinkClicked);
            // 
            // morphTypeGroup
            // 
            this.morphTypeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.morphTypeGroup.Controls.Add(this.vertexChannelChoice);
            this.morphTypeGroup.Controls.Add(this.addNewCheck);
            this.morphTypeGroup.Controls.Add(this.boneRotTypeCheck);
            this.morphTypeGroup.Controls.Add(this.boneTypeCheck);
            this.morphTypeGroup.Controls.Add(this.vertexTypeCheck);
            this.morphTypeGroup.Location = new System.Drawing.Point(12, 12);
            this.morphTypeGroup.Name = "morphTypeGroup";
            this.morphTypeGroup.Size = new System.Drawing.Size(268, 69);
            this.morphTypeGroup.TabIndex = 0;
            this.morphTypeGroup.TabStop = false;
            this.morphTypeGroup.Text = "Morph type:";
            // 
            // addNewCheck
            // 
            this.addNewCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewCheck.AutoSize = true;
            this.addNewCheck.Checked = true;
            this.addNewCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addNewCheck.Location = new System.Drawing.Point(162, 20);
            this.addNewCheck.Name = "addNewCheck";
            this.addNewCheck.Size = new System.Drawing.Size(100, 17);
            this.addNewCheck.TabIndex = 4;
            this.addNewCheck.Text = "Add new morph";
            this.addNewCheck.UseVisualStyleBackColor = true;
            // 
            // boneRotTypeCheck
            // 
            this.boneRotTypeCheck.AutoSize = true;
            this.boneRotTypeCheck.Location = new System.Drawing.Point(119, 42);
            this.boneRotTypeCheck.Name = "boneRotTypeCheck";
            this.boneRotTypeCheck.Size = new System.Drawing.Size(94, 17);
            this.boneRotTypeCheck.TabIndex = 3;
            this.boneRotTypeCheck.Text = "Bone (rotation)";
            this.boneRotTypeCheck.UseVisualStyleBackColor = true;
            // 
            // boneTypeCheck
            // 
            this.boneTypeCheck.AutoSize = true;
            this.boneTypeCheck.Location = new System.Drawing.Point(6, 42);
            this.boneTypeCheck.Name = "boneTypeCheck";
            this.boneTypeCheck.Size = new System.Drawing.Size(107, 17);
            this.boneTypeCheck.TabIndex = 2;
            this.boneTypeCheck.Text = "Bone (translation)";
            this.boneTypeCheck.UseVisualStyleBackColor = true;
            this.boneTypeCheck.CheckedChanged += new System.EventHandler(this.morphTypeChanged);
            // 
            // vertexTypeCheck
            // 
            this.vertexTypeCheck.AutoSize = true;
            this.vertexTypeCheck.Checked = true;
            this.vertexTypeCheck.Location = new System.Drawing.Point(6, 19);
            this.vertexTypeCheck.Name = "vertexTypeCheck";
            this.vertexTypeCheck.Size = new System.Drawing.Size(75, 17);
            this.vertexTypeCheck.TabIndex = 1;
            this.vertexTypeCheck.TabStop = true;
            this.vertexTypeCheck.Text = "Vertex/UV";
            this.vertexTypeCheck.UseVisualStyleBackColor = true;
            this.vertexTypeCheck.CheckedChanged += new System.EventHandler(this.morphTypeChanged);
            // 
            // transformsBox
            // 
            this.transformsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transformsBox.Controls.Add(inverseHelpLink);
            this.transformsBox.Controls.Add(this.invertButton);
            this.transformsBox.Controls.Add(this.negateButton);
            this.transformsBox.Controls.Add(this.label4);
            this.transformsBox.Controls.Add(this.zMultiplier);
            this.transformsBox.Controls.Add(this.label3);
            this.transformsBox.Controls.Add(this.yMultiplier);
            this.transformsBox.Controls.Add(this.xMultiplier);
            this.transformsBox.Controls.Add(this.label2);
            this.transformsBox.Controls.Add(this.label1);
            this.transformsBox.Controls.Add(this.uniformMultiplier);
            this.transformsBox.Controls.Add(this.vectorScaleCheck);
            this.transformsBox.Controls.Add(this.scalarScaleCheck);
            this.transformsBox.Location = new System.Drawing.Point(237, 87);
            this.transformsBox.Name = "transformsBox";
            this.transformsBox.Size = new System.Drawing.Size(135, 234);
            this.transformsBox.TabIndex = 2;
            this.transformsBox.TabStop = false;
            this.transformsBox.Text = "Scale:";
            // 
            // invertButton
            // 
            this.invertButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.invertButton.Location = new System.Drawing.Point(26, 206);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(79, 22);
            this.invertButton.TabIndex = 11;
            this.invertButton.Text = "Inverse (1/x)";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // negateButton
            // 
            this.negateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.negateButton.Location = new System.Drawing.Point(26, 178);
            this.negateButton.Name = "negateButton";
            this.negateButton.Size = new System.Drawing.Size(79, 22);
            this.negateButton.TabIndex = 10;
            this.negateButton.Text = "Negative (-x)";
            this.negateButton.UseVisualStyleBackColor = true;
            this.negateButton.Click += new System.EventHandler(this.negateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Scale:";
            // 
            // zMultiplier
            // 
            this.zMultiplier.DecimalPlaces = 3;
            this.zMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.zMultiplier.Location = new System.Drawing.Point(26, 143);
            this.zMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.zMultiplier.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.zMultiplier.Name = "zMultiplier";
            this.zMultiplier.Size = new System.Drawing.Size(103, 20);
            this.zMultiplier.TabIndex = 8;
            this.zMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // yMultiplier
            // 
            this.yMultiplier.DecimalPlaces = 3;
            this.yMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yMultiplier.Location = new System.Drawing.Point(26, 117);
            this.yMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yMultiplier.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.yMultiplier.Name = "yMultiplier";
            this.yMultiplier.Size = new System.Drawing.Size(103, 20);
            this.yMultiplier.TabIndex = 6;
            this.yMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xMultiplier
            // 
            this.xMultiplier.DecimalPlaces = 3;
            this.xMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xMultiplier.Location = new System.Drawing.Point(26, 91);
            this.xMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xMultiplier.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.xMultiplier.Name = "xMultiplier";
            this.xMultiplier.Size = new System.Drawing.Size(103, 20);
            this.xMultiplier.TabIndex = 5;
            this.xMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // uniformMultiplier
            // 
            this.uniformMultiplier.DecimalPlaces = 3;
            this.uniformMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uniformMultiplier.Location = new System.Drawing.Point(55, 42);
            this.uniformMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uniformMultiplier.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.uniformMultiplier.Name = "uniformMultiplier";
            this.uniformMultiplier.Size = new System.Drawing.Size(74, 20);
            this.uniformMultiplier.TabIndex = 2;
            this.uniformMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // vectorScaleCheck
            // 
            this.vectorScaleCheck.AutoSize = true;
            this.vectorScaleCheck.Location = new System.Drawing.Point(6, 68);
            this.vectorScaleCheck.Name = "vectorScaleCheck";
            this.vectorScaleCheck.Size = new System.Drawing.Size(82, 17);
            this.vectorScaleCheck.TabIndex = 1;
            this.vectorScaleCheck.Text = "Non-uniform";
            this.vectorScaleCheck.UseVisualStyleBackColor = true;
            this.vectorScaleCheck.CheckedChanged += new System.EventHandler(this.uniformityCheckedChanged);
            // 
            // scalarScaleCheck
            // 
            this.scalarScaleCheck.AutoSize = true;
            this.scalarScaleCheck.Checked = true;
            this.scalarScaleCheck.Location = new System.Drawing.Point(6, 19);
            this.scalarScaleCheck.Name = "scalarScaleCheck";
            this.scalarScaleCheck.Size = new System.Drawing.Size(61, 17);
            this.scalarScaleCheck.TabIndex = 0;
            this.scalarScaleCheck.TabStop = true;
            this.scalarScaleCheck.Text = "Uniform";
            this.scalarScaleCheck.UseVisualStyleBackColor = true;
            this.scalarScaleCheck.CheckedChanged += new System.EventHandler(this.uniformityCheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(237, 327);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(135, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(286, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(86, 69);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh list";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // morphList
            // 
            this.morphList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.morphList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.morphList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jaName,
            this.enName,
            this.index});
            this.morphList.FullRowSelect = true;
            this.morphList.GridLines = true;
            this.morphList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.morphList.Location = new System.Drawing.Point(12, 87);
            this.morphList.MultiSelect = false;
            this.morphList.Name = "morphList";
            this.morphList.Size = new System.Drawing.Size(219, 263);
            this.morphList.TabIndex = 11;
            this.morphList.UseCompatibleStateImageBehavior = false;
            this.morphList.View = System.Windows.Forms.View.Details;
            // 
            // jaName
            // 
            this.jaName.Text = "Japanese";
            this.jaName.Width = 70;
            // 
            // enName
            // 
            this.enName.Text = "English";
            this.enName.Width = 100;
            // 
            // index
            // 
            this.index.Text = "#";
            this.index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.index.Width = 30;
            // 
            // vertexChannelChoice
            // 
            this.vertexChannelChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexChannelChoice.FormattingEnabled = true;
            this.vertexChannelChoice.Items.AddRange(new object[] {
            "Vertex",
            "UV",
            "UV1",
            "UV2",
            "UV3",
            "UV4"});
            this.vertexChannelChoice.Location = new System.Drawing.Point(87, 18);
            this.vertexChannelChoice.Name = "vertexChannelChoice";
            this.vertexChannelChoice.Size = new System.Drawing.Size(59, 21);
            this.vertexChannelChoice.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.morphList);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.transformsBox);
            this.Controls.Add(this.morphTypeGroup);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "wMorphScale";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.morphTypeGroup.ResumeLayout(false);
            this.morphTypeGroup.PerformLayout();
            this.transformsBox.ResumeLayout(false);
            this.transformsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformMultiplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox morphTypeGroup;
        private System.Windows.Forms.RadioButton boneTypeCheck;
        private System.Windows.Forms.RadioButton vertexTypeCheck;
        private System.Windows.Forms.GroupBox transformsBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.RadioButton scalarScaleCheck;
        private System.Windows.Forms.RadioButton vectorScaleCheck;
        private System.Windows.Forms.NumericUpDown uniformMultiplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown zMultiplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yMultiplier;
        private System.Windows.Forms.NumericUpDown xMultiplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button negateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.RadioButton boneRotTypeCheck;
        private System.Windows.Forms.ListView morphList;
        private System.Windows.Forms.ColumnHeader jaName;
        private System.Windows.Forms.ColumnHeader enName;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.CheckBox addNewCheck;
        private System.Windows.Forms.ComboBox vertexChannelChoice;
    }
}