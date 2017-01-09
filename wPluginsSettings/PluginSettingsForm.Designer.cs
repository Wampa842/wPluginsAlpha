namespace wPluginsSettings
{
    partial class PluginSettingsForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pluginList = new System.Windows.Forms.ListBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.autoStartCheck = new System.Windows.Forms.CheckBox();
            this.storeSettingsCheck = new System.Windows.Forms.CheckBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.revertSettingsButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(451, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSettingsToolStripMenuItem,
            this.importSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportSettingsToolStripMenuItem
            // 
            this.exportSettingsToolStripMenuItem.Name = "exportSettingsToolStripMenuItem";
            this.exportSettingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exportSettingsToolStripMenuItem.Text = "Export settings";
            // 
            // importSettingsToolStripMenuItem
            // 
            this.importSettingsToolStripMenuItem.Name = "importSettingsToolStripMenuItem";
            this.importSettingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.importSettingsToolStripMenuItem.Text = "Import settings";
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 24);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.label1);
            this.mainContainer.Panel1.Controls.Add(this.pluginList);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.revertSettingsButton);
            this.mainContainer.Panel2.Controls.Add(this.saveSettingsButton);
            this.mainContainer.Panel2.Controls.Add(this.settingsGroupBox);
            this.mainContainer.Size = new System.Drawing.Size(451, 339);
            this.mainContainer.SplitterDistance = 124;
            this.mainContainer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plugins";
            // 
            // pluginList
            // 
            this.pluginList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginList.FormattingEnabled = true;
            this.pluginList.IntegralHeight = false;
            this.pluginList.Location = new System.Drawing.Point(3, 30);
            this.pluginList.Name = "pluginList";
            this.pluginList.Size = new System.Drawing.Size(118, 306);
            this.pluginList.TabIndex = 0;
            this.pluginList.SelectedIndexChanged += new System.EventHandler(this.pluginList_SelectedIndexChanged);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.Controls.Add(this.storeSettingsCheck);
            this.settingsGroupBox.Controls.Add(this.autoStartCheck);
            this.settingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(317, 289);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "groupBox1";
            // 
            // autoStartCheck
            // 
            this.autoStartCheck.AutoSize = true;
            this.autoStartCheck.Location = new System.Drawing.Point(6, 27);
            this.autoStartCheck.Name = "autoStartCheck";
            this.autoStartCheck.Size = new System.Drawing.Size(96, 17);
            this.autoStartCheck.TabIndex = 0;
            this.autoStartCheck.Text = "Start with PMX";
            this.autoStartCheck.UseVisualStyleBackColor = true;
            this.autoStartCheck.CheckedChanged += new System.EventHandler(this.autoStartCheck_CheckedChanged);
            // 
            // storeSettingsCheck
            // 
            this.storeSettingsCheck.AutoSize = true;
            this.storeSettingsCheck.Location = new System.Drawing.Point(6, 50);
            this.storeSettingsCheck.Name = "storeSettingsCheck";
            this.storeSettingsCheck.Size = new System.Drawing.Size(90, 17);
            this.storeSettingsCheck.TabIndex = 1;
            this.storeSettingsCheck.Text = "Store settings";
            this.storeSettingsCheck.UseVisualStyleBackColor = true;
            this.storeSettingsCheck.CheckedChanged += new System.EventHandler(this.storeSettingsCheck_CheckedChanged);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsButton.Location = new System.Drawing.Point(9, 298);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(175, 29);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "SAVE";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // revertSettingsButton
            // 
            this.revertSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revertSettingsButton.Location = new System.Drawing.Point(190, 298);
            this.revertSettingsButton.Name = "revertSettingsButton";
            this.revertSettingsButton.Size = new System.Drawing.Size(121, 29);
            this.revertSettingsButton.TabIndex = 3;
            this.revertSettingsButton.Text = "Revert";
            this.revertSettingsButton.UseVisualStyleBackColor = true;
            this.revertSettingsButton.Click += new System.EventHandler(this.revertSettingsButton_Click);
            // 
            // PluginSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 363);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "PluginSettingsForm";
            this.Text = "PluginSettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PluginSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.PluginSettingsForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSettingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox pluginList;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.CheckBox autoStartCheck;
        private System.Windows.Forms.CheckBox storeSettingsCheck;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button revertSettingsButton;
    }
}