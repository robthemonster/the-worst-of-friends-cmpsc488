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
    public partial class ProjectHomeForm : Form
    {

        public Attribs attributes;
        //public List<NPC> characters;
        //public Dictionary<String,Path> paths;
        public List<Hub> hubs;
        //public List<PathGroup> pathGroups;
        //public List<P2PG> p2PG;
        public Dictionary<String, Navigable> navIndex;
        public String navigableName;

        public int screenID;
        //1 = Path, 2 = Path Group, 3 = Hub
        

        public ProjectHomeForm()
        {
            
            InitializeComponent();

            //paths = new Dictionary<string, Path>();
            navIndex = new Dictionary<string, Navigable>();
            attributes = new Attribs();
            attributes.names = new List<string> {"Health","Strength","Agility","Charisma","Evil","Unrest"};
            attributes.scopes = new List<int> { 0,0,0,0,2,2};


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
        public void saveToFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, attributes);
            stream.Close();

        }

        public void createNavigable()
        {
            CreatePathGroupForm PathGroup = new CreatePathGroupForm(this);
            PathGroup.ShowDialog();

            switch (screenID)
            {

                case 1:
                    EditPathForm editPath = new EditPathForm(this, navigableName);
                    editPath.ShowDialog();
                    break;
                case 2:
                    EditPathGroupForm editPathGroup = new EditPathGroupForm(navigableName);
                    editPathGroup.ShowDialog();
                    break;
                case 3:
                    EditHubForm editHub = new EditHubForm(navigableName);
                    editHub.ShowDialog();
                    break;
            }


        }
    }
}
