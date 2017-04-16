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
        private static List<string> imageAssets = new List<string>();
        private static List<string> musicAssets = new List<string>();
        private static Dictionary<string, int> navNameToCodeIndex = new Dictionary<string, int>();
        private static Dictionary<string, string> oldPathToNewPath = new Dictionary<string, string>();



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




            //This is for testing purposes. TODO: remove 

            string workingDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\codegen_test";
            workingDir = workingDir.Replace("\\", "//");
            List<Requirement> gameOver = new List<Requirement>();
           
            // gameOver.Add(new Requirement(Requirement.PLAYER, "", "lol", ">", 3));

            Game.gameSettings = new GameSettings(gameOver, workingDir +"//fonts//regular.otf",
                 Game.navIndex.Keys.First(), Game.navIndex.Keys.First(), Game.navIndex.Keys.First(),
                 "dialogue scroll sound", "dialogue end sound", workingDir + "//img//dialoguePane.png", "dialogue flashing texture"
                 , 300, 300,1, 0, 0, 0, 0,
                 new MainMenu(workingDir +"//img//absolver.jpg",
                 workingDir + "//music//waterfall.ogg",
                 workingDir + "//music//letsgo.wav",
                 workingDir + "//fonts//arial.ttf"),
                 new List<string>(),new List<string>());
          


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

            string setImageTexturesCode = getImageAndMusicSetCode();

            code.AppendLine(setImageTexturesCode);

            string setDialoguePanes = getDialoguePaneCode();

            code.AppendLine(setDialoguePanes);

            string addDialogueCode = getAddDialogueCode();

            code.AppendLine(addDialogueCode);

            code.AppendLine(GUI_Test2.Properties.Resources.defaultFooter);
            StreamWriter outputStream = new StreamWriter(filePath);

            outputStream.WriteLine(code.ToString());

            outputStream.Close();

            return true;
        }

        private static string getDialoguePaneCode()
        {
            StringBuilder dialoguePaneCode = new StringBuilder();
            foreach (Navigable nav in Game.navIndex.Values)
            {
                if (nav.getNavType() == Navigable.PATH)
                {
                    dialoguePaneCode.AppendLine("nav" + Game.navNameToCodeIndex[nav.getName()] + ".setDialoguePaneTexture(defaultDialoguePane, sf::Vector2f(" + Game.gameSettings.dialoguePanePosX + ", " + Game.gameSettings.dialoguePanePosY + "));");
                }
            }
            return dialoguePaneCode.ToString();
        }

        private static string getAddDialogueCode()
        {
            StringBuilder addDialogueCode = new StringBuilder();
            foreach (Navigable nav in Game.navIndex.Values)
            {
                if (nav.getNavType() == Navigable.PATH)
                {
                    Path p = (Path)nav;
                    foreach (string dialogue in p.dialogueContents)
                    {
                        addDialogueCode.AppendLine("nav" + Game.navNameToCodeIndex[p.name] + ".addDialogueLine(\"" + dialogue + "\");");
                    }
                }
            }
            return addDialogueCode.ToString();
        }

        private static string getSetGameSettingsCode()
        {
            


            StringBuilder code = new StringBuilder();
            code.AppendLine("sf::Font defaultFont;");
            code.AppendLine("if (defaultFont.loadFromFile(\"" + Game.oldPathToNewPath[Game.gameSettings.defaultFontPath] + "\"))");
            code.AppendLine("\tstd::cout<<\"Error loading font file\" << std::endl;");

            code.AppendLine("sf::Font menuFont;");
            code.AppendLine("if (menuFont.loadFromFile(\"" + Game.oldPathToNewPath[Game.gameSettings.mainMenu.fontImagePath] + "\"))");
            code.AppendLine("\tstd::cout<<\"Error loading font file\" << std::endl;");

            code.AppendLine("sf::Texture defaultDialoguePane;");
         
            code.AppendLine("(*game).setStart(&nav" + Game.navNameToCodeIndex[Game.gameSettings.startNavigable] + ");");
            code.AppendLine("(*game).setStartOfRound(&nav" + Game.navNameToCodeIndex[Game.gameSettings.startOfRoundNav] + ");");
            code.AppendLine("(*game).setEndOfRound(&nav" + Game.navNameToCodeIndex[Game.gameSettings.endOfRoundNav] + ");");

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
                        target = "nav" + navNameToCodeIndex[req.hub];
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

            code.AppendLine("(*game).setMenuFont(menuFont);");
            code.AppendLine("(*game).setMainMenuImageTexture(menuImage);");
            code.AppendLine("(*game).setMainMenuMusic(music, \"" + Game.oldPathToNewPath[Game.gameSettings.mainMenu.mainMenuSoundPath] + "\");"); 

            code.AppendLine("if (defaultDialoguePane.loadFromFile(\"" + Game.oldPathToNewPath[Game.gameSettings.dialoguePaneTexturePath] + "\"))");
            code.AppendLine("\tstd::cout<<\"Error loading dialogue pane file\" << std::endl;");

            return code.ToString();
        }

        private static string getImageAndMusicSetCode()
        {
            int ctr = 0;
            StringBuilder code = new StringBuilder(); 
            foreach (Navigable nav in Game.navIndex.Values)
            {
                if (navNameToImageIndex.ContainsKey(nav.getName()))
                {
                    code.AppendLine("nav" + ctr + ".setImageTexture(texture" + navNameToImageIndex[nav.getName()] + ");");
                }
                if (navNameToSoundIndex.ContainsKey(nav.getName()))
                {
                    if (nav.getNavType() == Navigable.PATH || nav.getNavType() == Navigable.HUB)
                    {
                        code.AppendLine("nav" + ctr + ".setMusic(music, \"" + Game.oldPathToNewPath[nav.getSoundPath()] + "\");");
                    }
                }
                ctr++;
           }
            return code.ToString();
        }

        private static string getInstantiateNavigablesCode()
        {
            StringBuilder instantiateNavigablesCode = new StringBuilder();
            int ctr = 0;
            foreach (Navigable nav in navIndex.Values)
            {
                switch (nav.getNavType())
                {
                    case Navigable.PATH:
                        instantiateNavigablesCode.AppendLine("Path nav" + ctr + "(game);");
                        break;
                    case Navigable.HUB:
                        instantiateNavigablesCode.AppendLine("Hub nav" + ctr + "(game);");
                        break;
                    case Navigable.PATHGROUP:
                        instantiateNavigablesCode.AppendLine("PathGroup nav" + ctr + ";");
                        break;
                }
                Game.navNameToCodeIndex[nav.getName()] = ctr;
                ctr++;
            }
            return instantiateNavigablesCode.ToString();
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
                    code.AppendLine("nav" + Game.navNameToCodeIndex[pg.name] + ".setTiers(" + pg.tiersofEachPath.Max() + ");");
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
                                    code.AppendLine("req" + reqCtr + ".addRequirement((Attributable**) &nav" + navNameToCodeIndex[r.hub] + ", \"" + r.name + "\", " + op + "," + r.value + ");");

                            }
                            code.AppendLine("nav" + navNameToCodeIndex[pg.name] + ".addNavigable(" + pg.tiersofEachPath[pathsInPathGroupCtr] + ", &nav" + navNameToCodeIndex[pg.pathsInGroup[pathsInPathGroupCtr]] + ", " + pg.weightsofEachPath[pathsInPathGroupCtr] + ", " + "&req" + reqCtr + ");");
                            reqCtr++;
                        }
                        else
                        {
                            code.AppendLine("nav" + navNameToCodeIndex[pg.name] + ".addNavigable(" + pg.tiersofEachPath[pathsInPathGroupCtr] + ", &nav" + navNameToCodeIndex[pg.pathsInGroup[pathsInPathGroupCtr]] + ", " + pg.weightsofEachPath[pathsInPathGroupCtr] + ", &noReq);");
                        }

                        pathsInPathGroupCtr++;
                        }
                    }
                }

            return code.ToString() ;
        }

        private static bool copyAssetsToDir()
        {
            int imgCounter = 0, soundCounter = 0;
            Console.Out.WriteLine("Copying assets to dir..");
            System.IO.Directory.CreateDirectory(Game.directory+ "\\assets\\img");
            System.IO.Directory.CreateDirectory(Game.directory + "\\assets\\music");
            System.IO.Directory.CreateDirectory(Game.directory + "\\assets\\fonts");
            
            Dictionary<string, int> assetToIndex = new Dictionary<string, int>();

            foreach (Navigable nav in Game.navIndex.Values)
            {
               
                    if (nav.getImagePath() != "")
                    {
                        FileInfo image = new FileInfo(nav.getImagePath());


                        if (image.Exists)
                        {
                            if (!assetToIndex.ContainsKey(image.FullName))
                            {
                                image.CopyTo(Game.directory + "\\assets\\img\\img" + imgCounter + image.Extension, true);
                                Game.imageAssets.Add(Game.directory + "\\assets\\img\\img" + imgCounter + image.Extension);
                                Game.navNameToImageIndex[nav.getName()] = imgCounter;
                                assetToIndex[image.FullName] = imgCounter;
                                Game.oldPathToNewPath[image.FullName] = Game.directory + "\\assets\\img\\img" + imgCounter + image.Extension;
                                imgCounter++;
                            }else
                            {
                                Game.navNameToImageIndex[nav.getName()] = assetToIndex[image.FullName];
                            }
                        }else
                        {
                            Console.Out.WriteLine("Could not find: " + image);
                            return false;
                        }
                    
                    if (nav.getSoundPath() != "")
                    {
                        FileInfo sound = new FileInfo(nav.getSoundPath());
                        if (sound.Exists)
                        {
                            if (!assetToIndex.ContainsKey(sound.FullName))
                            {
                                sound.CopyTo(Game.directory + "\\assets\\music\\sound" + soundCounter + sound.Extension, true);
                                Game.musicAssets.Add(Game.directory + "\\assets\\music\\sound" + soundCounter + sound.Extension);
                                Game.navNameToSoundIndex[nav.getName()] = soundCounter;
                                assetToIndex[sound.FullName] = soundCounter;
                                Game.oldPathToNewPath[sound.FullName] = Game.directory + "\\assets\\music\\sound" + soundCounter + sound.Extension;
                                soundCounter++;
                            }else
                            {
                                Game.navNameToSoundIndex[nav.getName()] = assetToIndex[sound.FullName];
                            }
                        }
                        else 
                        {
                            Console.Out.WriteLine("Could not find: " + sound);
                            return false;
                        }
                     }
                        
                    
                }
            }
            copyFileTo(Game.gameSettings.mainMenu.mainMenuImagePath, "\\assets\\img\\menuImage");
            copyFileTo(Game.gameSettings.mainMenu.mainMenuSoundPath, "\\assets\\music\\menuMusic");
            copyFileTo(Game.gameSettings.mainMenu.playButtonSoundPath, "\\assets\\music\\menuPressPlay");
            copyFileTo(Game.gameSettings.mainMenu.fontImagePath, "\\assets\\fonts\\menuFont");
            copyFileTo(Game.gameSettings.defaultFontPath, "\\assets\\fonts\\defaultFont");
            copyFileTo(Game.gameSettings.dialoguePaneTexturePath, "\\assets\\img\\defaultDialoguePane");           
            
            return true;
        }

        private static void copyFileTo(string file, string destFile)
        {
            FileInfo f = new FileInfo(file);
            if (f.Exists)
            {
                f.CopyTo(Game.directory + destFile + f.Extension, true);
                Game.oldPathToNewPath[file] = (Game.directory + destFile + f.Extension).Replace("\\", "/");
            }
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
            foreach (string filePath in Game.imageAssets)
            {

                code.AppendLine("sf::Texture texture" + ctr + ";");
                code.AppendLine(@"if (!texture" + ctr + ".loadFromFile(\"" + filePath.Replace("\\", "/") + "\"))");
                code.AppendLine(@" std::cout<< ""Error loading image file"" << std::endl;");
                ctr++;
            }

            code.AppendLine("sf::Texture menuImage;");
            code.AppendLine("if (!menuImage.loadFromFile(\"" + Game.oldPathToNewPath[Game.gameSettings.mainMenu.mainMenuImagePath] + "\"))");
            code.AppendLine(@" std::cout<< ""Error loading image file"" << std::endl;");

            return code.ToString();

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
            
            /*
           ProcessStartInfo cmd = new ProcessStartInfo(vsCommandPath);

            cmd.Arguments = @"/c cd " + directory + @"&& VC\bin\vcvars32 && VC\bin\cl /EHsc /I .\include /I .\SFML-2.4.2\include /I .VC\include .\include\*.cpp  /link /LIBPATH:.\SFML-2.4.2\lib sfml-system.lib sfml-window.lib sfml-graphics.lib sfml-audio.lib sfml-network.lib ";

           
            Process compiler = Process.Start(cmd);
            compiler.WaitForExit();

           

            
            StreamWriter output = new StreamWriter(mainPath);
            string s = GUI_Test2.Properties.Resources.cookieCutterGame; 
            output.WriteLine(s);
            output.Close();
            cmd.Arguments = @"/c cd " + directory + @" && VC\bin\vcvars32 && VC\bin\cl /EHsc /I .\include /I .\SFML-2.4.2\include main.cpp /link /LIBPATH:.\SFML-2.4.2\lib sfml-system.lib sfml-window.lib sfml-graphics.lib sfml-audio.lib sfml-network.lib /LIBPATH:.\ *.obj";
                            
            compiler = Process.Start(cmd);
            
            compiler.WaitForExit();

        

            foreach (FileInfo f in directory.GetFiles())
            {
                if (f.Extension == ".obj" || f.Name == "main.cpp" || (f.Extension == ".exe" && f.Name != "main.exe"))
                    f.Delete();
            }

            ProcessStartInfo game = new ProcessStartInfo(directory + "\\main.exe");
            game.WorkingDirectory = directory.ToString();
            Process gameProc = Process.Start(game);
            gameProc.WaitForExit();
            */

        }
    }
}
