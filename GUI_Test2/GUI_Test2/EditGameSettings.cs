using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_Test2
{
    public partial class EditGameSettings : Form
    {
        private int gameOverScope;
        private string currHub;
        private List<Requirement> gameOverReq;
        private string dialogueScrollSoundPath;
        private string dialogueEndSoundPath;
        private bool musicSelected;
        private bool musicLoading;
        private string defaultFontPath;
        private string dialoguePaneTexturePath;
        private string dialoguePaneFlasingTexturePath;
        private string SORPathGroupName;
        private string EORPathGroupName;
        private List<string> visPlayerAts;
        private List<string> visGlobalAts;
        private string SOTNav;
        private string mainMenuImagePath;
        private string mainMenuSoundPath;
        private string playButtonSoundPath;
        private string menuFontPath;

        public bool mainMenuSoundLoading;
        public bool mainMenuSoundSelected;
        public bool playButtonSoundLoading;
        public bool playButtonSoundSelected;

        public EditGameSettings()
        {
            InitializeComponent();

            gameOverReq = new List<Requirement>();

            dialogueScrollSoundPath = "";
            dialogueEndSoundPath = "";

            defaultFontPath = "";
            dialoguePaneFlasingTexturePath = "";
            maxPlayerNumericUpDown.Value = 1;
            SORPathGroupName = "";
            EORPathGroupName = "";
            SOTNav = "";


            mainMenuImagePath = "";
            mainMenuSoundPath = "";
            playButtonSoundPath = "";
            menuFontPath = "";

        }

        public EditGameSettings(GameSettings gS)
        {
            InitializeComponent();

            gameOverReq = new List<Requirement>(gS.gameOverRequirements);
            enterTextureXLocNumericUpDown.Value = gS.flashingTextureXLoc;
            enterTextureYLocNumericUpDown.Value = gS.flashingTextureYLoc;

            if (File.Exists(gS.dialogueScrollSoundPath))
            {
                dialogueScrollSoundPath = gS.dialogueScrollSoundPath;
                chooseScrollSoundVerify.Image = GUI_Test2.Properties.Resources.check;
            }
            else { dialogueScrollSoundPath = "";
                chooseScrollSoundVerify.Image = GUI_Test2.Properties.Resources.redx;
            }

            if (File.Exists(gS.dialogueEndSoundPath))
            {
                dialogueEndSoundPath = gS.dialogueEndSoundPath;
            }
            else { dialogueEndSoundPath = ""; }

            if (File.Exists(gS.defaultFontPath))
            {
                defaultFontPath = gS.defaultFontPath;
            }
            else { defaultFontPath = ""; }

            if (File.Exists(gS.dialoguePaneTexturePath))
            {
                dialoguePaneTexturePath = gS.dialoguePaneTexturePath;
            }
            else { dialoguePaneTexturePath = ""; }

            if (File.Exists(gS.dialoguePaneFlashingTexturePath))
            {
                dialoguePaneFlasingTexturePath = gS.dialoguePaneFlashingTexturePath;
            }
            else { dialoguePaneFlasingTexturePath = ""; }
            paneXLocNumericUpDown.Value = gS.dialoguePanePosX;
            paneYLocNumericUpDown.Value = gS.dialoguePanePosY;
            NPCXLocNumericUpDown.Value = gS.NPCXLoc;
            NPCYLocNumericUpDown.Value = gS.NPCYLoc;
            SORPathGroupName = gS.startOfRoundNav;
            EORPathGroupName = gS.endOfRoundNav;
            SOTNav = gS.startNavigable;
            maxPlayerNumericUpDown.Value = gS.maxPlayers;

            visPlayerAts = gS.visPlayerAtts;
            visGlobalAts = gS.visGlobalAtts;

            mainMenuImagePath = gS.mainMenu.mainMenuImagePath;
            mainMenuSoundPath = gS.mainMenu.mainMenuSoundPath;
            playButtonSoundPath = gS.mainMenu.playButtonSoundPath;
            menuFontPath = gS.mainMenu.fontImagePath;
        }

        private void EditGameSettings_Load(object sender, EventArgs e)
        {
            gameOverScope = 0;
            currHub = "";
            musicSelected = false;
            musicLoading = false;



            playerAttributesComboBox.DataSource = GUI_Test2.Attributes.getScope(2, currHub);
            globalAttributesComboBox.DataSource = GUI_Test2.Attributes.getScope(0, currHub);

            List<string> navList = new List<string>();
            navList.AddRange(Game.hubs);
            navList.AddRange(Game.pathGroups);
            navList.AddRange(Game.paths);
            startofPlayerTurnNavigableComboBox.DataSource = navList;
            updateVisPlayerList();
            visiblePlayerAttributesListBox.SelectedIndex = -1;

            updateVisGlobalList();
            visibleGlobalAttributesListBox.SelectedIndex = -1;

            updateGameOver();

            comparitorComboBox.DataSource = new string[] { "<", "<=", "==", ">=", ">" };

            hubComboBox.DataSource = Game.hubs;


            //Causing them to select the same path
            roundStartNavComboBox.DataSource = new List<string>(Game.pathGroups);
            roundEndNavComboBox.DataSource = new List<string>(Game.pathGroups);
            startofPlayerTurnNavigableComboBox.SelectedItem = SOTNav;
            roundStartNavComboBox.SelectedItem = SORPathGroupName;
            roundEndNavComboBox.SelectedItem = EORPathGroupName;


            GOGlobalRadioButton.Checked = true;

            mainMenuSoundSelected = false;
            mainMenuSoundLoading = false;
            playButtonSoundLoading = false;
            playButtonSoundSelected = false;

            if (mainMenuSoundPath != "")
            {
                useMenuMusicCheckBox.CheckedChanged -= useBackgroundSoundCheckBox_CheckedChanged;
                useMenuMusicCheckBox.Checked = true;
                useMenuMusicCheckBox.CheckedChanged += useBackgroundSoundCheckBox_CheckedChanged;
            }

            if (playButtonSoundPath != "")
            {
                usePlayButtonSoundCheckBox.CheckedChanged -= usePlayButtonSoundCheckBox_CheckedChanged;
                usePlayButtonSoundCheckBox.Checked = true;
                usePlayButtonSoundCheckBox.CheckedChanged += usePlayButtonSoundCheckBox_CheckedChanged;

            }

            

            updateCheckMarks();
            mainMenuImagePictureBox.ImageLocation = mainMenuImagePath;
        }

        private void setAttributeComboBox()
        {
            attributeComboBox.DataSource = GUI_Test2.Attributes.getScope(gameOverScope, currHub);
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
            Game.gameSettings.dialoguePaneTexturePath = dialoguePaneTexturePath;
            Game.gameSettings.dialoguePaneFlashingTexturePath = dialoguePaneFlasingTexturePath;


            Game.gameSettings.maxPlayers = (int)maxPlayerNumericUpDown.Value;

            Game.gameSettings.dialoguePanePosX = (int)paneXLocNumericUpDown.Value;
            Game.gameSettings.dialoguePanePosY = (int)this.paneYLocNumericUpDown.Value;
            Game.gameSettings.flashingTextureXLoc = (int)this.enterTextureXLocNumericUpDown.Value;
            Game.gameSettings.flashingTextureYLoc = (int)this.enterTextureYLocNumericUpDown.Value;
            Game.gameSettings.NPCXLoc = (int)this.NPCXLocNumericUpDown.Value;
            Game.gameSettings.NPCYLoc = (int)this.NPCYLocNumericUpDown.Value;


            if (dialogueEndSoundPath != "")
            {
                Game.gameSettings.dialogueEndSoundPath = dialogueEndSoundPath;
            }
            if (dialogueScrollSoundPath != "")
            {
                Game.gameSettings.dialogueScrollSoundPath = dialogueScrollSoundPath;
            }

            if (this.roundEndNavComboBox.SelectedIndex != -1)
            {
                Game.gameSettings.endOfRoundNav = (string)this.roundEndNavComboBox.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please Select a Navigable to End Each Round of the Game.", "Cannot Save Settings", MessageBoxButtons.OK);
                return;
            }


            if (this.roundStartNavComboBox.SelectedIndex != -1)
            {
                Game.gameSettings.startOfRoundNav = (string)this.roundStartNavComboBox.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please Select a Navigable to Begin Each Round of the Game.", "Cannot Save Settings", MessageBoxButtons.OK);
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
                MessageBox.Show("Please Select a Navigable for the Start of a Player's Turn.", "Cannot Save Settings", MessageBoxButtons.OK);
                return;
            }

            if (gameOverReq.Count > 0)
            {
                Game.gameSettings.gameOverRequirements = new List<Requirement>(gameOverReq);
            }
            else
            {
                MessageBox.Show("You must set Game Over requirements.", "Cannot Save Settings", MessageBoxButtons.OK);
                return;
            }

            Game.gameSettings.defaultFontPath = defaultFontPath;
            Game.gameSettings.mainMenu = new MainMenu(mainMenuImagePath, mainMenuSoundPath, playButtonSoundPath, menuFontPath);

            this.Close();
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


        private void GameOverReqsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameOverReqsListBox.SelectedIndex != -1)
            {
                Requirement r = gameOverReq[GameOverReqsListBox.SelectedIndex];
                if (r != null)
                {
                    switch (r.scope)
                    {
                        case 0:
                            GOGlobalRadioButton.Checked = true;
                            break;
                        case 1:
                            GOHubRadioButton.Checked = true;
                            hubComboBox.SelectedIndex = hubComboBox.FindStringExact(r.hub);
                            break;
                        case 2:
                            GOPlayerRadioButton.Checked = true;
                            break;
                    }
                    if (r.hub != "")
                    {
                        try
                        {
                            hubComboBox.SelectedIndex = Game.hubs.IndexOf(r.hub);
                        }catch(ArgumentOutOfRangeException ex)
                        {
                            Console.Out.WriteLine(ex.StackTrace);
                        }
                        }
                    attributeComboBox.SelectedIndex = attributeComboBox.FindStringExact(r.name);
                    comparitorComboBox.SelectedIndex = comparitorComboBox.FindStringExact(r.comp);
                    valueUpDown.Value = r.value;
                }
            }

        }
        private void updateGameOver()
        {
            List<string> GORs = new List<string>();
            foreach (Requirement r in gameOverReq)
            {
                GORs.Add(r.name);
            }
            GameOverReqsListBox.DataSource = null;
            GameOverReqsListBox.DataSource = GORs;
            GameOverReqsListBox.SelectedIndex = -1;
        }

        private void addRequirementButton_Click(object sender, EventArgs e)
        {
            if (attributeComboBox.SelectedIndex != -1 && ((gameOverScope == 0 || gameOverScope == 2) || hubComboBox.SelectedIndex != -1))
            {

                int value = (int)valueUpDown.Value;
                if (gameOverScope == 0 || gameOverScope == 2)
                {
                    gameOverReq.Add(new Requirement(gameOverScope, "", attributeComboBox.SelectedValue.ToString(), comparitorComboBox.SelectedValue.ToString(), value));
                }
                else
                {
                    gameOverReq.Add(new Requirement(gameOverScope, hubComboBox.SelectedValue.ToString(), attributeComboBox.SelectedValue.ToString(), comparitorComboBox.SelectedValue.ToString(), value));
                }
                updateGameOver();
                GameOverReqsListBox.SelectedIndex = gameOverReq.Count - 1;
            }
        }

        private void removeRequirementButton_Click(object sender, EventArgs e)
        {
            if (GameOverReqsListBox.SelectedIndex != -1)
            {
                int index = GameOverReqsListBox.SelectedIndex;
                gameOverReq.RemoveAt(index);
                if (index == gameOverReq.Count)
                {
                    --index;
                }
                updateGameOver();
                GameOverReqsListBox.SelectedIndex = index;
            }
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
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
            updateCheckMarks();
        }



        private void hubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hubComboBox.SelectedIndex != -1)
            {
                GOPlayerRadioButton.Checked = true;
                GOHubRadioButton.Checked = true;
                attributeComboBox.DataSource = GUI_Test2.Attributes.getScope(1, currHub);
            }
        }

        private void chooseScrollSoundButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Audio files (*.ogg, *.wav, *.flac, *.aiff) | *.ogg; *.wav; *.flac; *.aiff";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    dialogueScrollSoundPath = of.FileName;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
                
            }
            updateCheckMarks();

        }

        private void defaultDialoguePaneTextureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    dialoguePaneTexturePath = of.FileName;
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
            updateCheckMarks();
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
            if (visiblePlayerAttributesListBox.SelectedIndex != -1)
            {
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
            of.Filter = "Audio files (*.ogg, *.wav, *.flac, *.aiff) | *.ogg; *.wav; *.flac; *.aiff";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    dialogueEndSoundPath = of.FileName;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
            updateCheckMarks();
        }

        private void chooseEnterKeyTextureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    dialoguePaneFlasingTexturePath = of.FileName;
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
            updateCheckMarks();
        }

        private void selectMainMenuImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            of.ShowDialog();
            try
            {
                mainMenuImagePictureBox.Image = Image.FromStream(of.OpenFile());
                mainMenuImagePath = of.FileName;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
        }

        private void useBackgroundSoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useMenuMusicCheckBox.Checked)
            {
                if (!mainMenuSoundLoading)
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.Filter = "Audio files (*.ogg, *.wav, *.flac, *.aiff) | *.ogg; *.wav; *.flac; *.aiff";

                    try
                    {
                        if (DialogResult.OK == of.ShowDialog())
                        {
                            mainMenuSoundPath = of.FileName;
                            mainMenuSoundSelected = true;
                        }
                        else
                        {
                            mainMenuSoundSelected = false;
                        }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.Out.WriteLine(ex.StackTrace);
                    }
                    if (!mainMenuSoundSelected)
                    {
                        mainMenuSoundLoading = true;
                        useMenuMusicCheckBox.Checked = false;
                        mainMenuSoundLoading = false;
                    }
                }
            }
            else
            {
                mainMenuSoundSelected = false;
                mainMenuSoundPath = "";
            }
        }

        private void usePlayButtonSoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (usePlayButtonSoundCheckBox.Checked)
            {
                if (!playButtonSoundLoading)
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.Filter = "Audio files (*.ogg, *.wav, *.flac, *.aiff) | *.ogg; *.wav; *.flac; *.aiff";

                    try
                    {
                        if (DialogResult.OK == of.ShowDialog())
                        {
                            playButtonSoundPath = of.FileName;
                            playButtonSoundSelected = true;
                        }
                        else
                        {
                            playButtonSoundSelected = false;
                        }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.Out.WriteLine(ex.StackTrace);
                    }
                    if (!playButtonSoundSelected)
                    {
                        playButtonSoundLoading = true;
                        usePlayButtonSoundCheckBox.Checked = false;
                        playButtonSoundLoading = false;
                    }
                }
            }
            else
            {
                playButtonSoundSelected = false;
                playButtonSoundPath = "";
            }
        }

        private void chooseFontImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Font files (*.otf, *.ttf) | *.otf; *.ttf;";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    menuFontPath = of.FileName;
                    
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
            updateCheckMarks();

        }

        private void updateCheckMarks()
        {
            if (File.Exists(dialogueScrollSoundPath))
            {
                chooseScrollSoundVerify.Image = GUI_Test2.Properties.Resources.check;
            }else
            {
                chooseScrollSoundVerify.Image = GUI_Test2.Properties.Resources.redx;
            }
            if (File.Exists(dialogueEndSoundPath))
            {
                chooseDialogueEndSoundVerify.Image = GUI_Test2.Properties.Resources.check;
            }
            else
            {
                chooseDialogueEndSoundVerify.Image = GUI_Test2.Properties.Resources.redx;
            }
            if (File.Exists(dialoguePaneTexturePath))
            {
                chooseDialoguePaneVerify.Image = GUI_Test2.Properties.Resources.check;
            }
            else
            {
                chooseDialoguePaneVerify.Image = GUI_Test2.Properties.Resources.redx;
            }
            if (File.Exists(dialoguePaneFlasingTexturePath))
            {
                chooseEnterTextureVerify.Image = GUI_Test2.Properties.Resources.check;
            }
            else
            {
                chooseEnterTextureVerify.Image = GUI_Test2.Properties.Resources.redx;
            }
            if (File.Exists(defaultFontPath))
            {
                chooseDialogueFontVerify.Image = GUI_Test2.Properties.Resources.check;
            }
            else
            {
                chooseDialogueFontVerify.Image = GUI_Test2.Properties.Resources.redx;
            }
            if (File.Exists(menuFontPath))
            {
                mainMenuFontVerify.Image = GUI_Test2.Properties.Resources.check;
            }else
            {
                mainMenuFontVerify.Image = GUI_Test2.Properties.Resources.redx;
            }
        }

        private void startofPlayerTurnNavigableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
