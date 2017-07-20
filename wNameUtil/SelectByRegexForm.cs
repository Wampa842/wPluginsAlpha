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
    public partial class SelectByRegexForm : Form
    {
        public Matcher MatchBy { get; set; }
        public SelectByRegexForm()
        {
            InitializeComponent();
        }

        private void matchButton_Click(object sender, EventArgs e)
        {
            string matchString = matchText.Text;
            MatchBy = new Matcher(matchString, matchRegex.Checked, matchEnglish.Checked);
            DialogResult = DialogResult.OK;

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
