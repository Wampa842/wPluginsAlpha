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
using PEPlugin.Form;


namespace wMorphScale
{
    public partial class MainForm : Form
    {
        IPERunArgs args;
        public MainForm(IPERunArgs p_args)
        {
            //Initialize, and pass run arguments
            args = p_args;
            InitializeComponent();
        }
        
        MorphKind SelectedType = MorphKind.Vertex;
        bool BoneRotation = false;  //If true, then the bone morph's rotation values will be scaled instead of translation.

        public void PopulateList(MorphKind type)
        {
            IList<IPXMorph> AllMorphs;   //All morphs in the model
            morphList.Items.Clear();    //Clear the list on the form. Otherwise it would add new elements to the list every time it is populated.
            AllMorphs = args.Host.Connector.Pmx.GetCurrentState().Morph;    //Get all morphs from the model.
            //The list is only to populate the ListView. It's otherwise not used. All interactions with the scene are done within a different method, called on the click of a button.
            if(AllMorphs.Count <= 0)    //Make sure the plugin isn't running for no reason. Might prevent some unwanted things. Might introduce bugs.
            {
                MessageBox.Show("The plugin detected that your model contains no vertex or bone morphs, and will now close.\n\nIf this is an error and your model does contain morphs, please see README.txt for contact info.", "Error");
                this.Close();
                this.Dispose();
            }
            for(int i = 0; i < AllMorphs.Count; ++i)
            {
                if(AllMorphs[i].Kind == type)
                {
                    morphList.Items.Add(new ListViewItem(new string[] { AllMorphs[i].Name, AllMorphs[i].NameE, i.ToString() }));
                }
            }
        }

        public IPXMorph ScaleMorph(IPXMorph morph, MorphKind type, bool rot, float xMult, float yMult, float zMult)
        {
            if (xMult == 1 && yMult == 1 && zMult == 1) return morph;   //Avoid the whole shebang if there's nothing to actually do
            IPXMorph WorkingCopy = morph; //Just to make sure we're working on a copy instead of the original.
            switch (type)   //This part might be simplified in the future if the whole switch statement is deemed to be unnecessary.
            {
                case MorphKind.Vertex:
                    {
                        for (int i = 0; i < WorkingCopy.Offsets.Count; ++i)
                        {
                            //Each morph vector is multiplied by a vector passed on call.
                            ((IPXVertexMorphOffset)WorkingCopy.Offsets[i]).Offset *= new PEPlugin.SDX.V3(xMult, yMult, zMult);
                        }
                    }
                    break;
                case MorphKind.Bone:
                    {
                        for (int i = 0; i < WorkingCopy.Offsets.Count; ++i)
                        {
                            //Since we're scaling, gimbal locking shouldn't be an issue.
                            if (rot) ((IPXBoneMorphOffset)WorkingCopy.Offsets[i]).Rotation *= new PEPlugin.SDX.Q(xMult, yMult, zMult);
                            else ((IPXBoneMorphOffset)WorkingCopy.Offsets[i]).Translation *= new PEPlugin.SDX.V3(xMult, yMult, zMult);
                        }
                        break;
                    }
            }
            return WorkingCopy;
        }

        public IPXMorph ScaleMorph(IPXMorph morph, MorphKind type, bool rot, float mult) //As above, except with a scalar.
        {
            if (mult == 1) return morph;
            IPXMorph WorkingCopy = morph;
            switch (type)
            {
                case MorphKind.Vertex:
                    {
                        for(int i = 0; i < WorkingCopy.Offsets.Count; ++i)
                        {
                            ((IPXVertexMorphOffset)WorkingCopy.Offsets[i]).Offset *= mult;
                        }
                    }
                    break;
                case MorphKind.Bone:
                    {
                        for(int i = 0; i < WorkingCopy.Offsets.Count; ++i)
                        {
                            if (rot) ((IPXBoneMorphOffset)WorkingCopy.Offsets[i]).Rotation *= mult;
                            else ((IPXBoneMorphOffset)WorkingCopy.Offsets[i]).Translation *= mult;
                        }
                        break;
                    }
            }
            return WorkingCopy;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Initialize the UI
            PopulateList(SelectedType);
            xMultiplier.Enabled = false;
            yMultiplier.Enabled = false;
            zMultiplier.Enabled = false;
            vertexChannelChoice.SelectedIndex = 0;
            vertexChannelChoice.Enabled = false;
        }

