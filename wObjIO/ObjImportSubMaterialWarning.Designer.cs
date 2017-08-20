namespace wObjIO
{
    partial class ObjImportSubMaterialWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjImportSubMaterialWarning));
            this.label1 = new System.Windows.Forms.Label();
            this.rememberThisTime = new System.Windows.Forms.CheckBox();
            this.rememberForever = new System.Windows.Forms.CheckBox();
            this.falsePositiveReport = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // rememberThisTime
            // 
            this.rememberThisTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rememberThisTime.AutoSize = true;
            this.rememberThisTime.Location = new System.Drawing.Point(12, 108);
            this.rememberThisTime.Name = "rememberThisTime";
            this.rememberThisTime.Size = new System.Drawing.Size(253, 17);
            this.rememberThisTime.TabIndex = 1;
            this.rememberThisTime.Text = "Do the same for every detected object in this file";
            this.rememberThisTime.UseVisualStyleBackColor = true;
            // 
            // rememberForever
            // 
            this.rememberForever.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rememberForever.AutoSize = true;
            this.rememberForever.Location = new System.Drawing.Point(12, 131);
            this.rememberForever.Name = "rememberForever";
            this.rememberForever.Size = new System.Drawing.Size(128, 17);
            this.rememberForever.TabIndex = 1;
            this.rememberForever.Text = "Remember my choice";
            this.rememberForever.UseVisualStyleBackColor = true;
            // 
            // falsePositiveReport
            // 
            this.falsePositiveReport.AutoSize = true;
            this.falsePositiveReport.LinkArea = new System.Windows.Forms.LinkArea(70, 75);
            this.falsePositiveReport.Location = new System.Drawing.Point(12, 68);
            this.falsePositiveReport.Name = "falsePositiveReport";
            this.falsePositiveReport.Size = new System.Drawing.Size(349, 17);
            this.falsePositiveReport.TabIndex = 2;
            this.falsePositiveReport.TabStop = true;
            this.falsePositiveReport.Text = "Is this a false positive? If the plugin is mistaken, please report it here!";
            this.falsePositiveReport.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Try to separate sub-materials into objects";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(12, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(387, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Import the sub-materials as the same object";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(12, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(387, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Skip the object (might import partial object)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(12, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(387, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancel importing";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ObjImportSubMaterialWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 276);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.falsePositiveReport);
            this.Controls.Add(this.rememberForever);
            this.Controls.Add(this.rememberThisTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ObjImportSubMaterialWarning";
            this.Text = "Warning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rememberThisTime;
        private System.Windows.Forms.CheckBox rememberForever;
        private System.Windows.Forms.LinkLabel falsePositiveReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}