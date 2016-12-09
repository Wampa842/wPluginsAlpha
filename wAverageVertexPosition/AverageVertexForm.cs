using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.Form;
using PEPlugin.Pmx;
using PEPlugin.SDX;

namespace wAverageVertexPosition
{
    public partial class AverageVertexForm : Form
    {
        IPERunArgs args;    //Run args; the usual.
        IPXPmx Scene;   
        int[] Selected;

        public AverageVertexForm(IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
        }

        private bool IsWithinRange(IPXVertex v1, IPXVertex v2, double range)
        {
            if (Math.Abs((v1.Position - v2.Position).Length()) <= range) return true;
            else return false;
        }
        
        //The method that does the brunt of the operations and sets up groups that can be averaged.
        private int AverageGroups(IPXPmx pmx, int[] selected, double range, bool position, bool normals, out int groupCount)
        {
            //The number of the operations grows quadratically with selected vertices. A form with a neat little progress bar makes sure the user doesn't get too bored.
            PleaseWaitForm progress = new PleaseWaitForm();
            progress.UpdateProgress(0, 0, selected.Length);
            progress.Show();

            IList<IPXVertex> verts = pmx.Vertex;
            List<int> Source = selected.ToList();   //Completely unnecessary, but I'm afraid removing this would cause unexpected errors.
            List<int> Group = new List<int>();
            List<int> Matched = new List<int>();

            groupCount = 0;
            for(int i = 0; i < Source.Count; ++i)
            {
                Group.Clear();
                if (!Matched.Contains(Source[i]))
                {
                    //If the ith vertex hasn't been processed yet, add it to the current group and mark it as processed.ű
                    Group.Add(Source[i]);
                    Matched.Add(Source[i]);
                    for (int j = 0; j < Source.Count; ++j)
                    {
                        if (!Matched.Contains(Source[j]))
                        {
                            if(IsWithinRange(verts[Source[i]], verts[Source[j]], range))
                            {
                                Group.Add(Source[j]);
                                Matched.Add(Source[j]);
                            }
                        }
                    }
                    //I originally wanted to pass a list of the groups back to the ProcessVerts method, but for some reason (probably a good reason), passing a List<List<int>> is problematic.
                    AverageVerts(pmx, Group, position, normals);
                    progress.UpdateProgress(Matched.Count, 0, selected.Length); //For the entertainment of the user
                    groupCount++;
                }
            }
            progress.Close();
            if (groupCount >= Matched.Count) MessageBox.Show("No two vertices were within range of each other.\nIncrease the threshold and make sure you've selected the correct vertices.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return Matched.Count;
        }

        //Set vertex positions to their average
        private int AverageVerts(IPXPmx pmx, List<int> indices, bool position, bool normal)
        {
            V3 Sum = new V3();
            V3 NSum = new V3();
            int i = 0;
            for (i = 0; i < indices.Count; ++i)
            {
                if (normal) NSum += pmx.Vertex[indices[i]].Normal;
                Sum += pmx.Vertex[indices[i]].Position;
            }
            V3 Avg = Sum / i;   //Sum over count. Basic arithmetic average.
            V3 NAvg = new V3();
            if (normal) NAvg = NSum / i;
            foreach(int index in indices)
            {
                if (normal) pmx.Vertex[index].Normal = NAvg;
                pmx.Vertex[index].Position = Avg;   //Set all relevant vertices to the same position and normals.
            }
            return i;
        }

        //Choose which process to use
        private int ProcessVerts(IPXPmx pmx, bool useThreshold, bool avgPos, bool avgNormals, out int p_GroupsCount)
        {
            int Count = 0;
            int GroupsCount = 0;
            if (useThreshold)
            {
                Count = AverageGroups(pmx, Selected, (double)thresholdNumber.Value, avgPos, avgNormals, out GroupsCount);
            }
            else
            {
                Count = AverageVerts(pmx, Selected.ToList(), avgPos, avgNormals);
                GroupsCount = 1;
            }
            p_GroupsCount = GroupsCount;
            return Count;
        }

        private bool ScanModel()
        {
            Scene = args.Host.Connector.Pmx.GetCurrentState();
            Selected = args.Host.Connector.View.PMDView.GetSelectedVertexIndices();
            selectedVertsLabel.Text = Selected.Count().ToString() + " vertices selected";
            return Selected.Count() > 0;
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            //If ScanModel reports that no vertices are selected, disable the apply button.
            applyButton.Enabled = ScanModel();
        }

        private void thresholdCheck_CheckedChanged(object sender, EventArgs e)
        {
            thresholdNumber.Enabled = thresholdCheck.Checked;
        }

        private void UpdatePmx(IPXPmx pmx)
        {
            args.Host.Connector.Pmx.Update(pmx);
            args.Host.Connector.View.PMDView.UpdateModel();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (!ScanModel())   //Scan the model again. If it reports that nothing's selected, cancel the operation.
            {
                applyButton.Enabled = false;
                return;
            }
            Application.DoEvents();
            int GroupsCount;
            int VertsCount = ProcessVerts(Scene, thresholdCheck.Checked, positionCheck.Checked, normalCheck.Checked, out GroupsCount);
            UpdatePmx(Scene);

            MessageBox.Show("Collapsed " + VertsCount.ToString() + " vertices into " + GroupsCount.ToString() + " points", "Done!");
        }

        private void infoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}