        private void morphTypeChanged(object sender, EventArgs e)
        {

            if (vertexTypeCheck.Checked)
            {
                SelectedType = MorphKind.Vertex;
                BoneRotation = false;
            }
            if (boneTypeCheck.Checked)
            {
                SelectedType = MorphKind.Bone;
                BoneRotation = false;
            }
            if (boneRotTypeCheck.Checked)
            {
                SelectedType = MorphKind.Bone;
                BoneRotation = true;
            }
            PopulateList(SelectedType);
        }

        private void uniformityCheckedChanged(object sender, EventArgs e)
        {
            if (scalarScaleCheck.Checked)
            {
                uniformMultiplier.Enabled = true;
                xMultiplier.Enabled = false;
                yMultiplier.Enabled = false;
                zMultiplier.Enabled = false;
            }
            if (vectorScaleCheck.Checked)
            {
                uniformMultiplier.Enabled = false;
                xMultiplier.Enabled = true;
                yMultiplier.Enabled = true;
                zMultiplier.Enabled = true;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            PopulateList(SelectedType);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(morphList.SelectedIndices.Count > 0)
            {
                Application.DoEvents();
                IPXPmx Scene = args.Host.Connector.Pmx.GetCurrentState();
                int[] Indices = new int[morphList.SelectedItems.Count];
                for(int i = 0; i < morphList.SelectedItems.Count; ++i)
                {
                    Indices[i] = int.Parse(morphList.SelectedItems[i].SubItems[2].Text);
                }

                foreach(int index in Indices)
                {
                    //IPXMorph ScaledMorph = (IPXMorph)args.Host.Builder.Pmx.Morph();
                    IPXMorph ScaledMorph;
                    IPXMorph SourceMorph = (IPXMorph) Scene.Morph[index].Clone();
                    if (scalarScaleCheck.Checked)
                    {
                        ScaledMorph = ScaleMorph(SourceMorph, SelectedType, BoneRotation, (float)uniformMultiplier.Value);
                    }
                    else if (vectorScaleCheck.Checked)
                    {
                        ScaledMorph = ScaleMorph(SourceMorph, SelectedType, BoneRotation, (float)xMultiplier.Value, (float)yMultiplier.Value, (float)zMultiplier.Value);
                    }
                    else
                    {
                        ScaledMorph = Scene.Morph[index];
                    }

                    //Decide whether a new morph is added, or the existing one is replaced
                    if (addNewCheck.Checked)
                    {
                        ScaledMorph.Name = ScaledMorph.Name + " (scaled)";
                        ScaledMorph.NameE = ScaledMorph.NameE + " (scaled)";
                        Scene.Morph.Add(ScaledMorph);
                    }
                    else
                    {
                        Scene.Morph[index] = ScaledMorph;
                    }
                }

                args.Host.Connector.Pmx.Update(Scene);
                args.Host.Connector.Form.UpdateList(PEPlugin.Pmd.UpdateObject.Morph);
                PopulateList(SelectedType);
            }
        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            uniformMultiplier.Value = -uniformMultiplier.Value;
            xMultiplier.Value = -xMultiplier.Value;
            yMultiplier.Value = -yMultiplier.Value;
            zMultiplier.Value = -zMultiplier.Value;
        }

        private void inverseHelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inverseHelpForm help = new inverseHelpForm();
            help.ShowDialog();
            help.Dispose();
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            uniformMultiplier.Value = 1 / uniformMultiplier.Value;
            xMultiplier.Value = 1 / xMultiplier.Value;
            yMultiplier.Value = 1 / yMultiplier.Value;
            zMultiplier.Value = 1 / zMultiplier.Value;
        }
    }
}
