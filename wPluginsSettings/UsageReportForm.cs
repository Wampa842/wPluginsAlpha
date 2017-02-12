using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace wPluginsSettings
{
    public partial class UsageReportForm : Form
    {
        public UsageReportForm()
        {
            InitializeComponent();
            /*
            pmxExperience.Items.Add(new KeyValuePair<string, int>("Beginner", 0));
            pmxExperience.Items.Add(new KeyValuePair<string, int>("Amateur", 1));
            pmxExperience.Items.Add(new KeyValuePair<string, int>("Expert", 2));
            pmxExperience.Items.Add(new KeyValuePair<string, int>("Professional", 3));
            generalExperience.Items.Add(new KeyValuePair<string, int>("Beginner", 0));
            generalExperience.Items.Add(new KeyValuePair<string, int>("Amateur", 1));
            generalExperience.Items.Add(new KeyValuePair<string, int>("Expert", 2));
            generalExperience.Items.Add(new KeyValuePair<string, int>("Professional", 3));
            pmxExperience.DisplayMember = "Key";
            //pmxExperience.ValueMember = "Value";*/
            pmxExperience.SelectedIndex = 0;
            //generalExperience.DisplayMember = "Key";
            //generalExperience.ValueMember = "Value";
            generalExperience.SelectedIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch(versionText.Text, @"\d\d\d\d"))
            {
                MessageBox.Show("The version number is in the wrong format - it should be something like 0.1.2.3");
                return;
            }
            //Compose the strings to be sent in the POST
            //I love networks

            //Version:
            string PostString = "ver=" + versionText.Text;

            //English/legacy
            PostString += "&el=" + (englishTranslationCheck.Checked ? "1" : "0") + (legacyCheck.Checked ? "1" : "0");

            //Experience:
            try { PostString += "&exp=" + pmxExperience.SelectedIndex.ToString() + generalExperience.SelectedIndex.ToString(); } catch(Exception ex) { MessageBox.Show(ex.Message); }

            byte[] PostData = Encoding.ASCII.GetBytes(PostString);

            //MessageBox.Show(PostString);

            //Compose POST request

            HttpWebRequest post = (HttpWebRequest)WebRequest.Create("http://users.atw.hu/wampa842/wplugins/counter.php");
            post.Method = "POST";
            post.ContentType = "application/x-www-form-urlencoded";
            post.ContentLength = PostData.Length;

            using (System.IO.Stream PostStream = post.GetRequestStream())
            {
                PostStream.Write(PostData, 0, PostData.Length);
            }
            Close();
        }
    }
}
