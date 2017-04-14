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
        public List<String> currentTier;
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
            this.reqsofEachPath = eg.reqsofEachPath;
            this.usedPaths = eg.pathsInGroup;
            this.tierofEachPath = eg.tierofEachPath;
        }

        private void EndingGenerator_Load(object sender, EventArgs e)
        {
            this.Text = "Ending Generator";
            tier = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            tierComboBox.DataSource = tier;
            tierComboBox.SelectedIndex = 0;
            hubComboBox.DataSource = Game.hubs;
            comparitorComboBox.DataSource = new string[] { "<", "<=", "==", ">=", ">" };
            valueTextBox.Text = "0";
            currHub = "";
            globalRadioButton.Checked = true;
            attributes = new List<string>();
            updatePathLists();
            updateTierPaths();
            updateReqList();
        }

        private void updatePathLists()
        {
            usedPathsListBox.DataSource = null;
            usedPathsListBox.DataSource = usedPaths;
            usedPathsListBox.SelectedIndex = -1;

            unusedPaths = new List<string>();
            unusedPaths.AddRange(Game.paths);

            foreach (string p in usedPaths)
            {
                if (unusedPaths.Contains(p))
                {
                    unusedPaths.Remove(p);
                }
            }

            unusedPathsListBox.DataSource = null;
            unusedPathsListBox.DataSource = unusedPaths;
            unusedPathsListBox.SelectedIndex = -1;
            usedPathsListBox.SelectedIndex = usedPaths.Count - 1;

            if (usedPaths.Count == 0)
            {
                tierPathsListBox.DataSource = null;
            }
        }

        private void updateTierPaths()
        {
            if (tierComboBox.SelectedIndex != -1)
            {
                currentTier = new List<string>();
                for (int i = 0; i < usedPaths.Count; ++i)
                {
                    if (tierofEachPath[i] == tierComboBox.SelectedIndex)
                    {
                        currentTier.Add(usedPaths[i]);
                    }
                }
                tierPathsListBox.DataSource = null;
                tierPathsListBox.DataSource = currentTier;
                tierPathsListBox.SelectedIndex = -1;
            }

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
            int i = usedPathsListBox.SelectedIndex;
            List<string> reqs = new List<string>();
            foreach (Requirement r in reqsofEachPath[i])
            {
                reqs.Add(r.name);
            }
            pathRequirementsListBox.DataSource = reqs;
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
            if (unusedPathsListBox.SelectedIndex != -1)
                usedPathsListBox.SelectedIndex = -1;
        }

        private void usedPathsListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tierPathsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tierPathsListBox.SelectedIndex != -1)
            {
                int pIGindex = usedPaths.IndexOf((String)tierPathsListBox.SelectedItem);
                //updatePathLists();
                if (tierPathsListBox.SelectedIndex != -1 && usedPaths.Count > 0 && usedPathsListBox.SelectedIndex == -1 || !usedPathsListBox.SelectedValue.ToString().Equals(tierPathsListBox.SelectedValue.ToString()))
                {
                    usedPathsListBox.SelectedIndex = usedPaths.IndexOf((String)tierPathsListBox.SelectedValue);
                }
                updateReqList();
            }
        }

        private void pathRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pathRequirementsListBox.SelectedIndex != -1)
            {
                Requirement r = reqsofEachPath[usedPathsListBox.SelectedIndex][pathRequirementsListBox.SelectedIndex];
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
                    valueTextBox.Text = r.value.ToString();
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
            int i = usedPathsListBox.SelectedIndex;
            if (i != -1)
            {
                usedPaths.RemoveAt(i);
                tierofEachPath.RemoveAt(i);
                //useOnceList.RemoveAt(i);
                reqsofEachPath.RemoveAt(i);

            }
            updatePathLists();
        }

        private void editTierPathButton_Click(object sender, EventArgs e)
        {
            if (tierPathsListBox.SelectedIndex != -1)
            {
                int indexofPath = usedPaths.IndexOf((String)tierPathsListBox.SelectedItem);

                int index = tierPathsListBox.SelectedIndex;
                tierPathsListBox.DataSource = null;
                tierPathsListBox.DataSource = getTierPathsNames();
                tierPathsListBox.SelectedIndex = index;

            }
        }

        private void addConditionButton_Click(object sender, EventArgs e)
        {
            if (attributeComboBox.SelectedIndex != -1 && usedPathsListBox.SelectedIndex != -1)
            {


                try
                {
                    int value = Int32.Parse(valueTextBox.Text);
                    int i = usedPathsListBox.SelectedIndex;
                    reqsofEachPath[i].Add(new Requirement(scope, currHub, attributeComboBox.SelectedValue.ToString(), comparitorComboBox.SelectedValue.ToString(), value));
                    updateReqList();
                    pathRequirementsListBox.SelectedIndex = reqsofEachPath[i].Count - 1;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Value must be an Integer.");
                    valueTextBox.Text = "";
                }
            }
        }

        private void removeConditionButton_Click(object sender, EventArgs e)
        {
            if (pathRequirementsListBox.SelectedIndex != -1)
            {
                int i = pathRequirementsListBox.SelectedIndex;
                reqsofEachPath[usedPathsListBox.SelectedIndex].RemoveAt(pathRequirementsListBox.SelectedIndex);
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

        private void tierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = tierLabel + tierComboBox.SelectedIndex;
            updateTierPaths();
        }

        private void buttonListUpButton_Click(object sender, EventArgs e)
        {
            int index = tierPathsListBox.SelectedIndex;
            if (index != -1 && index != 0)
            {
                swap(index, index - 1);
                updateTierPaths();
                updatePathLists();
                updateReqList();
                tierPathsListBox.SelectedIndex = -1;
                usedPathsListBox.SelectedIndex = -1;
                pathRequirementsListBox.SelectedIndex = -1;
            }
        }

        private void buttonListDownButton_Click(object sender, EventArgs e)
        {
            int index = tierPathsListBox.SelectedIndex;
            if (index != -1 && index < usedPaths.Count - 1)
            {
                swap(index, index + 1);
                updateTierPaths();
                updatePathLists();
                updateReqList();
                tierPathsListBox.SelectedIndex = -1;
                usedPathsListBox.SelectedIndex = -1;
                pathRequirementsListBox.SelectedIndex = -1;
            }
        }
    }
}
