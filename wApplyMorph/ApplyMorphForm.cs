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
using PEPlugin.Pmd;
using PEPlugin.Form;
using PEPlugin.SDX;

namespace wApplyMorph
{
    public partial class ApplyMorphForm : Form
    {
        //GLOBAL
        IPERunArgs args;
        MorphKind SelectedType;
        List<int> Indices = new List<int>();
        IPXPmx GlobalScene;

        public ApplyMorphForm(IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
        }
        
        private void UpdatePmx(IPXPmx scene)
        {
            args.Host.Connector.Pmx.Update(scene);
            args.Host.Connector.View.PMDView.UpdateModel();
            args.Host.Connector.View.PMDView.UpdateView();
        }

        private int ApplyVertexMorph(IPXMorph morph, IPXPmx scene, bool negative)
        {
            int TotalVertexCount = scene.Vertex.Count;
            int AffectedVerts = 0;
            PleaseWaitForm progress = new PleaseWaitForm();
            progress.UpdateProgress(0, 0, TotalVertexCount);
            progress.Show();

            for(int i = 0; i < scene.Vertex.Count; ++i)
            {
                for(int j = 0; j < morph.Offsets.Count; ++j)
                {
                    if (((IPXVertexMorphOffset)morph.Offsets[j]).Vertex.Equals(scene.Vertex[i]))
                    {
                        if(negative) scene.Vertex[i].Position -= (((IPXVertexMorphOffset)morph.Offsets[j]).Offset * (float)scaleNumber.Value);
                        else scene.Vertex[i].Position += (((IPXVertexMorphOffset)morph.Offsets[j]).Offset * (float)scaleNumber.Value);
                        ++AffectedVerts;
                    }
                }
                progress.UpdateProgress(i, 0, TotalVertexCount);
            }
            progress.Close();
            MessageBox.Show("Applied the " + ((negative) ? ("negative of the") : ("")) + " vertex morph " + morph.Name + " (" + morph.NameE + ")\nAffected vertices: " + AffectedVerts);
            //if (AffectedVerts > 0) UpdatePmx(scene);
            return AffectedVerts;
        }

        private void EnableControls(bool enable)
        {
            applyButton.Enabled = enable;
            applyNegativeButton.Enabled = enable;
            reverseMorphNameJText.Enabled = enable;
        }

        private void PopulateList(MorphKind type)
        {
            GlobalScene = args.Host.Connector.Pmx.GetCurrentState();
            morphList.Items.Clear();
            morphList.SelectedItems.Clear();
            List<IPXMorph> Morphs = (List<IPXMorph>)GlobalScene.Morph;
            if(Morphs.Count <= 0)
            {
                return;
            }
            List<int> OutList = new List<int>();
            for(int i = 0; i < Morphs.Count; ++i)
            {
                if(Morphs[i].Kind == type)
                {
                    string Category;
                    switch (Morphs[i].Panel)
                    {
                        case 1:
                            {
                                Category = "B";
                                break;
                            }
                        case 2:
                            {
                                Category = "E";
                                break;
                            }
                        case 3:
                            {
                                Category = "M";
                                break;
                            }
                        case 4:
                            {
                                Category = "O";
                                break;
                            }
                        default:
                            {
                                Category = "X";
                                break;
                            }
                    }

                    Indices.Add(i);
                    morphList.Items.Add(new ListViewItem(new string[] { Category, Morphs[i].Name, Morphs[i].NameE}));
                }
            }
        }
        
        private void applyButton_Click(object sender, EventArgs e)
        {
            IPXPmx PMX = args.Host.Connector.Pmx.GetCurrentState();
            ApplyVertexMorph(PMX.Morph[Indices[morphList.SelectedIndices[0]]], PMX, false);
            UpdatePmx(PMX);
        }

        private void applyNegativeButton_Click(object sender, EventArgs e)
        {
            IPXPmx PMX = args.Host.Connector.Pmx.GetCurrentState();
            ApplyVertexMorph(PMX.Morph[Indices[morphList.SelectedIndices[0]]], PMX, true);
            UpdatePmx(PMX);
        }

        private void ApplyMorphForm_Load(object sender, EventArgs e)
        {
            EnableControls(false);
            SelectedType = MorphKind.Vertex;
            //PopulateList(SelectedType);
            reverseMorphDrop.SelectedIndex = 0;
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            PopulateList(SelectedType);
            EnableControls(morphList.SelectedIndices.Count > 0);
        }

        private void typeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (vertexRadio.Checked)
            {
                SelectedType = MorphKind.Vertex;
            }
            else if (boneRadio.Checked)
            {
                SelectedType = MorphKind.Bone;
            }
            else { MessageBox.Show(""); }
            PopulateList(SelectedType);
        }

        private void morphList_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedNameLabel.Text = (morphList.SelectedItems.Count <= 0) ? ("<none selected>") : (GlobalScene.Morph[Indices[morphList.SelectedIndices[0]]].Name + "\n" + GlobalScene.Morph[Indices[morphList.SelectedIndices[0]]].NameE);
            affectedVertsLabel.Text = (morphList.SelectedItems.Count <= 0) ? ("<none selected>") : (GlobalScene.Morph[Indices[morphList.SelectedIndices[0]]].Offsets.Count + " vertices");
            EnableControls(morphList.SelectedItems.Count > 0);
            reverseMorphNameJText.Text = args.Host.Connector.Pmx.GetCurrentState().Morph[Indices[morphList.SelectedIndices[0]]].Name;
            reverseMorphNameEText.Text = args.Host.Connector.Pmx.GetCurrentState().Morph[Indices[morphList.SelectedIndices[0]]].NameE;
        }

        //private void morphList_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    }
}
