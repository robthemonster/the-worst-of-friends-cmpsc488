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
    public partial class EditGameSettings : Form
    {
        private int gameOverScope;
        private string currHub;
        private List<Requirement> gameOverReq;
        private string playSoundPath;
        private bool musicSelected;
        private bool musicLoading;
        private string defaultFontPath;
        private string SORPathGroupName;
        private string EORPathGroupName;
        //VV no interaction with GameObject just yet VV 
        private List<string> visPlayerAts;
        private List<string> visGlobalAts;

        public EditGameSettings()
        {
            InitializeComponent();

            gameOverReq = new List<Requirement>();
            playSoundPath = "";
            defaultFontPath = "";
            SORPathGroupName = "";
            EORPathGroupName = "";

        }

        public EditGameSettings(GameSettings gS)
        {
            InitializeComponent();

            gameOverReq = gS.gameOverRequirements;
            playSoundPath = gS.mainMenu.playButtonSoundPath;
            defaultFontPath = gS.defaultFontPath;
            SORPathGroupName = gS.startOfRoundNav;
            EORPathGroupName = gS.endOfRoundNav;
            //maxPlayerCountTextBox.Text = gS.maxPlayers;

            visPlayerAts = gS.visPlayerAtts;
            visGlobalAts = gS.visGlobalAtts;
        }

        private void EditGameSettings_Load(object sender, EventArgs e)
        {
            gameOverScope = 0;
            currHub = "";
            musicSelected = false;
            musicLoading = false;

            playerAttributesComboBox.DataSource = Attributes.getScope(2, currHub);
            globalAttributesComboBox.DataSource = Attributes.getScope(0, currHub);
            updateVisPlayerList();
            visiblePlayerAttributesListBox.SelectedIndex = -1;
            updateVisGlobalList();
            visibleGlobalAttributesListBox.SelectedIndex = -1;
            comparitorComboBox.DataSource = new string[] { "<", "<=", "==", ">=", ">" };
            hubComboBox.DataSource = Game.hubs;


            //Causing them to select the same path
            roundStartNavComboBox.DataSource = Game.pathGroups;
            roundEndNavComboBox.DataSource = Game.pathGroups;
            GOGlobalRadioButton.Checked = true;
        }

        private void setAttributeComboBox()
        {
            attributeComboBox.DataSource = Attributes.getScope(gameOverScope, currHub);
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            //missing startnav,dialogueEndSoundPath, dialogueFlashingTexturePath
            /*gameOverRequirements, string defaultFontPath,string startNavigable, string startOfRoundNav, string endOfRoundNav,
            string dialogueScrollSoundPath, string dialogueEndSoundPath, string dialoguePaneTexturePath, string dialoguePaneFlashingTexturePath,
            int dialoguePanePosX, int dialoguePanePosY, int maxPlayers, MainMenu mM, List<string> visPlayerAtts, List<string>visGlobalAtts)
            */
            Game.gameSettings.visPlayerAtts = visPlayerAts;
            Game.gameSettings.visGlobalAtts = visGlobalAts;

            int maxPlayers;
            try {
                maxPlayers = Int32.Parse(maxPlayerCountTextBox.Text);
                if (maxPlayers < 1)
                {
                    maxPlayers = 1;
                }
                Game.gameSettings.maxPlayers = maxPlayers;
            }
            catch (FormatException ex) {
                Console.Out.WriteLine(ex.StackTrace);
            }
            int x, y;
            try {
                x = Int32.Parse(this.buttonXLocTextBox.Text);
                y = Int32.Parse(this.buttonYLocTextBox.Text);
                Game.gameSettings.dialoguePanePosX = x;
                Game.gameSettings.dialoguePanePosY = y;
            }
            catch (FormatException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
                MessageBox.Show("X and Y must be positive numbers.\n" +
                    "X must be less than 960.\n" +
                    "Y must be less than 540.");
                buttonXLocTextBox.Text = "";
                buttonYLocTextBox.Text = "";
                return;
            }

            if (Math.Abs(x) > 960)
            {
                MessageBox.Show("X coordinate must be between -960 and 960.");
                buttonXLocTextBox.Text = "";
                return;
            }
            if (Math.Abs(y) > 540)
            {
                MessageBox.Show("Y coordinate must be between -540 and 540.");
                buttonYLocTextBox.Text = "";
                return;
            }
        
            
            if (playSoundPath == "") {/**/ }
            else
            {
                Game.gameSettings.dialogueScrollSoundPath = playSoundPath;
            }
            
            if (this.roundStartNavComboBox.SelectedIndex != -1)
            {
                Game.gameSettings.endOfRoundNav = (string)this.roundStartNavComboBox.SelectedItem;
            }
            else
            {
                MessageBox.Show("You Must Make a Path or Hub before you can run the project.", "Cannot Save Settings", MessageBoxButtons.OK);
                return;
            }

            
            if (this.roundStartNavComboBox.SelectedIndex != -1)
            {
                Game.gameSettings.startOfRoundNav = (string)this.roundStartNavComboBox.SelectedItem;
            }
            else
            {
                MessageBox.Show("You Must Make a Path or Hub before you can run the project.","Cannot Save Settings",MessageBoxButtons.OK);
                return;
            }





            //Game.gameSettings = new GameSettings(this.gameOverReq, this.defaultFontPath, );
        }



        private void GOGlobalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GOGlobalRadioButton.Enabled)
            {
                gameOverScope = 0;
                setAttributeComboBox();
            }
        }

        private void GOHubRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GOHubRadioButton.Checked)
            {
                gameOverScope = 1;
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

        private void GOPlayerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GOPlayerRadioButton.Enabled)
            {
                gameOverScope = 2;
                setAttributeComboBox();
            }
        }

        private void visiblePlayerAttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void visibleGlobalAttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GameOverReqsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addRequirementButton_Click(object sender, EventArgs e)
        {

        }

        private void removeRequirementButton_Click(object sender, EventArgs e)
        {

        }

        private void defaultFontButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Font files (*.otf, *.ttf) | *.otf; *.ttf;";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    defaultFontPath = of.FileName;
                }

            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void useMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (useMusic.Checked)
            {
                if (!musicLoading)
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.Filter = "Audio files (*.ogg) | *.ogg";

                    try
                    {
                        if (DialogResult.OK == of.ShowDialog())
                        {
                            playSoundPath = of.FileName;
                            musicSelected = true;
                        }
                        else
                        {
                            musicSelected = false;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                    if (!musicSelected)
                    {
                        musicLoading = true;
                        useMusic.Checked = false;
                        musicLoading = false;
                    }
                }
            }
            else
            {
                musicSelected = false;
            }
        }

        private void hubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hubComboBox.SelectedIndex != -1)
            {
                GOPlayerRadioButton.Checked = true;
                GOHubRadioButton.Checked = true;
                attributeComboBox.DataSource = Attributes.getScope(1, currHub);
            }
        }

        private void chooseScrollSoundButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Audio files (*.ogg) | *.ogg";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    playSoundPath = of.FileName;
                }
            }
            catch (IndexOutOfRangeException)
            {

            }

        }

        private void defaultDialoguePaneTextureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    defaultFontPath = of.FileName;
                }

            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void updateVisPlayerList()
        {
            visiblePlayerAttributesListBox.DataSource = null;
            visiblePlayerAttributesListBox.DataSource = visPlayerAts;
        }

        private void updateVisGlobalList()
        {
            visibleGlobalAttributesListBox.DataSource = null;
            visibleGlobalAttributesListBox.DataSource = visGlobalAts;
        }
        private void visibleGlobalList_LoseFocus(Object sender, EventArgs e)
        {
            visibleGlobalAttributesListBox.SelectedIndex = -1;
        }
        private void visiblePlayerList_LoseFocus(Object sender, EventArgs e)
        {
            visiblePlayerAttributesListBox.SelectedIndex = -1;
        }

        private void addPlayerAttributeVisibleButton_Click(object sender, EventArgs e)
        {
            if (!visPlayerAts.Contains((string)playerAttributesComboBox.SelectedItem)) 
            {
                visPlayerAts.Add((string)playerAttributesComboBox.SelectedItem);
                updateVisPlayerList();
                visiblePlayerAttributesListBox.SelectedIndex = -1;
            }
        }

        private void removePlayerAttributeVisibleButton_Click(object sender, EventArgs e)
        {
            if (visiblePlayerAttributesListBox.SelectedIndex!=-1){
                int index = visiblePlayerAttributesListBox.SelectedIndex;
                visPlayerAts.RemoveAt(index);
                if (index == visPlayerAts.Count)
                {
                    --index;
                }
                updateVisPlayerList();
                visiblePlayerAttributesListBox.SelectedIndex = index;
            }
        }
        private void addGlobalAttributeVisibleButton_Click(object sender, EventArgs e)
        {
            if (!visGlobalAts.Contains((string)globalAttributesComboBox.SelectedItem))
            {
                visGlobalAts.Add((string)globalAttributesComboBox.SelectedItem);
                updateVisGlobalList();
                visibleGlobalAttributesListBox.SelectedIndex = -1;
            }
        }

        private void removeGlobalAttributeVisibleButton_Click(object sender, EventArgs e)
        {
            if (visibleGlobalAttributesListBox.SelectedIndex != -1)
            {
                int index = visibleGlobalAttributesListBox.SelectedIndex;
                visGlobalAts.RemoveAt(index);
                if (index == visGlobalAts.Count)
                {
                    --index;
                }
                updateVisGlobalList();
                visibleGlobalAttributesListBox.SelectedIndex = index;
            }
        }
    }
}
