namespace wMergeMaterials
{
    partial class MaterialListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.selectNoneButton = new System.Windows.Forms.Button();
            this.selectInvertButton = new System.Windows.Forms.Button();
            this.materialList = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectAllButton);
            this.panel1.Controls.Add(this.selectNoneButton);
            this.panel1.Controls.Add(this.selectInvertButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 30);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select:";
            // 
            // selectAllButton
            // 
            this.selectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllButton.Location = new System.Drawing.Point(83, 3);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(54, 23);
            this.selectAllButton.TabIndex = 2;
            this.selectAllButton.Text = "All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // selectNoneButton
            // 
            this.selectNoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectNoneButton.Location = new System.Drawing.Point(143, 4);
            this.selectNoneButton.Name = "selectNoneButton";
            this.selectNoneButton.Size = new System.Drawing.Size(54, 23);
            this.selectNoneButton.TabIndex = 1;
            this.selectNoneButton.Text = "None";
            this.selectNoneButton.UseVisualStyleBackColor = true;
            this.selectNoneButton.Click += new System.EventHandler(this.selectNoneButton_Click);
            // 
            // selectInvertButton
            // 
            this.selectInvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectInvertButton.Location = new System.Drawing.Point(203, 3);
            this.selectInvertButton.Name = "selectInvertButton";
            this.selectInvertButton.Size = new System.Drawing.Size(54, 23);
            this.selectInvertButton.TabIndex = 0;
            this.selectInvertButton.Text = "Invert";
            this.selectInvertButton.UseVisualStyleBackColor = true;
            this.selectInvertButton.Click += new System.EventHandler(this.selectInvertButton_Click);
            // 
            // materialList
            // 
            this.materialList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialList.CheckOnClick = true;
            this.materialList.FormattingEnabled = true;
            this.materialList.IntegralHeight = false;
            this.materialList.Location = new System.Drawing.Point(12, 48);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(260, 252);
            this.materialList.TabIndex = 2;
            // 
            // MaterialListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.materialList);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "MaterialListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MaterialListForm";
            this.Load += new System.EventHandler(this.MaterialListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox materialList;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button selectNoneButton;
        private System.Windows.Forms.Button selectInvertButton;
        private System.Windows.Forms.Label label1;
    }
}