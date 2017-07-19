﻿using System;
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
            MessageBox.Show("");
            IPXPmx scene = args.Host.Connector.Pmx.GetCurrentState();
            ListView.ListViewItemCollection list = listView.Items;

            List<int> selected = new List<int>();
            foreach(int item in listView.CheckedIndices)
            {
                selected.Add(item);
            }

            MessageBox.Show(listView.CheckedIndices.Count.ToString() + " " + selected.Count.ToString());

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
            Translator.ReadTranslationFile(translationFilePath);
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
                                    item.NameE = item.Name;
                                    break;
                                }
                            case 2:
                                {
                                    item.Name = item.NameE;
                                    break;
                                }
                            case 3:
                                {
                                    string translated = Translator.JpToEn(item.Name);
                                    if (!string.IsNullOrWhiteSpace(translated))
                                    {
                                        item.NameE = translated;
                                    }
                                    else if (modeCopyUnknown.Checked)
                                    {
                                        item.NameE = item.Name;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    string translated = Translator.EnToJp(item.NameE);
                                    if (!string.IsNullOrWhiteSpace(translated))
                                    {
                                        item.Name = translated;
                                    }
                                    else if (modeCopyUnknown.Checked)
                                    {
                                        item.Name = item.NameE;
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
                foreach (IPXMorph item in scene.Morph)
                {
                    
                }
            }
            else if (subjectGroup.Checked)
            {
                foreach (IPXNode item in scene.Node)
                {
                }
            }
            else if (subjectBody.Checked)
            {
                foreach (IPXBody item in scene.Body)
                {
                }
            }
            else if (subjectJoint.Checked)
            {
                foreach (IPXJoint item in scene.Joint)
                {
                }
            }
            else
            {
                foreach (IPXMaterial item in scene.Material)
                {
                }
            }
        }

        //Event handlers

        public NameUtilForm(IPERunArgs runArgs)
        {
            args = runArgs;
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
    }
}
