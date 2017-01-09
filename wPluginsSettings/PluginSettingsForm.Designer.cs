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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pluginList = new System.Windows.Forms.ListBox();
            this.commonSettingsGroup = new System.Windows.Forms.GroupBox();
            this.storeSettingsCheck = new System.Windows.Forms.CheckBox();
            this.autoStartCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.commonSettingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.label1);
            this.mainContainer.Panel1.Controls.Add(this.pluginList);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.commonSettingsGroup);
            this.mainContainer.Size = new System.Drawing.Size(404, 322);
            this.mainContainer.SplitterDistance = 139;
            this.mainContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a plugin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pluginList
            // 
            this.pluginList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginList.DisplayMember = "Key";
            this.pluginList.FormattingEnabled = true;
            this.pluginList.IntegralHeight = false;
            this.pluginList.Location = new System.Drawing.Point(3, 30);
            this.pluginList.Name = "pluginList";
            this.pluginList.Size = new System.Drawing.Size(133, 289);
            this.pluginList.TabIndex = 0;
            this.pluginList.ValueMember = "Value";
            this.pluginList.SelectedIndexChanged += new System.EventHandler(this.pluginList_SelectedIndexChanged);
            // 
            // commonSettingsGroup
            // 
            this.commonSettingsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commonSettingsGroup.Controls.Add(this.storeSettingsCheck);
            this.commonSettingsGroup.Controls.Add(this.autoStartCheck);
            this.commonSettingsGroup.Location = new System.Drawing.Point(3, 12);
            this.commonSettingsGroup.Name = "commonSettingsGroup";
            this.commonSettingsGroup.Size = new System.Drawing.Size(246, 46);
            this.commonSettingsGroup.TabIndex = 0;
            this.commonSettingsGroup.TabStop = false;
            this.commonSettingsGroup.Text = "Settings";
            // 
            // storeSettingsCheck
            // 
            this.storeSettingsCheck.AutoSize = true;
            this.storeSettingsCheck.Location = new System.Drawing.Point(108, 19);
            this.storeSettingsCheck.Name = "storeSettingsCheck";
            this.storeSettingsCheck.Size = new System.Drawing.Size(116, 17);
            this.storeSettingsCheck.TabIndex = 1;
            this.storeSettingsCheck.Text = "Store settings (TBI)";
            this.storeSettingsCheck.UseVisualStyleBackColor = true;
            // 
            // autoStartCheck
            // 
            this.autoStartCheck.AutoSize = true;
            this.autoStartCheck.Location = new System.Drawing.Point(6, 19);
            this.autoStartCheck.Name = "autoStartCheck";
            this.autoStartCheck.Size = new System.Drawing.Size(96, 17);
            this.autoStartCheck.TabIndex = 0;
            this.autoStartCheck.Text = "Start with PMX";
            this.autoStartCheck.UseVisualStyleBackColor = true;
            // 
            // PluginSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 322);
            this.Controls.Add(this.mainContainer);
            this.Name = "PluginSettingsForm";
            this.Text = "wPluginsSettings";
            this.Load += new System.EventHandler(this.PluginSettingsForm_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.commonSettingsGroup.ResumeLayout(false);
            this.commonSettingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ListBox pluginList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox commonSettingsGroup;
        private System.Windows.Forms.CheckBox autoStartCheck;
        private System.Windows.Forms.CheckBox storeSettingsCheck;
    }
}