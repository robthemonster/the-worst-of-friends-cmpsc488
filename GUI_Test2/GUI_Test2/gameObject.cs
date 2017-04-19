using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Test2
{
    [Serializable]
    public class Project
    {
        //public List<NPC> characters;
        public List<String> pathGroups;
        public List<String> hubs;
        public Dictionary<String, Navigable> navIndex;
        public String navigableName;
        public List<String> paths;
        public List<Attrib> attribs;
        public Dictionary<string, NPC> characters;
        public EndingGen endingGen;
        public GameSettings gameSettings;

        public Project()
        {
            pathGroups = new List<string>();
            hubs = new List<string>();
            navIndex = new Dictionary<String, Navigable>();
            navigableName = "";
            paths = new List<String>();
            attribs = new List<Attrib>();
            characters = new Dictionary<string, NPC>();
            endingGen = new EndingGen();
            gameSettings = new GameSettings();
        }

        public Project(List<String> pg, List<String> h, Dictionary<String, Navigable> nI, List<String> p,List<Attrib> attribs, Dictionary<string, NPC> c, EndingGen eG, GameSettings gS)
        {
            pathGroups = pg;
            hubs = h;
            navIndex = nI;
            paths = p;
            this.attribs = attribs;
            characters = c;
            endingGen = eG;
            gameSettings = gS;
        }
    }

    [Serializable]
    public static class Game
    {
        //public List<NPC> characters;
        public static List<String> pathGroups = new List<string>();
        public static List<String> hubs = new List<string>();
        public static Dictionary<String, Navigable> navIndex = new Dictionary<String, Navigable>();
        public static List<String> paths = new List<String>();
        public static EndingGen endingGen = new EndingGen();
        public static GameSettings gameSettings = new GameSettings();

        
        private static DirectoryInfo directory = Directory.GetParent(Directory.GetCurrentDirectory() + "\\..\\..\\..\\codegen_test\\");

        private static Dictionary<String, int> navNameToImageIndex = new Dictionary<string, int>();
        private static Dictionary<String, int> navNameToSoundIndex = new Dictionary<string, int>();
        private static Dictionary<string, int> navNameToCodeIndex = new Dictionary<string, int>();
        private static Dictionary<string, Dictionary<string,  string>> oldPathToNewPath = new Dictionary<string, Dictionary<string, string>>();
        private static Dictionary<string, string> oldPathToCodeObject = new Dictionary<string, string>();



        public static void init(List<String> pg, List<String> h, Dictionary<String, Navigable> nI,  List<String> p, EndingGen eG, GameSettings gS)
        {
            pathGroups = pg;
            hubs = h;
            navIndex = nI;
           
            paths = p;
            endingGen = eG;
            gameSettings = gS;
        }

        public static void setPathGroup(List<String> pg)
        {
            pathGroups = pg;
        }

        public static void setHubs(List<String> h)
        {
            hubs = h;
        }

        public static void setNavIndex(Dictionary<String, Navigable> nI)
        {
            navIndex = nI;
        }

        public static void setPaths(List<String> p)
        {
            paths = p;
        }

        public static void setEndingGenerator(EndingGen eg)
        {
            endingGen = eg;
        }

        public static void setGameSettings(GameSettings gS)
        {
            gameSettings = gS;
        }


        private static bool generateCode(string filePath)
        {
            
            StringBuilder code = new StringBuilder(GUI_Test2.Properties.Resources.defaultHeader);

            code.AppendLine("Game * game = new Game(" + gameSettings.maxPlayers + ");");
            code.AppendLine("sf::Music music;");
            
           string loadTextureCode = getLoadTexturesCode();
          
            code.AppendLine(loadTextureCode);

            string instantiateNavigablesCode = getInstantiateNavigablesCode();

            code.AppendLine(instantiateNavigablesCode);

            string requirementsCode = getRequirementsCode();

            code.AppendLine(requirementsCode);

            string setGameSettingsCode = getSetGameSettingsCode();

            code.AppendLine(setGameSettingsCode);

            string addAttributesCode = getAddAttributesCode();

            code.AppendLine(addAttributesCode);

            string setFontandCharSizeCode = getSetFontandCharSizeCode();

            code.AppendLine(setFontandCharSizeCode);

            string addButtonsCode = getAddButtonsCode();

            code.AppendLine(addButtonsCode);

            string setImageTexturesCode = getImageAndMusicSetCode();

            code.AppendLine(setImageTexturesCode);

            string setDialoguePanes = getDialoguePaneCode();

            code.AppendLine(setDialoguePanes);

            string addDialogueCode = getAddDialogueCode();

            code.AppendLine(addDialogueCode);

            string endingGenCode = getEndingGenCode();

            code.AppendLine(endingGenCode);
            
     

            code.AppendLine(GUI_Test2.Properties.Resources.defaultFooter);
            StreamWriter outputStream = new StreamWriter(filePath);

            outputStream.WriteLine(code.ToString());

            outputStream.Close();

            return true;
        }

        private static string getAddAttributesCode()
        {
            StringBuilder code = new StringBuilder();

            foreach (Attrib attribute in Attributes.attribs)
            {

                switch (attribute.scope)
                {
                    case Attributes.GLOBAL:
                        code.AppendLine("(*game).addGlobalAttribute(\"" + attribute.name + "\", " + attribute.value + ");");
                        if (Game.gameSettings.visGlobalAtts.Contains(attribute.name))
                            code.AppendLine("(*game).addVisibleGlobalAttribute(\"" + attribute.name + "\");");
                        break;
                    case Attributes.HUB:
                        break;
                    case Attributes.PLAYER:
                        code.AppendLine("(*game).addPlayerAttribute(\"" + attribute.name + "\", " + attribute.value + ");");
                        if (Game.gameSettings.visPlayerAtts.Contains(attribute.name))
                            code.AppendLine("(*game).addVisiblePlayerAttribute(\"" + attribute.name + "\");");
                        break;
                }

            }
            return code.ToString();
        }

        private static string getEndingGenCode()
        {
            StringBuilder code = new StringBuilder();
            if (Game.endingGen.pathsInGroup.Count == 0)
                return code.ToString();
            int numTiers = Game.endingGen.tierofEachPath.Max();
            code.AppendLine("(*game).setEndingTiers(" + numTiers + ");");
            int endingCtr = 0;
            foreach (string ending in Game.endingGen.pathsInGroup)
            {
                List<Requirement> reqs = Game.endingGen.reqsofEachPath[endingCtr];
                if (reqs.Count == 0)
                {
                    code.AppendLine("(*game).addEnding(" + Game.endingGen.tierofEachPath[endingCtr] + ", nav" + Game.navNameToCodeIndex[ending] + ", &noReq");
                }
                else
                {
                    code.AppendLine("Requirements endingReq" + endingCtr + "(*(*game).getAttributeMapPointer());");
                    foreach (Requirement r in reqs)
                    {
                        
                         string op = "";
                        switch (r.comp)
                        {
                            case ">":
                                op = "Requirements::GT";
                                break;
                            case ">=":
                                op = "Requirements::GEQ";
                                break;
                            case "<":
                                op = "Requirements::LT";
                                break;
                            case "<=":
                                op = "Requirements::LEQ";
                                break;
                            case "==":
                                op = "Requirements::EQ";
                                break;
                        }
                        if (r.scope == Requirement.GLOBAL)
                            code.AppendLine("endingReq" + endingCtr + ".addRequirement((Attributable**)game, \"" + r.name + "\", " + op + ", " + r.value + ");");
                        if (r.scope == Requirement.PLAYER)
                            code.AppendLine("endingReq" + endingCtr + ".addRequirement((Attributable**)(*game).getCurrentPlayerPointer(), \"" + r.name + "\", " + op + ", " + r.value + ");");
                        if (r.scope == Requirement.HUB)
                            code.AppendLine("endingReq" + endingCtr + ".addRequirement((Attributable**) nav" + navNameToCodeIndex[r.hub] + ", \"" + r.name + "\", " + op + "," + r.value + ");");
                    }
                    code.AppendLine("(*game).addEnding(" + Game.endingGen.tierofEachPath[endingCtr] + ", nav" + Game.navNameToCodeIndex[ending] + ", &endingReq" + endingCtr + ");");
                    endingCtr++;
                }
                
            }
            return code.ToString();
        }

        private static string getSetFontandCharSizeCode()
        {
            StringBuilder code = new StringBuilder();

            foreach (Navigable nav in navIndex.Values)
            {
                switch (nav.getNavType())
                {
                    case Navigable.HUB:
                    case Navigable.PATH:
                        string buttonFont = nav.getButtonFont();
                        if (buttonFont == "")
                            buttonFont = Game.gameSettings.defaultFontPath;
                        code.AppendLine("(*nav" + Game.navNameToCodeIndex[nav.getName()] + ").setFont(" + Game.oldPathToCodeObject[buttonFont] + ");");
                        code.AppendLine("(*nav" + Game.navNameToCodeIndex[nav.getName()] + ").setFontCharSize(" + nav.getButtonCharSize() +");");
                        break;
                }
            }
            return code.ToString();
        }

        private static string getAddButtonsCode()
        {
            StringBuilder code = new StringBuilder();

            foreach (Navigable nav in navIndex.Values) {
                switch (nav.getNavType())
                {
                    case Navigable.HUB:
                    case Navigable.PATH:
                        List<Button> buttons = new List<Button>();
                        if (nav.getNavType() == Navigable.PATH)
                            buttons = ((Path)nav).buttons;
                        else if (nav.getNavType() == Navigable.HUB)
                            buttons = ((Hub)nav).buttons;
                        foreach (Button b in buttons)
                        {
                            
                            string button1Texture = "NULL", button2Texture = "NULL";
                            if (b.pic1path != "")
                            {
                                button1Texture = "&" +Game.oldPathToCodeObject[b.pic1path];
                                if (b.pic2path != "")
                                {
                                    button2Texture = "&" + Game.oldPathToCodeObject[b.pic2path];
                                }
                            }

                            code.AppendLine("(*nav" + Game.navNameToCodeIndex[nav.getName()] + ").addButton(sf::Vector2f(" + b.sizeX + ", " + b.sizeY + "),\"" + b.text + "\", nav" + Game.navNameToCodeIndex[b.next] + ", " + "sf::Vector2f(" + b.posX + ", " + b.posY + "), " + b.highlight + ", " + button1Texture + ", " + button2Texture  +");");
                        }
                        if (nav.getNavType() == Navigable.PATH)
                        {
                            if (((Path)nav).defaultTargetNavigable != "")
                            {
                                code.AppendLine("(*nav" + Game.navNameToCodeIndex[nav.getName()] + ").setDestination((Navigable**)&nav" + Game.navNameToCodeIndex[((Path)nav).defaultTargetNavigable] + ");");
                            }
                        }
                        break;
                }
            }
            return code.ToString();
        }

        private static string getDialoguePaneCode()
        {
            StringBuilder code = new StringBuilder();
            foreach (Navigable nav in Game.navIndex.Values)
            {
                if (nav.getNavType() == Navigable.PATH)
                {
                    code.AppendLine("(*nav" + Game.navNameToCodeIndex[nav.getName()] + ").setDialoguePaneTexture("+Game.oldPathToCodeObject[Game.gameSettings.dialoguePaneTexturePath] + ", sf::Vector2f(" + Game.gameSettings.dialoguePanePosX + ", " + Game.gameSettings.dialoguePanePosY + "));");
                }
            }
            return code.ToString();
        }

        private static string getAddDialogueCode()
        {
            StringBuilder code = new StringBuilder();
            int impactCtr = 0;
            foreach (Navigable nav in Game.navIndex.Values)
            {
                if (nav.getNavType() == Navigable.PATH)
                {
                    int dialogueCtr = 0;
                    Path p = (Path)nav;
                    foreach (string dialogue in p.dialogueContents)
                    {
                        if (p.dialogueImpactList[dialogueCtr].Count == 0)
                        {
                            code.AppendLine("(*nav" + Game.navNameToCodeIndex[p.name] + ").addDialogueLine(\"" + dialogue + "\");");
                        }
                        else
                        {
                            code.AppendLine("std::vector<Impact *> impacts" + impactCtr + " = std::vector<Impact *>();");
                            foreach (Impact impact in p.dialogueImpactList[dialogueCtr])
                            {
                                string target = "";
                                string op = "Impact::";
                                switch (impact.scope)
                                {
                                    case Impact.GLOBAL:
                                        target = "game";
                                        break;
                                    case Impact.HUB:
                                        target = "&nav" + Game.navNameToCodeIndex[impact.hub];
                                        break;
                                    case Impact.PLAYER:
                                        target = "(*game).getCurrentPlayerPointer()";
                                        break;
                                }
                                switch (impact.op)
                                {
                                    case Impact.SET:
                                        op = "SET";
                                        break;
                                    case Impact.INCREASE:
                                        op = "INCREASE";
                                        break;
                                    case Impact.DECREASE:
                                        op = "DECREASE";
                                        break;
                                }
                                code.AppendLine("impacts" + impactCtr + ".push_back(new Impact((*game).getAttributeMapPointer(), (Attributable**)" + target + ", \"" + impact.attribute + "\", Impact::" + op + ", " + impact.val + "));");
                            }
                            code.AppendLine("(*nav" + Game.navNameToCodeIndex[p.name] + ").addDialogueLine(\"" + dialogue + "\", impacts" + impactCtr +");");
                            impactCtr++;
                        }
                        dialogueCtr++;
                    }
                }
            }
            return code.ToString();
        }

        private static string getSetGameSettingsCode()
        {
            


            StringBuilder code = new StringBuilder();
       
            code.AppendLine("(*game).setStart(nav" + Game.navNameToCodeIndex[Game.gameSettings.startNavigable] + ");");
            code.AppendLine("(*game).setStartOfRound(nav" + Game.navNameToCodeIndex[Game.gameSettings.startOfRoundNav] + ");");
            code.AppendLine("(*game).setEndOfRound(nav" + Game.navNameToCodeIndex[Game.gameSettings.endOfRoundNav] + ");");

            code.AppendLine("Requirements gameOver(*(*game).getAttributeMapPointer());");
            foreach (Requirement req in Game.gameSettings.gameOverRequirements)
            {
                string target = "";
                switch (req.scope)
                {
                    case Requirement.GLOBAL:
                        target = "game";
                        break;
                    case Requirement.PLAYER:
                        target = "(*game).getCurrentPlayerPointer()";
                        break;
                    case Requirement.HUB:
                        target = "(*nav" + navNameToCodeIndex[req.hub] + ")";
                        break;
                }
                string op = "Requirements::";
                switch (req.comp)
                {
                    case "==":
                        op += "EQ";
                        break;
                    case ">":
                        op += "GT";
                        break;
                    case ">=":
                        op += "GEQ";
                        break;
                    case "<":
                        op += "LT";
                        break;
                    case "<=":
                        op += "LEQ";
                        break;
                }
                code.AppendLine("gameOver.addRequirement((Attributable**)" + target + ", \"" + req.name + "\", " + op + ", " + req.value + ");");
            }
            code.AppendLine("(*game).setGameOverRequirements(&gameOver);");

            string font = Game.gameSettings.mainMenu.fontImagePath;
            if (font == "")
                font = Game.gameSettings.defaultFontPath;

            code.AppendLine("(*game).setMenuFont(" + Game.oldPathToCodeObject[font] + ");");
            code.AppendLine("(*game).setMainMenuImageTexture(" + Game.oldPathToCodeObject[Game.gameSettings.mainMenu.mainMenuImagePath] + ");");
            code.AppendLine("(*game).setMainMenuMusic(music, \"" + Game.oldPathToNewPath["sound"][Game.gameSettings.mainMenu.mainMenuSoundPath] + "\");"); 
            code.AppendLine("(*game).setMainMenuPlayButtonSound(\"" + Game.oldPathToNewPath["sound"][Game.gameSettings.mainMenu.playButtonSoundPath] + "\");");

        
            return code.ToString();
        }

        private static string getImageAndMusicSetCode()
        {
            
            StringBuilder code = new StringBuilder(); 
            foreach (Navigable nav in Game.navIndex.Values)
            {
                switch (nav.getNavType())
                {
                    case Navigable.HUB:
                    case Navigable.PATH:
                        code.AppendLine("(*nav" + Game.navNameToCodeIndex[nav.getName()] + ").setImageTexture(" + Game.oldPathToCodeObject[nav.getImagePath()] + ");");
                        if (nav.getSoundPath() != "")
                        {
                            code.AppendLine("(*nav" + Game.navNameToCodeIndex[nav.getName()] + ").setMusic(music, " + Game.oldPathToNewPath[nav.getSoundPath()]);
                        }
                        
                        break;
                }
           }
            return code.ToString();
        }

        private static string getInstantiateNavigablesCode()
        {
            StringBuilder code = new StringBuilder();
            int ctr = 0;
            foreach (Navigable nav in navIndex.Values)
            {
                switch (nav.getNavType())
                {
                    case Navigable.PATH:
                        code.AppendLine("Path * nav" + ctr + " = new Path(game);");
                        break;
                    case Navigable.HUB:
                        code.AppendLine("Hub * nav" + ctr + "= new Hub(game);");
                        break;
                    case Navigable.PATHGROUP:
                        code.AppendLine("PathGroup * nav" + ctr + "= new PathGroup;");
                        break;
                }
                Game.navNameToCodeIndex[nav.getName()] = ctr;
                ctr++;
            }
            return code.ToString();
        }

        private static string getRequirementsCode()
        {
            StringBuilder code = new StringBuilder();

            string attributeMap = "*(*game).getAttributeMapPointer()";

            code.AppendLine("Requirements noReq("+attributeMap+");");

            int reqCtr = 0;
            foreach (Navigable nav in Game.navIndex.Values)
            {
               
                if (nav.getNavType() == Navigable.PATHGROUP)
                {
                    PathGroup pg = (PathGroup)nav; 
                    code.AppendLine("(*nav" + Game.navNameToCodeIndex[pg.name] + ").setTiers(" + pg.tiersofEachPath.Max() + ");");
                    int pathsInPathGroupCtr = 0;
                    foreach (string p in pg.pathsInGroup)
                        {
                        if (pg.pathRequirements[pathsInPathGroupCtr].Count > 0)
                        {

                            code.AppendLine("Requirements req" + reqCtr + "(" + attributeMap + ");");

                            foreach (Requirement r in pg.pathRequirements[pathsInPathGroupCtr])
                            {
                                string op = "";
                                switch (r.comp)
                                {
                                    case ">":
                                        op = "Requirements::GT";
                                        break;
                                    case ">=":
                                        op = "Requirements::GEQ";
                                        break;
                                    case "<":
                                        op = "Requirements::LT";
                                        break;
                                    case "<=":
                                        op = "Requirements::LEQ";
                                        break;
                                    case "==":
                                        op = "Requirements::EQ";
                                        break;
                                }
                                if (r.scope == Requirement.GLOBAL)
                                    code.AppendLine("req" + reqCtr + ".addRequirement((Attributable**)game, \"" + r.name + "\", " + op + ", " + r.value + ");");
                                if (r.scope == Requirement.PLAYER)
                                    code.AppendLine("req" + reqCtr + ".addRequirement((Attributable**)(*game).getCurrentPlayerPointer(), \"" + r.name + "\", " + op + ", " + r.value + ");");
                                if (r.scope == Requirement.HUB)
                                    code.AppendLine("req" + reqCtr + ".addRequirement((Attributable**) nav" + navNameToCodeIndex[r.hub] + ", \"" + r.name + "\", " + op + "," + r.value + ");");

                            }
                            code.AppendLine("(*nav" + navNameToCodeIndex[pg.name] + ").addNavigable(" + pg.tiersofEachPath[pathsInPathGroupCtr] + ", nav" + navNameToCodeIndex[pg.pathsInGroup[pathsInPathGroupCtr]] + ", " + pg.weightsofEachPath[pathsInPathGroupCtr] + ", " + "&req" + reqCtr + ");");
                            reqCtr++;
                        }
                        else
                        {
                            code.AppendLine("(*nav" + navNameToCodeIndex[pg.name] + ").addNavigable(" + pg.tiersofEachPath[pathsInPathGroupCtr] + ", nav" + navNameToCodeIndex[pg.pathsInGroup[pathsInPathGroupCtr]] + ", " + pg.weightsofEachPath[pathsInPathGroupCtr] + ", &noReq);");
                        }

                        pathsInPathGroupCtr++;
                        }
                    }
                }

            return code.ToString() ;
        }

        private static string getLoadTexturesCode()
        {
            if (!copyAssetsToDir())
            {
                Console.Out.WriteLine("One of the image or sound assets could not be found. It has been moved, renamed, or deleted.");
                return "";
            }
            StringBuilder code = new StringBuilder();
            int ctr = 0;
            foreach (string filePath in Game.oldPathToNewPath["image"].Keys)
            {

                code.AppendLine("sf::Texture texture" + ctr + ";");
                code.AppendLine(@"if (!texture" + ctr + ".loadFromFile(\"" + Game.oldPathToNewPath["image"][filePath].Replace("\\", "/") + "\"))");
                code.AppendLine(@" std::cout<< ""Error loading image file"" << std::endl;");
                Game.oldPathToCodeObject[filePath] = "texture" + ctr; 
                ctr++;
            }

            ctr = 0;

            foreach (string filePath in Game.oldPathToNewPath["font"].Keys)
            {
                code.AppendLine("sf::Font font" + ctr + ";");
                code.AppendLine("if (!font" + ctr + ".loadFromFile(\"" + Game.oldPathToNewPath["font"][filePath] + "\"))");
                code.AppendLine("\tstd::cout << \"Error loading font file\" << std::endl;");
                Game.oldPathToCodeObject[filePath] = "font" + ctr;
                ctr++;
            }

            code.AppendLine("sf::Texture menuImage;");
            code.AppendLine("if (!menuImage.loadFromFile(\"" + Game.oldPathToNewPath["image"][Game.gameSettings.mainMenu.mainMenuImagePath] + "\"))");
            code.AppendLine(@" std::cout<< ""Error loading image file"" << std::endl;");

            return code.ToString();

        }

        private static bool copyAssetsToDir()
        {
            Game.oldPathToNewPath["font"] = new Dictionary<string, string>();
            Game.oldPathToNewPath["image"] = new Dictionary<string, string>();
            Game.oldPathToNewPath["sound"] = new Dictionary<string, string>();
            
            Console.Out.WriteLine("Copying assets to dir..");
            System.IO.Directory.CreateDirectory(Game.directory+ "\\assets\\img");
            System.IO.Directory.CreateDirectory(Game.directory + "\\assets\\music");
            System.IO.Directory.CreateDirectory(Game.directory + "\\assets\\fonts");

            int imgctr = 0, musicctr = 0;
            foreach (Navigable nav in Game.navIndex.Values)
            {
                switch (nav.getNavType())
                {
                    case Navigable.HUB:
                    case Navigable.PATH:
                        copyFileTo(nav.getImagePath(), "\\assets\\img\\img" + imgctr, "image");
                        imgctr++;
                        if (nav.getSoundPath() != "")
                        {
                            copyFileTo(nav.getSoundPath(), "\\assets\\music\\sound" + musicctr, "sound");
                            musicctr++;
                        }

                        List<Button> buttons = new List<Button>();
                        if (nav.getNavType() == Navigable.PATH)
                            buttons = ((Path)nav).buttons;
                        else if (nav.getNavType() == Navigable.HUB)
                            buttons = ((Hub)nav).buttons;
                         
                        foreach (Button b in buttons)
                        {
                            if (b.pic1path != "")
                            {
                                copyFileTo(b.pic1path, "\\assets\\img\\img" + imgctr, "image");
                                imgctr++;
                                if (b.pic2path != "")
                                {
                                    copyFileTo(b.pic2path, "\\assets\\img\\img" + imgctr, "image");
                                    imgctr++;
                                }
                            }
                        }
                        break;

                }
            }
            
            copyFileTo(Game.gameSettings.mainMenu.mainMenuImagePath, "\\assets\\img\\menuImage", "image");
            copyFileTo(Game.gameSettings.mainMenu.mainMenuSoundPath, "\\assets\\music\\menuMusic", "sound");
            copyFileTo(Game.gameSettings.mainMenu.playButtonSoundPath, "\\assets\\music\\menuPressPlay", "sound");
            copyFileTo(Game.gameSettings.mainMenu.fontImagePath, "\\assets\\fonts\\menuFont", "font");
            copyFileTo(Game.gameSettings.defaultFontPath, "\\assets\\fonts\\defaultFont", "font");
            copyFileTo(Game.gameSettings.dialoguePaneTexturePath, "\\assets\\img\\defaultDialoguePane", "image");           
            
            return true;
        }

        private static void copyFileTo(string file, string destFile, string fileType)
        {
            try
            {
                FileInfo f = new FileInfo(file);
                if (f.Exists && !Game.oldPathToNewPath[fileType].ContainsKey(file))
                {
                    f.CopyTo(Game.directory + destFile + f.Extension, true);
                    Game.oldPathToNewPath[fileType][file] = (Game.directory + destFile + f.Extension).Replace("\\", "/");
                }
            }catch(ArgumentException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
        }

        public static void compileAndRun()
        {

            String vsCommandPath = System.Environment.GetEnvironmentVariable("windir") + "\\System32\\cmd.exe";
            String mainPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\codegen_test\\main.cpp";
            DirectoryInfo directory = Directory.GetParent(mainPath);

            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo f in files)
            {
                if (f.Name == "main.exe" || f.Name == "main.cpp")
                    f.Delete();
            }


            if (!Game.generateCode(mainPath)){
                return;
            }

         
            
           ProcessStartInfo cmd = new ProcessStartInfo(vsCommandPath);

            cmd.Arguments = @"/c cd " + directory + @"&& VC\bin\vcvars32 && VC\bin\cl /EHsc /I .\include /I .\SFML-2.4.2\include /I .VC\include .\include\*.cpp  /link /LIBPATH:.\SFML-2.4.2\lib sfml-system.lib sfml-window.lib sfml-graphics.lib sfml-audio.lib sfml-network.lib ";

           
            Process compiler = Process.Start(cmd);
            compiler.WaitForExit();

           

            
            
            cmd.Arguments = @"/c cd " + directory + @" && VC\bin\vcvars32 && VC\bin\cl /EHsc /I .\include /I .\SFML-2.4.2\include main.cpp /link /LIBPATH:.\SFML-2.4.2\lib sfml-system.lib sfml-window.lib sfml-graphics.lib sfml-audio.lib sfml-network.lib /LIBPATH:.\ *.obj";
                            
            compiler = Process.Start(cmd);
            
            compiler.WaitForExit();

        

            foreach (FileInfo f in directory.GetFiles())
            {
               // if (f.Extension == ".obj" || f.Name == "main.cpp" || (f.Extension == ".exe" && f.Name != "main.exe"))
                  //  f.Delete();
            }

            ProcessStartInfo game = new ProcessStartInfo(directory + "\\main.exe");
            game.WorkingDirectory = directory.ToString();
            Process gameProc = Process.Start(game);
            gameProc.WaitForExit();
            

        }
    }
}
