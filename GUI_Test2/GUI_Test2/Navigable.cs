﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Test2
{

    [Serializable]
    public abstract class Navigable
    {
      public abstract String getName();
       public abstract string getImagePath();
        public abstract string getSoundPath();
        public abstract int getNavType();
        public abstract string getButtonFont();
        public abstract int getButtonCharSize();
        public const int PATH = 0, PATHGROUP = 1, HUB = 2;
        
    }
    [Serializable]
    public class Path : Navigable {
        public string name;
        public List<String> dialogueContents;
        public List<List<Impact>> dialogueImpactList;
        public List<Button> buttons;
        public string pathSoundPath = "";
        public string pathImagePath = "";
        public string buttonFontPath = "";
        public int buttonFontCharSize;

        public override string getButtonFont()
        {
            return buttonFontPath;
        }

        public override int getButtonCharSize()
        {
            return buttonFontCharSize;
        }


        override public int  getNavType()
        {
            return Navigable.PATH;
        }

       override public string  getImagePath()
        {
            return pathImagePath;
        }
        override public string getSoundPath()
        {
            return pathSoundPath;
        }

        public Path() {}

        public Path(String n,  List<String> contents,List<Button> btns, List<List<Impact>> dIL, string pathImagePath, string pS) {
            name = n;
            dialogueContents = contents;
            dialogueImpactList=dIL;
            buttons = btns;
            pathSoundPath = pS;
            this.pathImagePath = pathImagePath;
        }

       override public String getName() { return name; }

    }

    [Serializable]
    public class Dialogue {
        public string name;
        public string content;
        public List<Impact> impacts;
    }

    [Serializable]
    public class Impact {
        public int scope;
        public string attribute;
        public string hub;
        public int op; //0 = "=", 1 = "-", 2 = "+"
        public int val;
        public const int GLOBAL = 0, HUB = 1, PLAYER = 2;
        public const int SET = 0, DECREASE = 1, INCREASE = 2;
        public override Boolean Equals(Object that)
        {
            if (that == null || GetType() != that.GetType())
                return false;
            Impact that2 = (Impact)that;
            if (this.attribute.Equals(that2.attribute) && this.hub.Equals(that2.hub))

                return true;
            return false;
        }
        public Impact(int scope, string attribute, string hub, int op, int val)
        {
            this.scope = scope;
            this.attribute = attribute;
            this.hub = hub;
            this.op = op;
            this.val = val;
        }
    }

    [Serializable]
    public class Hub : Navigable {
        public string name;
        public List<Button> buttons;
        public string hubImage;
        public string hubSound;
        public string buttonFont = "";
        public int buttonFontCharSize;

        public override int getButtonCharSize()
        {
            return buttonFontCharSize;
        }

        public override string getButtonFont()
        {
            return buttonFont;
        }

        override public String getName() { return name; }
        
       override public int getNavType()
        {
            return Navigable.HUB;
        }
      override  public string getImagePath()
        {
            return hubImage;
        }
       override  public string getSoundPath()
        {
            return hubSound;
        }

        public Hub() { }

        public Hub(string n, List<Button> b, string hI, string hS)
        {
            name = n;
            buttons = b;
            hubImage = hI;
            hubSound = hS;
        }
    }

    [Serializable]
    public class Button {
        //text,X,Y, NavRef ,Picname
        public string text;
        public int sizeX;
        public int sizeY;
        public int posX;
        public int posY;
        public string pic1path;
        public string pic2path;
        public int highlight; //2 picture, 1 text, 0 neither
        public string next;
        //img,sound

        public const int HIGHLIGHT_PICTURE = 2, HIGHLIGHT_TEXT = 1, DO_NOTHING = 0;

        public Button()
        {
            text = "";
            sizeX = 0;
            sizeY = 0;
            posX = 0;
            posY = 0;
            pic1path = "";
            pic2path = "";
            highlight = 0;
            next = "";
        }

        public Button(string t, int sX, int sY, int pX, int pY, string p1p, string p2p, int h, string n)
        {
            text = t;
            sizeX = sX;
            sizeY = sY;
            posX = pX;
            posY = pY;
            pic1path = p1p;
            pic2path = p2p;
            highlight = h;
            next = n;
        }
    }

    [Serializable]
    public class PathGroup : Navigable {
        public String name;
        public List<List<String>> pathPreReqs;
        public List<List<Requirement>> pathRequirements;
        public List<String> pathsInGroup;
        public List<int> weightsofEachPath;
        public List<int> tiersofEachPath;
        public List<Boolean> useOnce;
        //public Navigable nextDefault;
        //public Navigable getNext();

        public override string getButtonFont()
        {
            return "";
        }
        public override int getButtonCharSize()
        {
            return -1;
        }

        override public int getNavType()
        {
            return Navigable.PATHGROUP;
        }

       override public string getImagePath()
        {
            return "";
        }
       override public string getSoundPath()
        {
            return "";
        }
        override public String getName() {
            return name;
        }

        public PathGroup() { }
        public PathGroup(String n, List<String> pathsInGroup, List<int>weightsofEachPath, List<int> tiersofEachPath,List<List<Requirement>>pathRequirements, List<Boolean> useOnce)

        {
            name = n;
            this.pathsInGroup = pathsInGroup;
            this.weightsofEachPath = weightsofEachPath;
            this.tiersofEachPath = tiersofEachPath;
            this.pathRequirements = pathRequirements;
            this.useOnce = useOnce;
        }
       
    
    }

    //Attributes is its own class


    [Serializable]
    public class PathRequirements {
        public List<Requirement> requirement;
    }

    [Serializable]
    public class Requirement {
        public int value;
        public string name;
        public int scope;
        public string hub;
        public string comp;

        public const int GLOBAL = 0, HUB = 1, PLAYER = 2;


        public Requirement() { }
        public Requirement(int scope, string hub, string name, string comp,int value)
        {
            this.scope = scope;
            this.hub = hub;
            this.name = name;
            this.comp = comp;
            this.value = value;
        }
    }

    [Serializable]
    public class EndingGen
    {
        public List<List<Requirement>> reqsofEachPath;
        public List<String> pathsInGroup;
        public List<int> weightofEachPath;
        public List<int> tierofEachPath;

        public EndingGen()
        {
            reqsofEachPath = new List<List<Requirement>>();
            pathsInGroup = new List<String>();
            tierofEachPath = new List<int>();
        }

        public EndingGen(List<List<Requirement>> rOEP, List<String> pIG, List<int> tOEP)
        {
            reqsofEachPath = rOEP;
            pathsInGroup = pIG;
            tierofEachPath = tOEP;
        }
    }

    [Serializable]
    public class GameSettings
    {
        public List<Requirement> gameOverRequirements;
        
        public string defaultFontPath;
        public string startNavigable;
        public string startOfRoundNav;
        public string endOfRoundNav;
        public MainMenu mainMenu;
        public string dialogueScrollSoundPath;
        public string dialogueEndSoundPath;
        public string dialoguePaneTexturePath;
        public string dialoguePaneFlashingTexturePath;
        public int dialoguePanePosX, dialoguePanePosY;
        public int maxPlayers;
        public int flashingTextureXLoc;
        public int flashingTextureYLoc;
        public int NPCXLoc;
        public int NPCYLoc;

        public List<String> visPlayerAtts;
        public List<String> visGlobalAtts;

        public GameSettings()
        {
            gameOverRequirements = new List<Requirement>();
            defaultFontPath = "";
            startNavigable = "";
            startOfRoundNav = "";
            endOfRoundNav = "";
            dialogueScrollSoundPath = "";
            dialogueEndSoundPath = "";
            dialoguePaneTexturePath = "";
            dialoguePaneFlashingTexturePath = "";
            dialoguePanePosX = 300;
            dialoguePanePosY = 300;
            maxPlayers = 1;
            mainMenu = new MainMenu("", "", "", "");
            flashingTextureXLoc=0;
            flashingTextureYLoc=0;
            NPCXLoc = 0;
            NPCYLoc = 0;

            visGlobalAtts = new List<string>();
            visPlayerAtts = new List<string>();
        }

        public GameSettings(List<Requirement> gameOverRequirements, string defaultFontPath,string startNavigable, string startOfRoundNav, string endOfRoundNav,
            string dialogueScrollSoundPath, string dialogueEndSoundPath, string dialoguePaneTexturePath, string dialoguePaneFlashingTexturePath,
            int maxPlayers, int dialoguePanePosX, int dialoguePanePosY, int NPCXLoc, int NPCYLoc,
            int flashingTextureXLoc, int flashingTextureYLoc, MainMenu mM, List<string> visPlayerAtts, List<string>visGlobalAtts)
        {
            this.gameOverRequirements = gameOverRequirements;
            this.defaultFontPath = defaultFontPath;
            this.startNavigable = startNavigable;
            this.startOfRoundNav = startOfRoundNav;
            this.endOfRoundNav = endOfRoundNav;
            this.dialogueScrollSoundPath = dialogueScrollSoundPath;
            this.dialogueEndSoundPath = dialogueEndSoundPath;
            this.dialoguePaneTexturePath = dialoguePaneTexturePath;
            this.dialoguePaneFlashingTexturePath = dialoguePaneFlashingTexturePath;
            this.dialoguePanePosX = dialoguePanePosX;
            this.dialoguePanePosY = dialoguePanePosY;
            this.maxPlayers = maxPlayers;
            this.flashingTextureXLoc = flashingTextureXLoc;
            this.flashingTextureYLoc = flashingTextureYLoc;
            this.NPCXLoc = NPCXLoc;
            this.NPCYLoc = NPCYLoc;


            this.mainMenu = mM;
            this.visPlayerAtts = visPlayerAtts;
            this.visGlobalAtts = visGlobalAtts;


        }
    }

    [Serializable]
    public class MainMenu
    {
        public string mainMenuImagePath;
        public string mainMenuSoundPath;
        public string playButtonSoundPath;
        public string fontImagePath;

        public MainMenu()
        {
            mainMenuImagePath = "";
            mainMenuSoundPath = "";
            playButtonSoundPath = "";
            fontImagePath = "";
        }

        public MainMenu(string mMIP, string mMSP, string pBSP, string fIP)
        {
            mainMenuImagePath = mMIP;
            mainMenuSoundPath = mMSP;
            playButtonSoundPath = pBSP;
            fontImagePath = fIP;
        }
    }
}



