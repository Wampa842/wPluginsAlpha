namespace wBackup
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.namingGroupBox = new System.Windows.Forms.GroupBox();
            this.autoBackupGroupBox = new System.Windows.Forms.GroupBox();
            this.limitGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.resetLocationCheck = new System.Windows.Forms.CheckBox();
            this.backupName0 = new System.Windows.Forms.RadioButton();
            this.backupName1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.autoBackupCheck = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.manualBackupButton = new System.Windows.Forms.Button();
            this.restoreLastButton = new System.Windows.Forms.Button();
            this.countLimitCheck = new System.Windows.Forms.CheckBox();
            this.countLimitNumber = new System.Windows.Forms.NumericUpDown();
            this.sizeLimitNumber = new System.Windows.Forms.NumericUpDown();
            this.sizeLimitCheck = new System.Windows.Forms.CheckBox();
            this.ageLimitDayNumber = new System.Windows.Forms.NumericUpDown();
            this.ageLimitCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.statusBar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            this.namingGroupBox.SuspendLayout();
            this.autoBackupGroupBox.SuspendLayout();
            this.limitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLimitNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeLimitNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitDayNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel,
            this.toolStripStatusLabel1,
            this.statusProgressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 415);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(334, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(39, 17);
            this.statusStripLabel.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(178, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(334, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exportSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.preferencesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportToolStripMenuItem.Text = "Import settings...";
            // 
            // exportSettingsToolStripMenuItem
            // 
            this.exportSettingsToolStripMenuItem.Name = "exportSettingsToolStripMenuItem";
            this.exportSettingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportSettingsToolStripMenuItem.Text = "Export settings...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.reportABugToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportABugToolStripMenuItem.Text = "Report a bug";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationGroupBox.Controls.Add(this.resetLocationCheck);
            this.locationGroupBox.Controls.Add(this.browseButton);
            this.locationGroupBox.Controls.Add(this.textBox1);
            this.locationGroupBox.Location = new System.Drawing.Point(12, 27);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(310, 68);
            this.locationGroupBox.TabIndex = 2;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Backup location";
            // 
            // namingGroupBox
            // 
            this.namingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namingGroupBox.Controls.Add(this.radioButton4);
            this.namingGroupBox.Controls.Add(this.radioButton3);
            this.namingGroupBox.Controls.Add(this.backupName1);
            this.namingGroupBox.Controls.Add(this.backupName0);
            this.namingGroupBox.Location = new System.Drawing.Point(12, 101);
            this.namingGroupBox.Name = "namingGroupBox";
            this.namingGroupBox.Size = new System.Drawing.Size(310, 90);
            this.namingGroupBox.TabIndex = 3;
            this.namingGroupBox.TabStop = false;
            this.namingGroupBox.Text = "Naming";
            // 
            // autoBackupGroupBox
            // 
            this.autoBackupGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoBackupGroupBox.Controls.Add(this.label1);
            this.autoBackupGroupBox.Controls.Add(this.numericUpDown1);
            this.autoBackupGroupBox.Controls.Add(this.autoBackupCheck);
            this.autoBackupGroupBox.Location = new System.Drawing.Point(12, 197);
            this.autoBackupGroupBox.Name = "autoBackupGroupBox";
            this.autoBackupGroupBox.Size = new System.Drawing.Size(310, 49);
            this.autoBackupGroupBox.TabIndex = 4;
            this.autoBackupGroupBox.TabStop = false;
            this.autoBackupGroupBox.Text = "Automatic backup";
            // 
            // limitGroupBox
            // 
            this.limitGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limitGroupBox.Controls.Add(this.label5);
            this.limitGroupBox.Controls.Add(this.numericUpDown3);
            this.limitGroupBox.Controls.Add(this.label4);
            this.limitGroupBox.Controls.Add(this.numericUpDown2);
            this.limitGroupBox.Controls.Add(this.label3);
            this.limitGroupBox.Controls.Add(this.label2);
            this.limitGroupBox.Controls.Add(this.ageLimitDayNumber);
            this.limitGroupBox.Controls.Add(this.ageLimitCheck);
            this.limitGroupBox.Controls.Add(this.sizeLimitNumber);
            this.limitGroupBox.Controls.Add(this.sizeLimitCheck);
            this.limitGroupBox.Controls.Add(this.countLimitNumber);
            this.limitGroupBox.Controls.Add(this.countLimitCheck);
            this.limitGroupBox.Location = new System.Drawing.Point(12, 252);
            this.limitGroupBox.Name = "limitGroupBox";
            this.limitGroupBox.Size = new System.Drawing.Size(310, 95);
            this.limitGroupBox.TabIndex = 5;
            this.limitGroupBox.TabStop = false;
            this.limitGroupBox.Text = "Limits";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(229, 17);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // resetLocationCheck
            // 
            this.resetLocationCheck.AutoSize = true;
            this.resetLocationCheck.Location = new System.Drawing.Point(6, 45);
            this.resetLocationCheck.Name = "resetLocationCheck";
            this.resetLocationCheck.Size = new System.Drawing.Size(278, 17);
            this.resetLocationCheck.TabIndex = 2;
            this.resetLocationCheck.Text = "Reset location to default when a new model is loaded";
            this.resetLocationCheck.UseVisualStyleBackColor = true;
            // 
            // backupName0
            // 
            this.backupName0.AutoSize = true;
            this.backupName0.Location = new System.Drawing.Point(6, 19);
            this.backupName0.Name = "backupName0";
            this.backupName0.Size = new System.Drawing.Size(62, 17);
            this.backupName0.TabIndex = 0;
            this.backupName0.TabStop = true;
            this.backupName0.Text = "Number";
            this.backupName0.UseVisualStyleBackColor = true;
            // 
            // backupName1
            // 
            this.backupName1.AutoSize = true;
            this.backupName1.Location = new System.Drawing.Point(6, 42);
            this.backupName1.Name = "backupName1";
            this.backupName1.Size = new System.Drawing.Size(91, 17);
            this.backupName1.TabIndex = 1;
            this.backupName1.TabStop = true;
            this.backupName1.Text = "Date and time";
            this.backupName1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(133, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Time only";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(177, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Single copy (append _BACKUP)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // autoBackupCheck
            // 
            this.autoBackupCheck.AutoSize = true;
            this.autoBackupCheck.Location = new System.Drawing.Point(6, 19);
            this.autoBackupCheck.Name = "autoBackupCheck";
            this.autoBackupCheck.Size = new System.Drawing.Size(170, 17);
            this.autoBackupCheck.TabIndex = 0;
            this.autoBackupCheck.Text = "Make automatic backup every";
            this.autoBackupCheck.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(182, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "minutes";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(216, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lists ->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(216, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Open floater";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // manualBackupButton
            // 
            this.manualBackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manualBackupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.manualBackupButton.Location = new System.Drawing.Point(12, 361);
            this.manualBackupButton.Name = "manualBackupButton";
            this.manualBackupButton.Size = new System.Drawing.Size(121, 51);
            this.manualBackupButton.TabIndex = 8;
            this.manualBackupButton.Text = "Backup now";
            this.manualBackupButton.UseVisualStyleBackColor = true;
            // 
            // restoreLastButton
            // 
            this.restoreLastButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreLastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restoreLastButton.Location = new System.Drawing.Point(139, 361);
            this.restoreLastButton.Name = "restoreLastButton";
            this.restoreLastButton.Size = new System.Drawing.Size(71, 51);
            this.restoreLastButton.TabIndex = 9;
            this.restoreLastButton.Text = "Restore last";
            this.restoreLastButton.UseVisualStyleBackColor = true;
            // 
            // countLimitCheck
            // 
            this.countLimitCheck.AutoSize = true;
            this.countLimitCheck.Location = new System.Drawing.Point(6, 19);
            this.countLimitCheck.Name = "countLimitCheck";
            this.countLimitCheck.Size = new System.Drawing.Size(54, 17);
            this.countLimitCheck.TabIndex = 0;
            this.countLimitCheck.Text = "Count";
            this.countLimitCheck.UseVisualStyleBackColor = true;
            // 
            // countLimitNumber
            // 
            this.countLimitNumber.DecimalPlaces = 1;
            this.countLimitNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.countLimitNumber.Location = new System.Drawing.Point(92, 18);
            this.countLimitNumber.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.countLimitNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.countLimitNumber.Name = "countLimitNumber";
            this.countLimitNumber.Size = new System.Drawing.Size(60, 20);
            this.countLimitNumber.TabIndex = 2;
            this.countLimitNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.countLimitNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sizeLimitNumber
            // 
            this.sizeLimitNumber.Increment = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.sizeLimitNumber.Location = new System.Drawing.Point(92, 41);
            this.sizeLimitNumber.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.sizeLimitNumber.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.sizeLimitNumber.Name = "sizeLimitNumber";
            this.sizeLimitNumber.Size = new System.Drawing.Size(60, 20);
            this.sizeLimitNumber.TabIndex = 4;
            this.sizeLimitNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeLimitNumber.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // sizeLimitCheck
            // 
            this.sizeLimitCheck.AutoSize = true;
            this.sizeLimitCheck.Location = new System.Drawing.Point(6, 42);
            this.sizeLimitCheck.Name = "sizeLimitCheck";
            this.sizeLimitCheck.Size = new System.Drawing.Size(80, 17);
            this.sizeLimitCheck.TabIndex = 3;
            this.sizeLimitCheck.Text = "Overall size";
            this.sizeLimitCheck.UseVisualStyleBackColor = true;
            // 
            // ageLimitDayNumber
            // 
            this.ageLimitDayNumber.Location = new System.Drawing.Point(92, 64);
            this.ageLimitDayNumber.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.ageLimitDayNumber.Name = "ageLimitDayNumber";
            this.ageLimitDayNumber.Size = new System.Drawing.Size(48, 20);
            this.ageLimitDayNumber.TabIndex = 6;
            this.ageLimitDayNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ageLimitDayNumber.Value = new decimal(new int[] {
            365,
            0,
            0,
            0});
            // 
            // ageLimitCheck
            // 
            this.ageLimitCheck.AutoSize = true;
            this.ageLimitCheck.Location = new System.Drawing.Point(6, 65);
            this.ageLimitCheck.Name = "ageLimitCheck";
            this.ageLimitCheck.Size = new System.Drawing.Size(45, 17);
            this.ageLimitCheck.TabIndex = 5;
            this.ageLimitCheck.Text = "Age";
            this.ageLimitCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "h";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(165, 64);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "m";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(225, 64);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown3.TabIndex = 11;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 437);
            this.Controls.Add(this.restoreLastButton);
            this.Controls.Add(this.manualBackupButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.limitGroupBox);
            this.Controls.Add(this.autoBackupGroupBox);
            this.Controls.Add(this.namingGroupBox);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "BackupForm";
            this.Text = "wBackup";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            this.namingGroupBox.ResumeLayout(false);
            this.namingGroupBox.PerformLayout();
            this.autoBackupGroupBox.ResumeLayout(false);
            this.autoBackupGroupBox.PerformLayout();
            this.limitGroupBox.ResumeLayout(false);
            this.limitGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLimitNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeLimitNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitDayNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.GroupBox namingGroupBox;
        private System.Windows.Forms.GroupBox autoBackupGroupBox;
        private System.Windows.Forms.GroupBox limitGroupBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox resetLocationCheck;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton backupName1;
        private System.Windows.Forms.RadioButton backupName0;
        private System.Windows.Forms.CheckBox autoBackupCheck;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button manualBackupButton;
        private System.Windows.Forms.Button restoreLastButton;
        private System.Windows.Forms.CheckBox countLimitCheck;
        private System.Windows.Forms.NumericUpDown ageLimitDayNumber;
        private System.Windows.Forms.CheckBox ageLimitCheck;
        private System.Windows.Forms.NumericUpDown sizeLimitNumber;
        private System.Windows.Forms.CheckBox sizeLimitCheck;
        private System.Windows.Forms.NumericUpDown countLimitNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}