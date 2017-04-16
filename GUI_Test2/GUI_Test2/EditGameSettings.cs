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
        private string dialogueButtonSoundPath;
        private string dialogueScrollSound;
        private string dialogueEndSound;
        private bool musicSelected;
        private bool musicLoading;
        private string defaultFontPath;
        private string defaultDialoguePaneTexturePath;
        private string defaultDialoguePaneFlashingTexturePath;
        private string defaultDialogueEndSoundPath;
        private string SORPathGroupName;
        private string EORPathGroupName;
        private List<string> visPlayerAts;
        private List<string> visGlobalAts;
        private string SOTNav;
        private int enterTextureXLoc;
        private int enterTextureYLoc;

        public EditGameSettings()
        {
            InitializeComponent();

            gameOverReq = new List<Requirement>();
            dialogueButtonSoundPath = "";
            enterTextureXLoc = 0;
            enterTextureYLoc = 0;
        dialogueScrollSound="";
            dialogueEndSound="";

            defaultFontPath = "";
            defaultDialoguePaneFlashingTexturePath = "";
            defaultDialogueEndSoundPath = "";
            maxPlayerCountTextBox.Text = "1";
            SORPathGroupName = "";
            EORPathGroupName = "";
            SOTNav = "";


            enterTextureXLoc=0;
            enterTextureYLoc=0;

    }

        public EditGameSettings(GameSettings gS)
        {
            InitializeComponent();

            gameOverReq = gS.gameOverRequirements;
            dialogueButtonSoundPath = gS.dialogueButtonSound;
            enterTextureXLocTextBox.Text = gS.flashingTextureXLoc.ToString();
            enterTextureYLocTextBox.Text = gS.flashingTextureYLoc.ToString();

            dialogueScrollSound = gS.dialogueScrollSoundPath;
            dialogueEndSound = gS.dialogueEndSoundPath;
            defaultFontPath = gS.defaultFontPath;
            defaultDialoguePaneFlashingTexturePath = gS.dialoguePaneFlashingTexturePath;
            defaultDialogueEndSoundPath = gS.dialogueEndSoundPath;
            paneXLocTextBox.Text = gS.dialoguePanePosX.ToString() ;
            paneYLocTextBox.Text = gS.dialoguePanePosY.ToString();
            SORPathGroupName = gS.startOfRoundNav;
            EORPathGroupName = gS.endOfRoundNav;
            SOTNav = gS.startNavigable;
            maxPlayerCountTextBox.Text = gS.maxPlayers.ToString();

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
            List<string> navList = new List<string>();
            navList.AddRange(Game.hubs);
            navList.AddRange(Game.pathGroups);
            startofPlayerTurnNavigableComboBox.DataSource = navList;

            updateVisPlayerList();
            visiblePlayerAttributesListBox.SelectedIndex = -1;

            updateVisGlobalList();
            visibleGlobalAttributesListBox.SelectedIndex = -1;

            comparitorComboBox.DataSource = new string[] { "<", "<=", "==", ">=", ">" };

            hubComboBox.DataSource = Game.hubs;


            //Causing them to select the same path
            roundStartNavComboBox.DataSource = Game.pathGroups;
            roundEndNavComboBox.DataSource = Game.pathGroups;
            if (Game.hubs.Contains(SOTNav) || Game.pathGroups.Contains(SOTNav))
            {
                startofPlayerTurnNavigableComboBox.SelectedItem = SOTNav;
            }
            if (Game.pathGroups.Contains(SORPathGroupName))
            {
                roundStartNavComboBox.SelectedItem = SORPathGroupName;
            }
            if (Game.pathGroups.Contains(EORPathGroupName))
            {
                roundEndNavComboBox.SelectedItem = EORPathGroupName;
            }


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
            //missing startTurnnav,dialogueEndSoundPath, dialogueFlashingTexturePath
            /*gameOverRequirements, string defaultFontPath,string startNavigable, string startOfRoundNav, string endOfRoundNav,
            string dialogueScrollSoundPath, string dialogueEndSoundPath, string dialoguePaneTexturePath, string dialoguePaneFlashingTexturePath,
            int dialoguePanePosX, int dialoguePanePosY, int maxPlayers, MainMenu mM, List<string> visPlayerAtts, List<string>visGlobalAtts)
            */
            Game.gameSettings.visPlayerAtts = visPlayerAts;
            Game.gameSettings.visGlobalAtts = visGlobalAts;
            Game.gameSettings.dialoguePaneTexturePath = defaultDialoguePaneTexturePath;
            Game.gameSettings.dialoguePaneFlashingTexturePath = defaultDialoguePaneFlashingTexturePath;

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
            int x, y, x1, y1;
            try {
                x = Int32.Parse(this.paneXLocTextBox.Text);
                y = Int32.Parse(this.paneYLocTextBox.Text);
                x1 = Int32.Parse(this.enterTextureXLocTextBox.Text);
                y1 = Int32.Parse(this.enterTextureYLocTextBox.Text);
                Game.gameSettings.dialoguePanePosX = x;
                Game.gameSettings.dialoguePanePosY = y;
                Game.gameSettings.flashingTextureXLoc = x1;
                Game.gameSettings.flashingTextureYLoc = y1;
            }
            catch (FormatException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
                MessageBox.Show("X and Y must be positive numbers.\n" +
                    "X must be less than 960.\n" +
                    "Y must be less than 540.");
                paneXLocTextBox.Text = "";
                paneYLocTextBox.Text = "";
                return;
            }

            if (Math.Abs(x) > 960)
            {
                MessageBox.Show("X coordinate must be between -960 and 960.");
                paneXLocTextBox.Text = "";
                return;
            }
            if (Math.Abs(y) > 540)
            {
                MessageBox.Show("Y coordinate must be between -540 and 540.");
                paneYLocTextBox.Text = "";
                return;
            }
            if (dialogueButtonSoundPath != "")
            {
                Game.gameSettings.dialogueButtonSound = dialogueButtonSoundPath;
            }
            if (dialogueEndSound != "")
            {
                Game.gameSettings.dialogueEndSoundPath = dialogueEndSound;
            }
            if (dialogueScrollSound != "") {
                Game.gameSettings.dialogueScrollSoundPath = dialogueScrollSound;
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

            string turnStartNav;
            if (this.startofPlayerTurnNavigableComboBox.SelectedIndex != -1)
            {
                turnStartNav = (string)this.startofPlayerTurnNavigableComboBox.SelectedItem;
                Game.gameSettings.startNavigable = turnStartNav;
            }
            else
            {
                MessageBox.Show("You Must Make a Path or Hub before you can run the project.", "Cannot Save Settings", MessageBoxButtons.OK);
            }



            
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
                            dialogueButtonSoundPath = of.FileName;
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
                    dialogueScrollSound = of.FileName;
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
                    defaultDialoguePaneTexturePath = of.FileName;
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

        private void chooseDialogueEndSoundButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Audio files (*.ogg) | *.ogg";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    dialogueEndSound = of.FileName;
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void chooseEnterKeyTextureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                   defaultDialoguePaneFlashingTexturePath  = of.FileName;
                }

            }
            catch (IndexOutOfRangeException)
            {

            }
        }
    }
}
