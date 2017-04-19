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
    public partial class EditPathGroupForm : Form
    {
        public String name;
        public ProjectHomeForm parentForm;
        //private List<List<String>> pathPreReqs;
        public List<List<Requirement>> reqsofEachPath;
        public List<String> pathsInGroup;
        public List<int> weightofEachPath;
        public List<int> tierofEachPath;
        public List<Boolean> useOnceList;
        public int[] tier;
        public List<String> navsNotInPG;
        public List<String> currentTier;
        private const string tierLabel = "Paths in Tier: ";
        private string currHub;
        private int scope;
        private List<String> attributes;
        private bool onLoad = false;

        public EditPathGroupForm(ProjectHomeForm par, String nam)
        {
            InitializeComponent();
            name = nam;
            parentForm = par;
            //pathPreReqs = new List<List<String>>();
            reqsofEachPath = new List<List<Requirement>>();
            pathsInGroup = new List<String>();
            weightofEachPath = new List<int>();
            tierofEachPath = new List<int>();
            this.useOnceList = new List<bool>();
            
        }

        public EditPathGroupForm(ProjectHomeForm par, PathGroup pg) {
            InitializeComponent();
            name = pg.name;
            parentForm = par;
            //pathPreReqs = pg.pathPreReqs;
            reqsofEachPath = new List<List<Requirement>>();
            foreach(List<Requirement> rl in pg.pathRequirements)
            {
                List<Requirement>rk = new List<Requirement>();
                foreach(Requirement r in rl)
                {
                    rk.Add(r);
                }
                reqsofEachPath.Add(rk);
            }
            pathsInGroup = new List<string>();
            foreach(string s in pg.pathsInGroup)
            {
                pathsInGroup.Add(s);
            }
            weightofEachPath = new List<int>();
            foreach (int i in pg.weightsofEachPath)
            {
                weightofEachPath.Add(i);
            }
            tierofEachPath = new List<int>();
            foreach (int i in pg.tiersofEachPath)
            {
                tierofEachPath.Add(i);
            }
            useOnceList = pg.useOnce;
        }

        private void EditPathGroupForm_Load(object sender, EventArgs e)
        {
            this.Text = "Edit PathGroup: " + name;
            onLoad = true;
            tier = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            tierComboBox.DataSource = tier;
            tierComboBox.SelectedIndex = 0;
            hubComboBox.DataSource = Game.hubs;//", "
            comparitorComboBox.DataSource = new string[] { "<", "<=", "==", ">=", ">" };
            valueTextBox.Text = "0";
            currHub = "";
            globalRadioButton.Checked = true;
            attributes = new List<string>();
            updatePathGroupLists();
            onLoad = false;
            tierPathsListBox.SelectedIndex = -1;
        }
        

        private void pathsNotInPathGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updatePathGroupLists()
        {

            navsNotInPG = new List<string>();
            navsNotInPG.AddRange(Game.paths);
            navsNotInPG.AddRange(Game.pathGroups);
            navsNotInPG.AddRange(Game.hubs);
            foreach(string p in pathsInGroup)
            {
                if (navsNotInPG.Contains(p))
                {
                    navsNotInPG.Remove(p);
                }
            }
            navsNotInPG.Remove(this.name);
            pathsNotInPathGroupListBox.DataSource = null;
            pathsNotInPathGroupListBox.DataSource = navsNotInPG;
            pathsNotInPathGroupListBox.SelectedIndex = -1;
            pathsInPathGroupListBox.DataSource = null;
            pathsInPathGroupListBox.DataSource = pathsInGroup;
            pathsInPathGroupListBox.SelectedIndex = -1;
            //pathsInPathGroupListBox.SelectedIndex = pathsInGroup.Count - 1;
            if (pathsInGroup.Count == 0)
            {
                tierPathsListBox.DataSource = null;
            }
            
            


        }
        private void updateTierPaths()
        {
            if (tierComboBox.SelectedIndex != -1)
            {
                int tierWeight=0;
                currentTier = new List<string>();
                for (int i = 0; i < pathsInGroup.Count; ++i)
                {
                    if (tierofEachPath[i] == tierComboBox.SelectedIndex)
                    {
                        currentTier.Add(pathsInGroup[i]);
                        tierWeight += weightofEachPath[i];

                    }
                }
                tierPathsListBox.DataSource = null;
                tierPathsListBox.DataSource = currentTier;
                tierPathsListBox.SelectedIndex = -1;
                tierWeightTextBox.Text = tierWeight.ToString();
                
            }

        }
        private List<String> getTierPathsNames()
        {
            List<string> pathsInTier = new List<string>();

            if (tierComboBox.SelectedIndex != -1) {
                pathsInTier = new List<string>();
                int tier = tierComboBox.SelectedIndex;
                for (int i = 0; i < pathsInGroup.Count; ++i)
                {
                    if (tierofEachPath[i] == tier)
                    {
                        pathsInTier.Add(pathsInGroup[i]);
                    }
                }
            }
            return pathsInTier;
        }

        private void addPathsButton_Click(object sender, EventArgs e)
        {
            int index;
            int weight = (int)pathWeightNumericUpDown.Value;
            index = pathsInGroup.Count - 1;
            foreach (int i in pathsNotInPathGroupListBox.SelectedIndices)
            {
                pathsInGroup.Add(navsNotInPG[i]);
                tierofEachPath.Add(tierComboBox.SelectedIndex);
                weightofEachPath.Add(weight);
                useOnceList.Add(useOnceCheckBox.Checked);
                reqsofEachPath.Add(new List<Requirement>());
            }
            if (pathsNotInPathGroupListBox.SelectedIndices.Count > 0)
            {
                ++index;
            }
                
            updatePathGroupLists();
            tierComboBox_SelectedIndexChanged(sender, e);
            pathsInPathGroupListBox.SelectedIndex = index;
        }
        

        private void removePathsButton_Click(object sender, EventArgs e)
        {
            int index = pathsInPathGroupListBox.SelectedIndex;
            if (index != -1) {
                pathsInGroup.RemoveAt(index);
                tierofEachPath.RemoveAt(index);
                weightofEachPath.RemoveAt(index);
                useOnceList.RemoveAt(index);
                reqsofEachPath.RemoveAt(index);
                if (index == pathsInGroup.Count)
                {
                    --index;
                }

            }
            updatePathGroupLists();
            tierComboBox_SelectedIndexChanged(sender, e);
            pathsInPathGroupListBox.SelectedIndex = index;
        }

        private void editTierPathButton_Click(object sender, EventArgs e)
        {
            if (tierPathsListBox.SelectedIndex != -1) {
                int weight;
                weight = (int)pathWeightNumericUpDown.Value;
                int indexofPath = pathsInGroup.IndexOf((String)tierPathsListBox.SelectedItem);
                weightofEachPath[indexofPath] = weight;
                useOnceCheckBox.Checked = useOnceList[indexofPath];

                int index = tierPathsListBox.SelectedIndex;
                tierPathsListBox.DataSource = null;
                tierPathsListBox.DataSource = getTierPathsNames();
                tierPathsListBox.SelectedIndex = index;
            }
        }

        private void pathsInPathGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pathsInPathGroupListBox.SelectedIndex != -1)
            {

                pathsNotInPathGroupListBox.SelectedIndex = -1;
                if (tierPathsListBox.SelectedIndex == -1 || (pathsInPathGroupListBox.SelectedValue != tierPathsListBox.SelectedValue))
                {
                    int index = pathsInPathGroupListBox.SelectedIndex;
                    tierComboBox.SelectedIndex = -1;
                    tierComboBox.SelectedIndex = tierofEachPath[index];
                    tierPathsListBox.SelectedIndex = ((List<String>)tierPathsListBox.DataSource).IndexOf(pathsInGroup[index]);
                }
            }
        }

        private void tierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = tierLabel + tierComboBox.SelectedIndex;
            updateTierPaths();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (!Game.pathGroups.Contains(name))
            {
                Game.pathGroups.Add(name);
                Game.navIndex.Add(name, new PathGroup(name, pathsInGroup, weightofEachPath, tierofEachPath, reqsofEachPath, useOnceList));
            }
            else
                Game.navIndex[name] = new PathGroup(name, pathsInGroup, weightofEachPath, tierofEachPath, reqsofEachPath, useOnceList);
            Close();
        }

        private void tierPathsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tierPathsListBox.SelectedIndex != -1)
            {
                int pIGindex = pathsInGroup.IndexOf((String)tierPathsListBox.SelectedItem);
                pathWeightNumericUpDown.Value = weightofEachPath[pIGindex];
                useOnceCheckBox.Checked = useOnceList[pIGindex];
                if (!onLoad&&(pathsInPathGroupListBox.SelectedIndex == -1 || !pathsInPathGroupListBox.SelectedValue.ToString().Equals(tierPathsListBox.SelectedValue.ToString())))
                { 
                    pathsInPathGroupListBox.SelectedIndex = pathsInGroup.IndexOf((String)tierPathsListBox.SelectedValue);
                }
                updateReqList();
            }
        }

        private void pathsNotInPathGroupListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(pathsNotInPathGroupListBox.SelectedIndex!=-1)
                pathsInPathGroupListBox.SelectedIndex = -1;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void globalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (globalRadioButton.Enabled)
            {
                scope = Requirement.GLOBAL;
                setAttributeComboBox();
            }
        }

        private void hubRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hubRadioButton.Checked)
            {
                scope = Requirement.HUB;
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
                scope = Requirement.PLAYER;
                setAttributeComboBox();
            }
        }
        private void setAttributeComboBox()
        {
            attributeComboBox.DataSource = Attributes.getScope(scope, currHub);

        }

        private void hubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hubComboBox.SelectedIndex !=-1)
            {
                playerRadioButton.Checked = true;
                hubRadioButton.Checked = true;
                //setAttributeComboBox();
            }
        }

        private void addConditionButton_Click(object sender, EventArgs e)
        {
            if (attributeComboBox.SelectedIndex != -1&& pathsInPathGroupListBox.SelectedIndex!=-1)
            {


                try
                {
                    int value = Int32.Parse(valueTextBox.Text);
                    int i = pathsInPathGroupListBox.SelectedIndex;
                    reqsofEachPath[i].Add(new Requirement(scope, currHub, attributeComboBox.SelectedValue.ToString(), comparitorComboBox.SelectedValue.ToString(), value));
                    updateReqList();
                    pathRequirementsListBox.SelectedIndex = reqsofEachPath[i].Count-1;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Value must be an Integer.");
                    valueTextBox.Text = "";
                }
            }
        }
        private int updateReqList()
        {
            List<string> reqs = new List<string>();
            if (pathsInPathGroupListBox.SelectedIndex != -1)
            {
                int i = pathsInPathGroupListBox.SelectedIndex;
                foreach (Requirement r in reqsofEachPath[i])
                {
                    reqs.Add(r.name);
                }
                pathRequirementsListBox.DataSource = reqs;
            }

            return reqs.Count;
        }

        private void pathRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pathRequirementsListBox.SelectedIndex != -1)
            {
                Requirement r = reqsofEachPath[pathsInPathGroupListBox.SelectedIndex][pathRequirementsListBox.SelectedIndex];
                if(r != null)
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
                    if (r.hub != "")
                    {
                        hubComboBox.SelectedIndex = Game.hubs.IndexOf(r.hub);
                    }
                    attributeComboBox.SelectedIndex = attributeComboBox.FindStringExact(r.name);
                    comparitorComboBox.SelectedIndex = comparitorComboBox.FindStringExact(r.comp);
                    valueTextBox.Text = r.value.ToString() ;
                }
            }
            
        }

        private void removeConditionButton_Click(object sender, EventArgs e)
        {
            if (pathRequirementsListBox.SelectedIndex != -1)
            {
                int i = pathRequirementsListBox.SelectedIndex;
                reqsofEachPath[pathsInPathGroupListBox.SelectedIndex].RemoveAt(pathRequirementsListBox.SelectedIndex);
                if (i == updateReqList())
                {
                    i = i-1;
                }
               pathRequirementsListBox.SelectedIndex = i;
                
            }
        }
    }
}
