using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Test2
{
    public partial class EndingGenerator : Form
    {
        public List<List<Requirement>> reqsofEachPath;
        public List<String> usedPaths;
        public List<int> tierofEachPath;
        public int[] tier;
        public List<String> unusedPaths;
        private const string tierLabel = "Endings in Tier: ";
        private string currHub;
        private int scope;
        private List<String> attributes;



        public EndingGenerator()
        {
            InitializeComponent();
            reqsofEachPath = new List<List<Requirement>>();
            usedPaths = new List<String>();
            tierofEachPath = new List<int>();
            //public List<Boolean> useOnceList

            unusedPaths = new List<string>();
            for (int i = 0; i < Game.paths.Count; i++)
                unusedPaths.Add(Game.paths[i]);
        }

        public EndingGenerator(EndingGen eg)
        {
            InitializeComponent();
            this.reqsofEachPath =  new List<List<Requirement>>(eg.reqsofEachPath);
            this.usedPaths = new List<string>(eg.pathsInGroup);
            this.tierofEachPath = new List<int>(eg.tierofEachPath);
        }

        private void EndingGenerator_Load(object sender, EventArgs e)
        {
            this.Text = "Ending Generator";
            tier = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            tierComboBox.DataSource = tier;
            tierComboBox.SelectedIndex = 0;
            hubComboBox.DataSource = Game.hubs;
            comparitorComboBox.DataSource = new string[] { "<", "<=", "==", ">=", ">" };
            valueNumeric.Value = 0;
            currHub = "";
            globalRadioButton.Checked = true;
            attributes = new List<string>();
            updatePathLists();
            updateReqList();
        }

        private void updatePathLists()
        {
           

            unusedPaths = new List<string>();
            unusedPaths.AddRange(Game.paths);

            ListViewGroup currTier;
            ListViewItem currPath;

            
            pathsGroupedByTier.Clear();
            pathsGroupedByTier.Groups.Clear();
            if (usedPaths.Count > 0)
            {
                for (int i = 0; i <= tierofEachPath.Max(); i++)
                {
                    currTier = new ListViewGroup("Tier " + i);
                    pathsGroupedByTier.Groups.Add(currTier);
                }
            }

            int pathCtr = 0;
            foreach (string p in usedPaths)
            {
                currTier = pathsGroupedByTier.Groups[tierofEachPath[pathCtr]];
                currPath = new ListViewItem(p);
                currPath.Group = currTier;
                pathsGroupedByTier.Items.Add(currPath);

                if (unusedPaths.Contains(p))
                {
                    unusedPaths.Remove(p);
                }
                pathCtr++;
            }

            unusedPathsListBox.DataSource = null;
            unusedPathsListBox.DataSource = unusedPaths;
            unusedPathsListBox.SelectedIndex = -1;
          

          
        }

      

        private List<String> getTierPathsNames()
        {
            List<string> pathsInTier = new List<string>();

            if (tierComboBox.SelectedIndex != -1)
            {
                pathsInTier = new List<string>();
                int tier = tierComboBox.SelectedIndex;
                for (int i = 0; i < usedPaths.Count; ++i)
                {
                    if (tierofEachPath[i] == tier)
                    {
                        pathsInTier.Add(usedPaths[i]);
                    }
                }
            }
            return pathsInTier;
        }

        private int updateReqList()
        {
            List<string> reqs = new List<string>();
            if (pathsGroupedByTier.SelectedIndices.Count > 0)
            {
                int i = pathsGroupedByTier.SelectedIndices[0];
                
                foreach (Requirement r in reqsofEachPath[i])
                {
                    reqs.Add(r.name);
                }
                pathRequirementsListBox.DataSource = reqs;
            }
            return reqs.Count;
        }

        private void setAttributeComboBox()
        {
            attributeComboBox.DataSource = Attributes.getScope(scope, currHub);
        }

        private void swap(int from, int to)
        {
            string temp = "";
            List<Requirement> t = new List<Requirement>();
           

            if (to >= 0 && to < usedPaths.Count)
            {
                temp = usedPaths[to];
                usedPaths[to] = usedPaths[from];
                usedPaths[from] = temp;
                t = reqsofEachPath[to];
                reqsofEachPath[to] = reqsofEachPath[from];
                reqsofEachPath[from] = t;
                
            }
        }

        private void unusedPathsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

/*        private void usedPathsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usedPathsListBox.SelectedIndex != -1)
            {

                unusedPathsListBox.SelectedIndex = -1;
                if (tierPathsListBox.SelectedIndex == -1 || (usedPathsListBox.SelectedValue != tierPathsListBox.SelectedValue))
                {
                    int index = usedPathsListBox.SelectedIndex;
                    tierComboBox.SelectedIndex = -1;
                    tierComboBox.SelectedIndex = tierofEachPath[index];
                    tierPathsListBox.SelectedIndex = ((List<String>)tierPathsListBox.DataSource).IndexOf(usedPaths[index]);
                }
            }
        }
        */
      
        
        private void pathRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pathRequirementsListBox.SelectedIndex != -1)
            {
                Requirement r = reqsofEachPath[pathsGroupedByTier.SelectedIndices[0]][pathRequirementsListBox.SelectedIndex];
                if (r != null)
                {
                    switch (r.scope)
                    {
                        case 0:
                            globalRadioButton.Checked = true;
                            break;
                        case 1:
                            hubRadioButton.Checked = true;
                            hubComboBox.SelectedIndex = hubComboBox.FindStringExact(r.hub);
                            break;
                        case 2:
                            playerRadioButton.Checked = true;
                            break;
                    }
                    attributeComboBox.SelectedIndex = attributeComboBox.FindStringExact(r.name);
                    comparitorComboBox.SelectedIndex = comparitorComboBox.FindStringExact(r.comp);
                    valueNumeric.Value = r.value;
                }
            }
        }

        private void addPathsButton_Click(object sender, EventArgs e)
        {
            foreach (int i in unusedPathsListBox.SelectedIndices)
            {
                usedPaths.Add(unusedPaths[i]);
                tierofEachPath.Add(tierComboBox.SelectedIndex);
                reqsofEachPath.Add(new List<Requirement>());
            }
            updatePathLists();
        }

        private void removePathsButton_Click(object sender, EventArgs e)
        {
            if (pathsGroupedByTier.SelectedIndices.Count > 0)
            {
                int i = pathsGroupedByTier.SelectedIndices[0];
                usedPaths.RemoveAt(i);
                tierofEachPath.RemoveAt(i);
                reqsofEachPath.RemoveAt(i);
                updatePathLists();
            }
        }

       

        private void addConditionButton_Click(object sender, EventArgs e)
        {
            if (attributeComboBox.SelectedIndex != -1 && pathsGroupedByTier.SelectedIndices[0] != -1)
            {

                
                try
                {
                    int value = (int)valueNumeric.Value;
                    int i = pathsGroupedByTier.SelectedIndices[0];
                    reqsofEachPath[i].Add(new Requirement(scope, currHub, attributeComboBox.SelectedValue.ToString(), comparitorComboBox.SelectedValue.ToString(), value));
                    updateReqList();
                    pathRequirementsListBox.SelectedIndex = reqsofEachPath[i].Count - 1;
                }
                catch (InvalidCastException ex)
                {
                    Console.Out.WriteLine(ex.StackTrace);
                    MessageBox.Show("Value must be an Integer.");
                    valueNumeric.Value = 0;
                }
            }
        }

        private void removeConditionButton_Click(object sender, EventArgs e)
        {
            if (pathRequirementsListBox.SelectedIndex != -1)
            {
                int i = pathRequirementsListBox.SelectedIndex;
                
                reqsofEachPath[pathsGroupedByTier.SelectedIndices[0]].RemoveAt(pathRequirementsListBox.SelectedIndex);
                if (i == updateReqList())
                {
                    i = i - 1;
                }
                pathRequirementsListBox.SelectedIndex = i;

            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Game.endingGen = new EndingGen(reqsofEachPath, usedPaths, tierofEachPath);
            Close();
        }

        private void globalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (globalRadioButton.Enabled)
            {
                scope = 0;
                setAttributeComboBox();
            }
        }

        private void hubRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hubRadioButton.Checked)
            {
                scope = 1;
                hubLabel.Enabled = true;
                hubComboBox.Enabled = true;
                if (hubComboBox.SelectedIndex != -1)
                {
                    currHub = hubComboBox.SelectedItem.ToString();
                    setAttributeComboBox();
                }
                else
                {
                    attributeComboBox.DataSource = null;
                }
            }
            else
            {
                hubLabel.Enabled = false;
                hubComboBox.Enabled = false;
                currHub = "";
            }
        }

        private void playerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (playerRadioButton.Enabled)
            {
                scope = 2;
                setAttributeComboBox();
            }
        }

        private void pathsGroupedByTier_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            updateReqList();
        }

        private void buttonListLeftButton_Click(object sender, EventArgs e)
        {
            if (pathsGroupedByTier.SelectedIndices.Count <= 0)
                return;

            ListViewItem selectedItem = pathsGroupedByTier.SelectedItems[0];
            ListViewGroup tier = selectedItem.Group;
            int tierIndex = pathsGroupedByTier.Groups.IndexOf(tier);
            int index = pathsGroupedByTier.SelectedIndices[0];
            int indexInTier = tier.Items.IndexOf(selectedItem);
            if (indexInTier > 0 && indexInTier < selectedItem.Group.Items.Count)
            {
                int swapIndex = pathsGroupedByTier.Items.IndexOf(tier.Items[indexInTier - 1]);
                swap(index, swapIndex);
                updatePathLists();
                pathsGroupedByTier.Items[swapIndex].Selected = true;
                pathsGroupedByTier.Items[swapIndex].Focused = true;

            }
        }

        private void buttonListRightButton_Click(object sender, EventArgs e)
        {
            if (pathsGroupedByTier.SelectedIndices.Count <= 0)
                return;

            ListViewItem selectedItem = pathsGroupedByTier.SelectedItems[0];
            ListViewGroup tier = selectedItem.Group;
            int tierIndex = pathsGroupedByTier.Groups.IndexOf(tier);
            int index = pathsGroupedByTier.SelectedIndices[0];
            int indexInTier = tier.Items.IndexOf(selectedItem);
            if (indexInTier >= 0 && indexInTier < selectedItem.Group.Items.Count- 1)
            {
                int swapIndex = pathsGroupedByTier.Items.IndexOf(tier.Items[indexInTier + 1]);
                swap(index, swapIndex);
                
                updatePathLists();
                pathsGroupedByTier.Items[swapIndex].Selected = true;
                pathsGroupedByTier.Items[swapIndex].Focused = true;

            }
        }
    }
}
