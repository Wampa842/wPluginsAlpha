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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "foo",
            "bar",
            "yes/no"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginSettingsForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendStatisticsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pluginList = new System.Windows.Forms.ListBox();
            this.revertSettingsButton = new System.Windows.Forms.Button();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.optionList = new System.Windows.Forms.ListView();
            this.optionNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.mainMenuStrip.Size = new System.Drawing.Size(589, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSettingsToolStripMenuItem,
            this.importSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendStatisticsReportToolStripMenuItem,
            this.bugReportMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportSettingsToolStripMenuItem
            // 
            this.exportSettingsToolStripMenuItem.Name = "exportSettingsToolStripMenuItem";
            this.exportSettingsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportSettingsToolStripMenuItem.Text = "Export settings";
            // 
            // importSettingsToolStripMenuItem
            // 
            this.importSettingsToolStripMenuItem.Name = "importSettingsToolStripMenuItem";
            this.importSettingsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.importSettingsToolStripMenuItem.Text = "Import settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // sendStatisticsReportToolStripMenuItem
            // 
            this.sendStatisticsReportToolStripMenuItem.Name = "sendStatisticsReportToolStripMenuItem";
            this.sendStatisticsReportToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sendStatisticsReportToolStripMenuItem.Text = "Send statistics report";
            this.sendStatisticsReportToolStripMenuItem.Click += new System.EventHandler(this.sendStatisticsReportToolStripMenuItem_Click);
            // 
            // bugReportMenuItem
            // 
            this.bugReportMenuItem.Name = "bugReportMenuItem";
            this.bugReportMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bugReportMenuItem.Text = "Report a bug";
            this.bugReportMenuItem.Click += new System.EventHandler(this.bugReportMenuItem_Click);
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
            this.mainContainer.Size = new System.Drawing.Size(589, 339);
            this.mainContainer.SplitterDistance = 161;
            this.mainContainer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
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
            this.pluginList.Size = new System.Drawing.Size(155, 306);
            this.pluginList.TabIndex = 0;
            this.pluginList.SelectedIndexChanged += new System.EventHandler(this.pluginList_SelectedIndexChanged);
            // 
            // revertSettingsButton
            // 
            this.revertSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.revertSettingsButton.Location = new System.Drawing.Point(335, 298);
            this.revertSettingsButton.Name = "revertSettingsButton";
            this.revertSettingsButton.Size = new System.Drawing.Size(77, 29);
            this.revertSettingsButton.TabIndex = 3;
            this.revertSettingsButton.Text = "Revert";
            this.revertSettingsButton.UseVisualStyleBackColor = true;
            this.revertSettingsButton.Click += new System.EventHandler(this.revertSettingsButton_Click);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsButton.Location = new System.Drawing.Point(218, 298);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(111, 29);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "SAVE";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.Controls.Add(this.optionList);
            this.settingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(418, 289);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings (double click to edit)";
            // 
            // optionList
            // 
            this.optionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.optionNameColumn,
            this.optionValueColumn,
            this.optionTypeColumn});
            this.optionList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.optionList.Location = new System.Drawing.Point(6, 19);
            this.optionList.Name = "optionList";
            this.optionList.Size = new System.Drawing.Size(403, 264);
            this.optionList.TabIndex = 4;
            this.optionList.UseCompatibleStateImageBehavior = false;
            this.optionList.View = System.Windows.Forms.View.Details;
            this.optionList.DoubleClick += new System.EventHandler(this.optionList_DoubleClick);
            // 
            // optionNameColumn
            // 
            this.optionNameColumn.Text = "Name";
            this.optionNameColumn.Width = 190;
            // 
            // optionValueColumn
            // 
            this.optionValueColumn.Text = "Value";
            this.optionValueColumn.Width = 96;
            // 
            // optionTypeColumn
            // 
            this.optionTypeColumn.Text = "Type";
            this.optionTypeColumn.Width = 73;
            // 
            // PluginSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 363);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button revertSettingsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendStatisticsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugReportMenuItem;
        private System.Windows.Forms.ListView optionList;
        private System.Windows.Forms.ColumnHeader optionNameColumn;
        private System.Windows.Forms.ColumnHeader optionValueColumn;
        private System.Windows.Forms.ColumnHeader optionTypeColumn;
    }
}