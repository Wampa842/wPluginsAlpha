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
            if (Math.Abs((v1.Position - v2.Position).Length()) <= range) return true;
            else return false;
        }

        private void CountRepeating(List<int> data)
        {
            bool ok = true;
            List<int> a = new List<int>();
            foreach(int d in data)
            {
                if (a.Contains(d))
                {
                    MessageBox.Show("Duplicate: " + d.ToString());
                    ok = false;
                }
                a.Add(d);
            }
            MessageBox.Show(ok.ToString());
        }

        private List<List<int>> ScanGroups(IPXPmx pmx, int[] selected, double range)
        {
            IList<IPXVertex> verts = pmx.Vertex;
            List<List<int>> ListOfGroups = new List<List<int>>();
            List<int> Source = selected.ToList();
            List<int> Group = new List<int>();
            List<int> Matched = new List<int>();

            ListOfGroups.Clear();
            for(int i = 0; i < Source.Count; ++i)
            {
                Group.Clear();
                if (!Matched.Contains(Source[i]))
                {
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
                    //ListOfGroups.Add(Group);
                    AverageVerts(pmx, Group, false);
                    //MessageBox.Show(ListOfGroups.Last().Count.ToString());
                    //MessageBox.Show("Items in group: " + Group.Count);
                }
                //else MessageBox.Show(Source[i] + " is already in the list");
            }

            //MessageBox.Show(ListOfGroups[0].Count.ToString());
            return ListOfGroups;
        }

        private int AverageVerts(IPXPmx pmx, List<int> indices, bool normal)
        {
            V3 Sum = new V3();
            int i = 0;
            for (i = 0; i < indices.Count; ++i)
            {
                Sum += pmx.Vertex[indices[i]].Position;
                //Count = i;
            }
            //if(i <= 0) MessageBox.Show("heck");
            V3 Avg = Sum / i;
            //MessageBox.Show(Avg.X.ToString() + "\n" + Avg.Y.ToString() + "\n" + Avg.Z.ToString());
            foreach(int index in indices)
            {
                pmx.Vertex[index].Position = Avg;
            }
            return i;
        }

        private int ProcessVerts(IPXPmx pmx, bool useThreshold, bool avgNormals, out int p_GroupsCount)
        {
            int Count = 0;
            int GroupsCount = 0;
            if (useThreshold)
            {
                List<List<int>> Groups = ScanGroups(pmx, Selected, (double)thresholdNumber.Value);


                //List<List<int>> Groups = new List<int>[] { a[0], a[1] }.ToList();

                //MessageBox.Show(Groups[0].Count.ToString());

                //List<int> g1 = new int[] { 0, 1, 2, 3, 4 }.ToList();
                //List<int> g2 = new int[] { 5, 6, 7, 8, 9, 10 }.ToList();
                //List<List<int>> Groups = new List<int>[] { g1, g2 }.ToList();
                /*
                foreach(List<int> group in Groups)
                {
                    //MessageBox.Show(group.Count.ToString());
                    Count += AverageVerts(pmx, group, avgNormals);
                    ++GroupsCount;
                }
                MessageBox.Show("Groups: " + Groups.Length.ToString());
                for(int g = 0; g < Groups.Length; ++g)
                {
                    MessageBox.Show("Group " + g + ": " + Groups[g].Count);
                }*/
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

        private void button1_Click(object sender, EventArgs e)
        {
            //ScanGroups(args.Host.Connector.Pmx.GetCurrentState().Vertex, Selected, (double)thresholdNumber.Value);
        }
    }
}