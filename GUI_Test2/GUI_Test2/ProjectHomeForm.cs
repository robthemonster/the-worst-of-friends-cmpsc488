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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GUI_Test2
{
    public partial class ProjectHomeForm : Form
    {



        public int screenID;
        //1 = Path, 2 = Path Group, 3 = Hub

        public string fileLocation = "";

        public ProjectHomeForm()
        {
            InitializeComponent();
            updateListBoxes();
        }

        private void ProjectHub_Load(object sender, EventArgs e)
        {
            this.Text = "(Unsaved Project) - FireSide Toolkit";
            selectedNavImage.Image = GUI_Test2.Properties.Resources.NoNavigableSelected;
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mess = "Any unsaved material will be removed. \nAre you sure you wish to continue?";
            string cap = "New Project";
            var alert = MessageBox.Show(mess, cap, MessageBoxButtons.YesNo);

            if (alert == DialogResult.Yes)
            {
                Project project = new Project();
                Game.loadFromProject(project);
                Game.savePath = "";
                Game.compileTo = "";
                /*Game.navIndex = new Dictionary<String, Navigable>();
                //attributes = new Attribs();
                Game.paths = new List<String>();
                Game.pathGroups = new List<String>();
                Game.hubs = new List<String>();
                Attributes.attribs = new List<Attrib>();

                Game.characters = new List<NPC>();
                */
                fileLocation = "";
                setWindowTitle(fileLocation);
                updateListBoxes();
            }
        }
        private void setWindowTitle(String fileLocation)
        {
            if (!fileLocation.Equals(null))
            {
                if (fileLocation.Equals(""))
                {
                    this.Text = "(Unsaved Project) - FireSide Toolkit";
                }
                else
                {
                    char[] name = System.IO.Path.GetFileNameWithoutExtension(fileLocation).ToCharArray();
                    name[0] = char.ToUpper(name[0]);
                    this.Text = new String(name) + " - FireSide Toolkit";
                }
            }
        }

        //deserialize
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "FireSide Project (*.fsp)| *.fsp";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fileLocation = fd.FileName;
                openFile(fileLocation);
                setWindowTitle(fileLocation);
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "FireSide Project (*.fsp)| *.fsp";
            sd.AddExtension = true;
            if (sd.ShowDialog() == DialogResult.OK)
            {

                fileLocation = sd.FileName;
                saveToolStripMenuItem_Click(sender, e);
                setWindowTitle(fileLocation);
            }



        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileLocation != "")
            {
                //Game.init(pathGroups, hubs, navIndex, navigableName, paths);
                Game.savePath = fileLocation;
                Game.compileTo = Directory.GetParent(fileLocation).FullName + "\\" + System.IO.Path.GetFileNameWithoutExtension(fileLocation);
                Project proj = new Project(Game.pathGroups, Game.hubs, Game.navIndex, Game.paths, Attributes.attribs, Game.characters, Game.endingGen, Game.gameSettings);
                saveToFile(proj, fileLocation);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCharactersForm ec = new EditCharactersForm(this);
            ec.ShowDialog();
        }


        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            screenID = 1;

            createNavigable();
        }


        private void pathGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            screenID = 2;

            createNavigable();
        }

        private void hubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            screenID = 3;

            createNavigable();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save before exit?", "Exiting FireSide", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Cancel)
            {
                if (e.GetType() == typeof(FormClosingEventArgs))
                    ((FormClosingEventArgs)e).Cancel = true;
                return;
            }
            else if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
                return;
            }
            else if (result == DialogResult.No)
            {
                
                return;
            }
        }

        private void updateListBoxes(object sender, EventArgs e)
        {
            updateListBoxes();
        }
        public void updateListBoxes()
        {
            pathListBox.DataSource = null;
            pathListBox.DataSource = Game.paths;
            pathListBox.SelectedIndex = -1;

            pathGroupListBox.DataSource = null;
            pathGroupListBox.DataSource = Game.pathGroups;
            pathGroupListBox.SelectedIndex = -1;

            hubListBox.DataSource = null;
            hubListBox.DataSource = Game.hubs;
            hubListBox.SelectedIndex = -1;
        }
        public void LoadPathFromPathListBox(object sender, EventArgs e)
        {
            if (pathListBox.SelectedIndex != -1)
            {
                string sampString = (string)pathListBox.SelectedValue;
                EditPathForm editPath = new EditPathForm(this, (Path)Game.navIndex[sampString]);
                editPath.ShowDialog();
            }
        }
        public void LoadPathGroupFromPathListBox(object sender, EventArgs e)
        {
            if (pathGroupListBox.SelectedIndex != -1)
            {
                string navName = (string)pathGroupListBox.SelectedValue;
                EditPathGroupForm editPathGroup = new EditPathGroupForm(this, (PathGroup)Game.navIndex[navName]);
                editPathGroup.ShowDialog();
            }
        }
        public void LoadHubFromListBox(object sender, EventArgs e)
        {
            if (hubListBox.SelectedIndex != -1)
            {
                string navName = (string)hubListBox.SelectedValue;
                EditHubForm editHub = new EditHubForm(this, (Hub)Game.navIndex[navName]);
                editHub.ShowDialog();
            }
        }

        //Serialization
        public void saveToFile(Project proj, string fileName)
        {
            var stream = File.Open(fileName, FileMode.Create);

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, proj);

            stream.Flush();
            stream.Close();

        }


        public void openFile(string fileName)
        {
            if (fileName != "")
            {

                //Deserialization


                Project proj;
                IFormatter formatter = new BinaryFormatter();
                var stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

                proj = (Project)formatter.Deserialize(stream);


                stream.Close();

                //Load the GameObject
                Game.savePath = fileName;
                Game.loadFromProject(proj);
                

                /* Game.pathGroups = (List<String>)proj.pathGroups;
                 Game.hubs = (List<String>)proj.hubs;
                 Game.navIndex = (Dictionary<String, Navigable>)proj.navIndex;

                 Game.paths = (List<String>)proj.paths;
                 Attributes.attribs = (List<Attrib>)proj.attribs;
                 Game.characters = (proj.characters);
                 Game.gameSettings = proj.gameSettings;
                 Game.endingGen = proj.endingGen;*/
                //Game.init(pathGroups, hubs, navIndex, navigableName, paths);

                updateListBoxes();
            }

        }

        public void createNavigable()
        {
            CreateNavigableForm navigable = new CreateNavigableForm(this);
            navigable.ShowDialog();

            switch (screenID)
            {

                case 1:
                    EditPathForm editPath = new EditPathForm(this, navigable.navigableName);
                    editPath.ShowDialog();
                    break;
                case 2:
                    EditPathGroupForm editPathGroup = new EditPathGroupForm(this, navigable.navigableName);
                    editPathGroup.ShowDialog();
                    break;
                case 3:
                    EditHubForm editHub = new EditHubForm(this, navigable.navigableName);
                    editHub.ShowDialog();
                    break;
            }
            updateListBoxes();
            screenID = -1;


        }
       

        private void pathListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pathGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pathGroupListBox.SelectedIndex != -1)
            {
                hubListBox.SelectedIndex = -1;
                pathListBox.SelectedIndex = -1;
                selectedNavImage.Image = GUI_Test2.Properties.Resources.PathGroup;
                PathGroup selected = (PathGroup)Game.navIndex[Game.pathGroups[pathGroupListBox.SelectedIndex]];

                navInfo.Text = selected.name + "\n";
                navInfo.Text += selected.pathsInGroup.Count + " Navigables in group \n";

            }
            else if (pathListBox.SelectedIndex == -1 && hubListBox.SelectedIndex == -1)
            {
                selectedNavImage.ImageLocation = null;
                selectedNavImage.Image = GUI_Test2.Properties.Resources.NoNavigableSelected;
                navInfo.Text = "";
            }
        }

        private void attributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefineAttributeForm daf = new DefineAttributeForm();
            daf.ShowDialog();
        }

        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCharactersForm ecf = new EditCharactersForm(this);
            ecf.ShowDialog();
        }

        private void hubListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hubListBox.SelectedIndex != -1)
            {
                pathGroupListBox.SelectedIndex = -1;
                pathListBox.SelectedIndex = -1;
                selectedNavImage.ImageLocation = Game.navIndex[Game.hubs[hubListBox.SelectedIndex]].getImagePath();
                if (selectedNavImage.ImageLocation == "")
                    selectedNavImage.Image = GUI_Test2.Properties.Resources.defaultHub;
                Hub selected = (Hub)Game.navIndex[Game.hubs[hubListBox.SelectedIndex]];
                navInfo.Text = selected.name + "\n";
                int buttonsCtr = 1;
                foreach (Button button in selected.buttons)
                {
                    navInfo.Text += "Button " + buttonsCtr + " -> " + button.next;
                    buttonsCtr++;  
                }
            }
            else if (pathGroupListBox.SelectedIndex == -1 && pathListBox.SelectedIndex == -1)
            {
                selectedNavImage.ImageLocation = null;
                selectedNavImage.Image = GUI_Test2.Properties.Resources.NoNavigableSelected;
                navInfo.Text = "";
            }
        }

        private void pathListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (pathListBox.SelectedIndex != -1)
            {
                hubListBox.SelectedIndex = -1;
                pathGroupListBox.SelectedIndex = -1;
                selectedNavImage.ImageLocation = Game.navIndex[Game.paths[pathListBox.SelectedIndex]].getImagePath();
                if (selectedNavImage.ImageLocation == "")
                    selectedNavImage.Image = GUI_Test2.Properties.Resources.defaultPath;
                Path selected = (Path)Game.navIndex[Game.paths[pathListBox.SelectedIndex]];
                navInfo.Text = selected.name + "\n";

                navInfo.Text += selected.dialogues.Count + " dialogues" + '\n';
                int buttonsCtr = 1;
                foreach (Button button in selected.buttons)
                {
                    navInfo.Text += "Button " + buttonsCtr + " -> " + button.next + '\n';
                    buttonsCtr++;
                }
                if (selected.defaultTargetNavigable != "")
                    navInfo.Text += "Default Target -> " + selected.defaultTargetNavigable + "\n";
            }else if (pathGroupListBox.SelectedIndex == -1 && hubListBox.SelectedIndex == -1)
            {
                selectedNavImage.ImageLocation = null;
                selectedNavImage.Image = GUI_Test2.Properties.Resources.NoNavigableSelected;
                navInfo.Text = "";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = -1;
            string n = "";
            if (hubListBox.SelectedIndex != -1)
            {
                index = hubListBox.SelectedIndex;
                n = Game.hubs[index];
                Game.hubs.RemoveAt(index);
                if (index == Game.hubs.Count)
                {
                    index = index - 1;
                }
                updateListBoxes();
                hubListBox.SelectedIndex = index;
            }
            else if (pathGroupListBox.SelectedIndex != -1)
            {
                index = pathGroupListBox.SelectedIndex;
                n = Game.pathGroups[index];
                Game.pathGroups.RemoveAt(index);
                if (index == Game.pathGroups.Count)
                {
                    index = index - 1;
                }
                updateListBoxes();
                pathGroupListBox.SelectedIndex = index;
            }
            else if (pathListBox.SelectedIndex != -1)
            {
                index = pathListBox.SelectedIndex;
                n = Game.paths[index];
                Game.paths.RemoveAt(index);
                if (index == Game.paths.Count)
                {
                    index = index - 1;
                }
                updateListBoxes();
                pathListBox.SelectedIndex = index;
            }

            Game.navIndex.Remove(n);
        }

        private void runPlayTest_MenuItemClick(object sender, EventArgs e)
        {
            saveToolStripMenuItem.PerformClick();
            Game.compileAndRun();
        }

        private void endingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndingGenerator eg = new EndingGenerator(Game.endingGen);
            eg.ShowDialog();
        }

        private void gameSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditGameSettings gs = new EditGameSettings(Game.gameSettings);
            gs.ShowDialog();
        }

       

      
    }
}
