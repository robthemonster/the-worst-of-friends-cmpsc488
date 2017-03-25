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
        public List<List<PathCondition>> pathConds;
        public List<String> pathsInGroup;
        public List<int> weights;
        public List<int> tiers;
        public int[] tier;
        public List<String> pnipg;
        public List<String> currentTier;
        private bool justUpdated;


        public EditPathGroupForm(ProjectHomeForm par, String nam)
        {
            InitializeComponent();
            name = nam;
            parentForm = par;
            pathConds = new List<List<PathCondition>>();
            pathsInGroup = new List<String>();
            weights = new List<int>();
            tiers = new List<int>();
            
        }

        public EditPathGroupForm(ProjectHomeForm par, PathGroup pg) {
            InitializeComponent();
            name = pg.name;
            parentForm = par;
            pathConds = pg.pathConds;
            pathsInGroup = pg.pathsInGroup;
            weights = pg.weights;
            tiers = pg.tiers;
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
            justUpdated = false;

            updateLists();
            


        }

        private void removeSelectedPathsFromPathGroup_Click(object sender, EventArgs e)
        {

        }

        private void pathsNotInPathGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updateLists()
        {
            if (!justUpdated)
            {
                pathsInPathGroupListBox.DataSource = null;
                pathsInPathGroupListBox.DataSource = pathsInGroup;
                pathsInPathGroupListBox.SelectedIndex = -1;
                justUpdated = true;

                pnipg = new List<string>();
                foreach (String p in parentForm.paths)
                {
                    if (!pathsInGroup.Contains(p))
                        pnipg.Add(p);
                }
                pathsNotInPathGroupListBox.DataSource = null;
                pathsNotInPathGroupListBox.DataSource = pnipg;
                pathsNotInPathGroupListBox.SelectedIndex = -1;
            }


            currentTier = new List<string>();
            for (int i=0; i<pathsInGroup.Count;++i) {
                if (tiers[i] == tierComboBox.SelectedIndex)
                    currentTier.Add(pathsInGroup[i]);
            }
            tierPathsListBox.DataSource = null;
            tierPathsListBox.DataSource = currentTier;
            tierPathsListBox.SelectedIndex = -1;

            int tempTierWeight = 0;
            foreach (String p in currentTier) {
                tempTierWeight += weights[pathsInGroup.IndexOf(p)];
            }
            tierWeightTextBox.Text = tempTierWeight.ToString() ;


        }

        private void addPathsButton_Click(object sender, EventArgs e)
        {
            foreach (int i in pathsNotInPathGroupListBox.SelectedIndices) {
                pathsInGroup.Add(pnipg[i]);
                tiers.Add(tierComboBox.SelectedIndex);
                weights.Add(Int32.Parse(pathWeightTextBox.Text));
                

            }
            justUpdated = false;
            updateLists();
        }
        

        private void removePathsButton_Click(object sender, EventArgs e)
        {
            int i = pathsInPathGroupListBox.SelectedIndex;
            if (i != -1) {
                pathsInGroup.RemoveAt(i);
                tiers.RemoveAt(i);
                weights.RemoveAt(i);

            }
            justUpdated = false;
            updateLists();
        }

        private void editTierPathButton_Click(object sender, EventArgs e)
        {
            if (tierPathsListBox.SelectedIndex != -1) {
                weights[pathsInGroup.IndexOf((String)tierPathsListBox.SelectedItem)] = Int32.Parse(pathWeightTextBox.Text);
                updateLists();
            }
        }

        private void pathsInPathGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pathsInPathGroupListBox.SelectedIndex != -1)
            {
                pathsNotInPathGroupListBox.SelectedIndex = -1;
                int index = pathsInPathGroupListBox.SelectedIndex;
                tierComboBox.SelectedIndex = tiers[index];
                pathWeightTextBox.Text = weights[index].ToString();
                tierPathsListBox.SelectedIndex = ((List<String>)tierPathsListBox.DataSource).IndexOf(pathsInGroup[index]);
            }
        }

        private void tierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLists();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (!parentForm.pathGroups.Contains(name))
            {
                parentForm.pathGroups.Add(name);
                parentForm.navIndex.Add(name, new PathGroup(name, pathsInGroup, weights, tiers));
            }
            else
                parentForm.navIndex[name] = new PathGroup(name, pathsInGroup, weights, tiers);
            Close();
        }

        private void tierPathsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tierPathsListBox.SelectedIndex!=-1)
                pathWeightTextBox.Text = weights[pathsInGroup.IndexOf((String)tierPathsListBox.SelectedItem)].ToString();
        }

        private void pathsNotInPathGroupListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(pathsNotInPathGroupListBox.SelectedIndex!=-1)
                pathsInPathGroupListBox.SelectedIndex = -1;
        }
    }
}
