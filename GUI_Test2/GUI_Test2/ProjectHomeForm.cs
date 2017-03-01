﻿using System;
using System.Collections;
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
    public partial class ProjectHomeForm : Form
    {

        public List<Attrib> attributes;
        //public List<NPC> characters;
        //public Dictionary<String,Path> paths;
        public List<Hub> hubs;
        public List<PathGroup> pathGroups;
        public List<P2PG> p2PG;
        public Dictionary<String, Navigable> navIndex;
        public String pathName;
        public String hubName;
        public String pathGroupName;
        public ProjectHomeForm()
        {
            
            InitializeComponent();

            //paths = new Dictionary<string, Path>();
            navIndex = new Dictionary<string, Navigable>();

            updateListBoxes();
        }

        private void ProjectHub_Load(object sender, EventArgs e)
        {
            
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.ShowDialog();
        }
        

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCharactersForm ec = new EditCharactersForm();
            ec.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePathForm dialog = new CreatePathForm(this);
            dialog.ShowDialog();
            EditPathForm editPath = new EditPathForm(this, pathName);
            editPath.ShowDialog();
        }
        

        private void pathGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePathGroupForm PathGroup = new CreatePathGroupForm(this);
            PathGroup.ShowDialog();
            EditPathGroupForm editPathGroup = new EditPathGroupForm(pathGroupName);
            editPathGroup.ShowDialog();
        }

        private void hubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateHubForm createHub = new CreateHubForm(this);
            createHub.ShowDialog();
            EditHubForm editHub = new EditHubForm(hubName);

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void updateListBoxes(object sender, EventArgs e)
        {
            updateListBoxes();
        }
        public void updateListBoxes() {
            List<String> nameList;
            if (navIndex != null)
            {
                nameList = new List<String>(this.navIndex.Keys);
                pathListBox.DataSource = null;
                pathListBox.DataSource = nameList;
                pathListBox.SelectedIndex = -1;
            }
        }
        public void LoadPathFromPathListBox(object sender, EventArgs e) {
            if (pathListBox.SelectedIndex == -1)
                MessageBox.Show("Bad index on pathBoxList");
            else {
                string sampString = (string)pathListBox.SelectedValue;
                Path targetPath = new Path();
                    targetPath = (Path)navIndex[sampString];
                EditPathForm editPath = new EditPathForm(this,(Path)navIndex[sampString]);
                editPath.ShowDialog();
            }
        }
    }
}
