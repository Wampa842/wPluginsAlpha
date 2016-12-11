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
            int AffectedVerts = 0;

            //IPEExpression PMorph = (IPEExpression)morph;

            //Dictionary<long, long> VertIndices = new Dictionary<long, long>();
            List<int[]> VertIndices = new List<int[]>();

            for(int i = 0; i < scene.Vertex.Count; ++i)
            {
                for(int j = 0; j < morph.Offsets.Count; ++j)
                {
                    if (((IPXVertexMorphOffset)morph.Offsets[j]).Vertex.Equals(scene.Vertex[i]))
                    {
                        //VertIndices.Add(new int[] { i, j });
                        if(negative) scene.Vertex[i].Position -= ((IPXVertexMorphOffset)morph.Offsets[j]).Offset;
                        else scene.Vertex[i].Position += ((IPXVertexMorphOffset)morph.Offsets[j]).Offset;
                        ++AffectedVerts;
                    }
                }
            }
            MessageBox.Show("Applied the " + ((negative) ? ("negative of the") : ("")) + " vertex morph " + morph.Name + " (" + morph.NameE + ")\nAffected vertices: " + AffectedVerts);
            //if (AffectedVerts > 0) UpdatePmx(scene);
            return AffectedVerts;
        }

        private void EnableControls(bool enable)
        {
            applyButton.Enabled = enable;
            applyNegativeButton.Enabled = enable;
        }

        private List<int> PopulateList(MorphKind type)
        {
            GlobalScene = args.Host.Connector.Pmx.GetCurrentState();
            morphList.Items.Clear();
            morphList.SelectedItems.Clear();
            List<IPXMorph> Morphs = (List<IPXMorph>)GlobalScene.Morph;
            if(Morphs.Count <= 0)
            {
                return new List<int>();
            }
            List<int> OutList = new List<int>();
            for(int i = 0; i < Morphs.Count; ++i)
            {
                if(Morphs[i].Kind == type)
                {
                    Indices.Add(i);
                    morphList.Items.Add(new ListViewItem(new string[] { Morphs[i].Name, Morphs[i].NameE}));
                }
            }

            //MessageBox.Show(morphList.SelectedIndices[0].ToString());
            return OutList;
        }

        private int AppliedCount = 0;
        private void applyButton_Click(object sender, EventArgs e)
        {
            AppliedCount++;
            appliedCountLabel.Text = Math.Abs(AppliedCount).ToString();
            if(AppliedCount == 0)
            {
                appliedCountLabel.ForeColor = Control.DefaultForeColor;
            }
            else
            {
                appliedCountLabel.ForeColor = Color.Red;
            }
            IPXPmx PMX = args.Host.Connector.Pmx.GetCurrentState();
            ApplyVertexMorph(PMX.Morph[Indices[morphList.SelectedIndices[0]]], PMX, false);
            UpdatePmx(PMX);
        }

        private void applyNegativeButton_Click(object sender, EventArgs e)
        {
            AppliedCount--;
            appliedCountLabel.Text = Math.Abs(AppliedCount).ToString();
            if (AppliedCount == 0)
            {
                appliedCountLabel.ForeColor = Control.DefaultForeColor;
            }
            else
            {
                appliedCountLabel.ForeColor = Color.Red;
            }
            IPXPmx PMX = args.Host.Connector.Pmx.GetCurrentState();
            ApplyVertexMorph(PMX.Morph[Indices[morphList.SelectedIndices[0]]], PMX, true);
            UpdatePmx(PMX);
        }

        private void ApplyMorphForm_Load(object sender, EventArgs e)
        {
            EnableControls(false);
            SelectedType = MorphKind.Vertex;
            //PopulateList(SelectedType);
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            PopulateList(SelectedType);
            EnableControls(true);
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

        private void morphList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNameLabel.Text = (morphList.SelectedItems.Count <= 0) ? ("<none selected>") : (GlobalScene.Morph[Indices[morphList.SelectedIndices[0]]].Name);
            EnableControls(morphList.SelectedItems.Count > 0);
        }
    }
}
