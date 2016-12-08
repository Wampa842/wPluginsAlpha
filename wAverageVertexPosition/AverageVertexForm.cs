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
        IPERunArgs args;
        IPXPmx Scene;
        int[] Selected;
        //List<List<int>> Groups;

        public AverageVertexForm(IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
        }

        private bool IsWithinRange(IPXVertex v1, IPXVertex v2, double range)
        {
            //if ((v1.Position - v2.Position).Length() <= range) return true;
            //else return false;
            double MaxRange = range * range;
            V3 Dist = v1.Position - v2.Position;
            if (Dist.LengthSq() <= MaxRange) return true;
            else return false;
        }

        private List<List<int>> ScanGroups(int[] selected, double range)
        {
            PleaseWaitForm progress = new PleaseWaitForm();
            progress.UpdateProgress(0, 0, selected.Length);
            progress.TopMost = true;
            progress.Show();

            List<int> Group = new List<int>();
            List<List<int>> ListOfGroups = new List<List<int>>();
            //int[] Matched = new int[Selected.Length];
            List<int> Matched = new List<int>();
            for(int i = 0; i < selected.Length; ++i)
            {
                //Only continue if i is not in Matched[].
                if (!Matched.Contains(selected[i]))
                {
                    Matched.Add(selected[i]);
                    Group.Clear();  //Funny note: I was having a hard time figuring out why groups missed one item. Turns out, I called the Clear method AFTER adding i.
                    //Fuck my life.
                    Group.Add(selected[i]);
                    //Possible point of optimization - should get back to this later.
                    for (int j = 0; j < selected.Length; ++j)
                    {
                        if (!Matched.Contains(selected[j]) && IsWithinRange(Scene.Vertex[Selected[i]], Scene.Vertex[Selected[j]], range))
                        {
                            Matched.Add(selected[j]);
                            Group.Add(selected[j]);
                        }
                    }
                    ListOfGroups.Add(Group);
                    progress.UpdateProgress(i, 0, selected.Length);
                }
                MessageBox.Show(i.ToString());
            }
            progress.Close();
            return ListOfGroups;
        }

        private int AverageVerts(IPXPmx pmx, List<int> indices, bool normal)
        {
            V3 Sum = new V3();
            int Count = 0;
            foreach(int index in indices)
            {
                //MessageBox.Show(index.ToString());
                Sum += pmx.Vertex[index].Position;
                Count++;
            }
            V3 Avg = Sum / Count;
            MessageBox.Show(Avg.X.ToString() + "\n" + Avg.Y.ToString() + "\n" + Avg.Z.ToString());
            foreach(int index in indices)
            {
                pmx.Vertex[index].Position = Avg;
            }
            return Count;
        }

        private int ProcessVerts(IPXPmx pmx, bool useThreshold, bool avgNormals, out int p_GroupsCount)
        {
            int Count = 0;
            int GroupsCount = 0;
            if (useThreshold)
            {
                List<List<int>> Groups = ScanGroups(Selected, (double)thresholdNumber.Value);
                foreach(List<int> group in Groups)
                {
                    Count += AverageVerts(pmx, group, avgNormals);
                    ++GroupsCount;
                }
            }
            else
            {
                Count = AverageVerts(pmx, Selected.ToList(), avgNormals);
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
            if (!ScanModel())
            {
                applyButton.Enabled = false;
                return;
            }
            Scene = args.Host.Connector.Pmx.GetCurrentState();
            int GroupsCount;
            int VertsCount = ProcessVerts(Scene, thresholdCheck.Checked, normalCheck.Checked, out GroupsCount);
            UpdatePmx(Scene);

            MessageBox.Show("Collapsed " + VertsCount.ToString() + " vertices into " + GroupsCount.ToString() + " points", "Done!");
        }
    }
}