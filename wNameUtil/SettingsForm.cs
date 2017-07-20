using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wNameUtil
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            updateUrlText.Text = Prefs.UpdateUri.AbsoluteUri;
            autoStartCheck.Checked = Prefs.AutoStart;
            autoUpdateCheck.Checked = Prefs.AutoUpdate;
            customDictionary.Text = Prefs.CustomDictionaryPath;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (Uri.IsWellFormedUriString(updateUrlText.Text, UriKind.Absolute))
            {
                Prefs.UpdateUri = new Uri(Uri.EscapeUriString(updateUrlText.Text));
            }
            else
            {
                MessageBox.Show("The update URL is the wrong format.");
                error = true;
            }
            Prefs.CustomDictionaryPath = customDictionary.Text;
            Prefs.AutoStart = autoStartCheck.Checked;
            Prefs.AutoUpdate = autoUpdateCheck.Checked;
            Prefs.WritePrefs();
            if(!error)
                this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
