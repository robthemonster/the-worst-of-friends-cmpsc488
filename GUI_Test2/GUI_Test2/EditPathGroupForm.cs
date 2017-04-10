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
        private List<List<String>> pathPreReqs;
        public List<List<Requirement>> reqsofEachPath;
        public List<String> pathsInGroup;
        public List<int> weightofEachPath;
        public List<int> tierofEachPath;
        public List<Boolean> useOnceList;
        public int[] tier;
        public List<String> pnipg;
        public List<String> currentTier;
        private const string tierLabel = "Paths in Tier: ";
        private string currHub;
        private int scope;

        


        public EditPathGroupForm(ProjectHomeForm par, String nam)
        {
            InitializeComponent();
            name = nam;
            parentForm = par;
            pathPreReqs = new List<List<String>>();
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
            pathPreReqs = pg.pathPreReqs;
            reqsofEachPath = pg.pathRequirements;
            pathsInGroup = pg.pathsInGroup;
            weightofEachPath = pg.weightsofEachPath;
            tierofEachPath = pg.tiersofEachPath;
            useOnceList = pg.useOnce;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditPathGroupForm_Load(object sender, EventArgs e)
        {
            this.Text = "Edit PathGroup: " + name;
            tier = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            tierComboBox.DataSource = tier;
            tierComboBox.SelectedIndex = 0;
            hubComboBox.DataSource = Game.hubs;//", "
            comparitorComboBox.DataSource = new string[] { "<", "<=", "==", ">=", ">" };
            valueTextBox.Text = "0";
            updatePathGroupLists();

        }
        

        private void pathsNotInPathGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updatePathGroupLists()
        {
            pathsInPathGroupListBox.DataSource = null;
            pathsInPathGroupListBox.DataSource = pathsInGroup;
            pathsInPathGroupListBox.SelectedIndex = -1;

            pnipg = new List<string>();
            foreach (String p in Game.paths)
            {
                if (!pathsInGroup.Contains(p))
                {
                    pnipg.Add(p);
                }
            }
            pathsNotInPathGroupListBox.DataSource = null;
            pathsNotInPathGroupListBox.DataSource = pnipg;
            pathsNotInPathGroupListBox.SelectedIndex = -1;
            pathsInPathGroupListBox.SelectedIndex = pathsInGroup.Count - 1;
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
            try
            {
                int weight = Int32.Parse(pathWeightTextBox.Text);
                if ( weight<= 0)
                {
                    throw new FormatException();
                }
                foreach (int i in pathsNotInPathGroupListBox.SelectedIndices)
                {
                    pathsInGroup.Add(pnipg[i]);
                    tierofEachPath.Add(tierComboBox.SelectedIndex);
                    weightofEachPath.Add(Int32.Parse(pathWeightTextBox.Text));
                    useOnceList.Add(useOnceCheckBox.Checked);
                }
                updatePathGroupLists();
            }
            catch (FormatException)
            {
                MessageBox.Show("Weight must be a positive integer.");
            }
        }
        

        private void removePathsButton_Click(object sender, EventArgs e)
        {
            int i = pathsInPathGroupListBox.SelectedIndex;
            if (i != -1) {
                pathsInGroup.RemoveAt(i);
                tierofEachPath.RemoveAt(i);
                weightofEachPath.RemoveAt(i);
                useOnceList.RemoveAt(i);

            }
            updatePathGroupLists();
        }

        private void editTierPathButton_Click(object sender, EventArgs e)
        {
            if (tierPathsListBox.SelectedIndex != -1) {
                int weight;
                try
                {
                    weight = Int32.Parse(pathWeightTextBox.Text);
                    int indexofPath = pathsInGroup.IndexOf((String)tierPathsListBox.SelectedItem);
                    if (weight <= 0)
                    {
                        throw new FormatException();
                    }
                    weightofEachPath[indexofPath] = weight;
                    useOnceCheckBox.Checked = useOnceList[indexofPath];

                    int index = tierPathsListBox.SelectedIndex;
                    tierPathsListBox.DataSource = null;
                    tierPathsListBox.DataSource = getTierPathsNames();
                    tierPathsListBox.SelectedIndex = index;
                }
                catch(FormatException)
                {
                    MessageBox.Show("Weight must be a positive integer.");
                }
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
                pathWeightTextBox.Text = weightofEachPath[pIGindex].ToString();
                useOnceCheckBox.Checked = useOnceList[pIGindex];
                if (pathsInPathGroupListBox.SelectedIndex == -1 || !pathsInPathGroupListBox.SelectedValue.ToString().Equals(tierPathsListBox.SelectedValue.ToString()));
                { 
                    pathsInPathGroupListBox.SelectedIndex = pathsInGroup.IndexOf((String)tierPathsListBox.SelectedValue);
                }
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
                scope = 0;
                currHub = "";
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
                    currHub = hubComboBox.SelectedText;
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
            }
        }

        private void playerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (playerRadioButton.Enabled)
            {
                scope = 2;
                currHub = "";
                setAttributeComboBox();
            }
        }
        private void setAttributeComboBox()
        {
            attributeComboBox.DataSource = Attributes.getScope(scope, currHub);

        }

        private void hubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hubComboBox.SelectedIndex > 0)
            {
                setAttributeComboBox();
            }
        }
    }
}
