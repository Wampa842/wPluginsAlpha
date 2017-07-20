using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.Pmx;

namespace wNameUtil
{
    public partial class NameUtilForm : Form
    {
        //Private members
        private IPERunArgs args;
        private string translationFilePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "dictionary.csv");


        private void PopulateListView(ListView listView)
        {
            IPXPmx scene = args.Host.Connector.Pmx.GetCurrentState();
            ListView.ListViewItemCollection list = listView.Items;

            List<int> selected = new List<int>();
            foreach(int item in listView.CheckedIndices)
            {
                selected.Add(item);
            }

            list.Clear();

            if(subjectBone.Checked)
            {
                foreach(IPXBone item in scene.Bone)
                {
                    ListViewItem newItem = new ListViewItem();
                    newItem.Text = item.Name;
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, item.NameE));
                    list.Add(newItem);
                }
            }
            else if (subjectMorph.Checked)
            {
                foreach (IPXMorph item in scene.Morph)
                {
                    ListViewItem newItem = new ListViewItem();
                    newItem.Text = item.Name;
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, item.NameE));
                    list.Add(newItem);
                }
            }
            else if (subjectGroup.Checked)
            {
                foreach (IPXNode item in scene.Node)
                {
                    ListViewItem newItem = new ListViewItem();
                    newItem.Text = item.Name;
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, item.NameE));
                    list.Add(newItem);
                }
            }
            else if (subjectBody.Checked)
            {
                foreach (IPXBody item in scene.Body)
                {
                    ListViewItem newItem = new ListViewItem();
                    newItem.Text = item.Name;
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, item.NameE));
                    list.Add(newItem);
                }
            }
            else if (subjectJoint.Checked)
            {
                foreach (IPXJoint item in scene.Joint)
                {
                    ListViewItem newItem = new ListViewItem();
                    newItem.Text = item.Name;
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, item.NameE));
                    list.Add(newItem);
                }
            }
            else
            {
                foreach (IPXMaterial item in scene.Material)
                {
                    ListViewItem newItem = new ListViewItem();
                    newItem.Text = item.Name;
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, item.NameE));
                    list.Add(newItem);
                }
            }

            foreach(int item in selected)
            {
                if(item < listView.Items.Count)
                    listView.Items[item].Checked = true;
            }
        }

        private void TranslatePmx(IPXPmx scene)
        {
            Translator.ReadDictionary(translationFilePath);
            byte nameMode = byte.Parse((string)modeBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag);
            if (subjectBone.Checked)
            {
                int i = 0;
                foreach (IPXBone item in scene.Bone)
                {
                    if (selectList.Items[i].Checked || !affectSelected.Checked)
                    {
                        switch (nameMode)
                        {
                            case 1:
                                {
                                    if(string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                        item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 2:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                        item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 3:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.JpToEn(item.Name);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.NameE = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.EnToJp(item.NameE);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.Name = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    i++;
                }
            }
            else if (subjectMorph.Checked)
            {
                int i = 0;
                foreach (IPXMorph item in scene.Morph)
                {
                    if (selectList.Items[i].Checked || !affectSelected.Checked)
                    {
                        switch (nameMode)
                        {
                            case 1:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                        item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 2:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                        item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 3:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.JpToEn(item.Name);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.NameE = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.EnToJp(item.NameE);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.Name = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    i++;
                }
            }
            else if (subjectGroup.Checked)
            {
                int i = 0;
                foreach (IPXNode item in scene.Node)
                {
                    if (selectList.Items[i].Checked || !affectSelected.Checked)
                    {
                        switch (nameMode)
                        {
                            case 1:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                        item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 2:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                        item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 3:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.JpToEn(item.Name);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.NameE = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.EnToJp(item.NameE);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.Name = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    i++;
                }
            }
            else if (subjectBody.Checked)
            {
                int i = 0;
                foreach (IPXBody item in scene.Body)
                {
                    if (selectList.Items[i].Checked || !affectSelected.Checked)
                    {
                        switch (nameMode)
                        {
                            case 1:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                        item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 2:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                        item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 3:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.JpToEn(item.Name);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.NameE = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.EnToJp(item.NameE);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.Name = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    i++;
                }
            }
            else if (subjectJoint.Checked)
            {
                int i = 0;
                foreach (IPXJoint item in scene.Joint)
                {
                    if (selectList.Items[i].Checked || !affectSelected.Checked)
                    {
                        switch (nameMode)
                        {
                            case 1:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                        item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 2:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                        item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 3:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.JpToEn(item.Name);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.NameE = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.EnToJp(item.NameE);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.Name = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    i++;
                }
            }
            else
            {
                int i = 0;
                foreach (IPXMaterial item in scene.Material)
                {
                    if (selectList.Items[i].Checked || !affectSelected.Checked)
                    {
                        switch (nameMode)
                        {
                            case 1:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                        item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 2:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                        item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                    break;
                                }
                            case 3:
                                {
                                    if (string.IsNullOrWhiteSpace(item.NameE) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.JpToEn(item.Name);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.NameE = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.NameE = Translator.Capitalize(item.Name, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (string.IsNullOrWhiteSpace(item.Name) || !keepExisting.Checked)
                                    {
                                        string translated = Translator.EnToJp(item.NameE);
                                        if (!string.IsNullOrWhiteSpace(translated))
                                        {
                                            item.Name = Translator.Capitalize(translated, capitalizeSelect.SelectedIndex);
                                        }
                                        else if (modeCopyUnknown.Checked)
                                        {
                                            item.Name = Translator.Capitalize(item.NameE, capitalizeSelect.SelectedIndex);
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                    i++;
                }
            }
        }

        //Event handlers
        #region EVENT_HANDLERS

        public NameUtilForm(IPERunArgs runArgs)
        {
            args = runArgs;
            Prefs.ReadPrefs();
            InitializeComponent();
        }

        private void SelectSubjects_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
                PopulateListView(selectList);
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in selectList.Items)
            {
                item.Checked = true;
            }
        }

        private void selectNone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in selectList.Items)
            {
                item.Checked = false;
            }
        }

        private void selectInvert_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in selectList.Items)
            {
                item.Checked = !item.Checked;
            }
        }

        private void selectRegex_Click(object sender, EventArgs e)
        {
            SelectByRegexForm regexSelect = new SelectByRegexForm();
            if(regexSelect.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem item in selectList.Items)
                {
                    if (regexSelect.MatchBy.MatchEnglish)
                    {
                        item.Checked = regexSelect.MatchBy.Match(item.SubItems[1].Text);
                    }
                    else
                    {
                        item.Checked = regexSelect.MatchBy.Match(item.Text);
                    }
                }
            }
        }

        private void affectSelected_CheckedChanged(object sender, EventArgs e)
        {
            selectList.Enabled = affectSelected.Checked;
        }

        private void NameUtilForm_Load(object sender, EventArgs e)
        {
            PopulateListView(selectList);
            capitalizeSelect.SelectedIndex = 0;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            IPXPmx scene = args.Host.Connector.Pmx.GetCurrentState();

            TranslatePmx(scene);

            args.Host.Connector.Pmx.Update(scene);
            PopulateListView(selectList);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            PopulateListView(selectList);
        }

        private void updateFileButton_Click(object sender, EventArgs e)
        {
            Translator.UpdateDictionary(translationFilePath);
        }

        private void openSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
        #endregion
    }
}
