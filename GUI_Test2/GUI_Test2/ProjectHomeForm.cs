using System;
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
    [Serializable]
    public partial class ProjectHomeForm : Form
    {

        
        //public List<NPC> characters;
        public List<String> pathGroups;
        public List<String> hubs;
        //public List<P2PG> p2PG;
        public Dictionary<String, Navigable> navIndex;
        public String navigableName;
        public List<String> paths;

        public int screenID;
        //1 = Path, 2 = Path Group, 3 = Hub

        public string fileLocation = "";

        public ProjectHomeForm()
        {
            
            InitializeComponent();

            navIndex = new Dictionary<String, Navigable>();
            //attributes = new Attribs();
            paths = new List<String>();
            pathGroups = new List<String>();
            hubs = new List<String>();

            //attributes.names = new List<string> {"Health","Strength","Agility","Charisma","Evil","Unrest"};
            //attributes.scopes = new List<int> { 0,0,0,0,2,2};
            //attributes.values = new List<int> { 20, 4, 2, 19, 0, 69 };

            updateListBoxes();
        }

        private void ProjectHub_Load(object sender, EventArgs e)
        {
            
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mess = "Any unsaved material will be removed. \nAre you sure you wish to continue?";
            string cap = "New Project";
            var alert = MessageBox.Show(mess, cap, MessageBoxButtons.YesNo);

            if (alert == DialogResult.Yes)
            {
                navIndex = new Dictionary<String, Navigable>();
                //attributes = new Attribs();
                paths = new List<String>();
                pathGroups = new List<String>();
                hubs = new List<String>();

                foreach (string i in Characters.getKeys())
                {
                    Characters.Remove(i);
                }

                fileLocation = "";
                updateListBoxes();
            }
        }

        //deserialize
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";

            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fileName = fd.FileName;
                fileLocation = fileName;
            }

            openFile(fileName);

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string folderPath = "";

            SaveFileDialog sd = new SaveFileDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                fileName = sd.FileName;
                fileLocation = fileName;

                //Retrieve the name of the file, create a folder based off that name,
                //place a file of the same name in the newly created directory

                fileName = System.IO.Path.GetFileNameWithoutExtension(fileName);
                //folderPath = System.IO.Path.GetDirectoryName(fileLocation);

                System.IO.Directory.CreateDirectory(fileLocation);

                fileLocation = System.IO.Path.Combine(fileLocation, fileName);
                fileName = fileLocation;
            }

            Dictionary<string, NPC> c = Characters.characters;

            Game.init(pathGroups, hubs, navIndex, navigableName, paths);
            Project proj = new Project(pathGroups, hubs, navIndex, navigableName, paths,Attributes.attribs, Characters.characters);

            saveToFile(proj, fileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileLocation != "")
            {
                Game.init(pathGroups, hubs, navIndex, navigableName, paths);
                Project proj = new Project(pathGroups, hubs, navIndex, navigableName, paths, Attributes.attribs, Characters.characters);

                saveToFile(proj, fileLocation);
            }
        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCharactersForm ec = new EditCharactersForm(this);
            ec.ShowDialog();
        }
    
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

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
        private void closeWindow(object sender, EventArgs e) {
            Close();
        }
        
        private void updateListBoxes(object sender, EventArgs e)
        {
            updateListBoxes();
        }
        public void updateListBoxes() {
            pathListBox.DataSource = null;
            pathListBox.DataSource = paths;
            pathListBox.SelectedIndex = -1;

            pathGroupListBox.DataSource = null;
            pathGroupListBox.DataSource = pathGroups;
            pathGroupListBox.SelectedIndex = -1;

            hubListBox.DataSource = null;
            hubListBox.DataSource = hubs;
            hubListBox.SelectedIndex = -1;
        }
        public void LoadPathFromPathListBox(object sender, EventArgs e) {
            if (pathListBox.SelectedIndex == -1) { }
            else
            {
                string sampString = (string)pathListBox.SelectedValue;
                Path targetPath = new Path();
                targetPath = (Path)navIndex[sampString];
                EditPathForm editPath = new EditPathForm(this, (Path)navIndex[sampString]);
                editPath.ShowDialog();
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
                pathGroups = (List<String>)proj.pathGroups;
                hubs = (List<String>)proj.hubs;
                navIndex = (Dictionary<String, Navigable>)proj.navIndex;
                navigableName = (String)proj.navigableName;
                paths = (List<String>)proj.paths;
                Attributes.attribs = (List<Attrib>)proj.attribs;
                Characters.characters = (proj.characters);
                Game.init(pathGroups, hubs, navIndex, navigableName, paths);

                updateListBoxes();
            }

        }

        public void createNavigable()
        {
            CreateNavigableForm Navigable = new CreateNavigableForm(this);
            Navigable.ShowDialog();

            switch (screenID)
            {

                case 1:
                    EditPathForm editPath = new EditPathForm(this, navigableName);
                    editPath.ShowDialog();
                    break;
                case 2:
                    EditPathGroupForm editPathGroup = new EditPathGroupForm(this, navigableName);
                    editPathGroup.ShowDialog();
                    break;
                case 3:
                    EditHubForm editHub = new EditHubForm(navigableName);
                    editHub.ShowDialog();
                    break;
            }
            updateListBoxes();
            screenID = -1;


        }
        public void makeSamplePaths(object sender, EventArgs e) {
            String[] sillyString = { "asdf", "asdf2", "asdf3", "asdf4", "asdf5", "asdf6", "asdf7", "asdf8", "asdf9", "asdf10", "asdf11" };
            foreach (String p in sillyString) {
                paths.Add(p);
                navIndex.Add(p, new Path());
            }
            updateListBoxes();
            
        }

        private void pathListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (pathListBox.SelectedIndex != -1)
                {
                    //On loading a file, a NullException happens here
                    EditPathGroupForm editPathGroup = new EditPathGroupForm(this, (PathGroup)navIndex[(String)pathGroupListBox.SelectedItem]);
                    editPathGroup.ShowDialog();
                }
            }
            catch
            {
                Console.Write("NullException unhandled in pathListBox_SelectedIndexChanged.");
            }
        }

        private void pathGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        
    }
}
