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


            //Keith's Version
 
            /*
            Game.gameSettings = new GameSettings(null, "C://Users//Keith//Google Drive//Gui Github Dir//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//fonts//regular.otf",
                 Game.navIndex.Keys.First(), Game.navIndex.Keys.First(), Game.navIndex.Keys.First(),
                 "dialogue scroll sound", "dialogue end sound", "dialogue texture", "dialogue flashing texture"
                 , 300, 300,1, 0, 0,
                 new MainMenu("C://Users//Keith//Google Drive//Gui Github Dir//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//img//absolver.jpg",
                 "C://Users//Keith//Google Drive//Gui Github Dir//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//music//waterfall.ogg",
                 "C://Users//Keith//Google Drive//Gui Github Dir//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//music//letsgo.wav",
                 "C://Users//Keith//Google Drive//Gui Github Dir//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//fonts//arial.ttf"),
                 new List<string>(),new List<string>());
            */



            
            //Galen's Version
                 
            /*
            Game.gameSettings = new GameSettings(null, "C://Users//Galen//Documents//GitHub//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//fonts//regular.otf",
                 Game.navIndex.Keys.First(), Game.navIndex.Keys.First(), Game.navIndex.Keys.First(),
                 "dialogue scroll sound", "dialogue end sound", "dialogue texture", "dialogue flashing texture"
                 , 300, 300,1, 0, 0,
                 new MainMenu("C://Users//Galen//Documents//GitHub//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//img//absolver.jpg",
                 "C://Users//Galen//Documents//GitHub//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//music//waterfall.ogg",
                 "C://Users//Galen//Documents//GitHub//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//music//letsgo.wav",
                 "C://Users//Galen//Documents//GitHub//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//fonts//arial.ttf"),

                 new List<string>(),new List<string>());
            */

           //  Rob's Version

            /*
            Game.gameSettings = new GameSettings(null, "C://Users//The Monster//Source//Repos//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//fonts//regular.otf",
                 Game.navIndex.Keys.First(), Game.navIndex.Keys.First(), Game.navIndex.Keys.First(),
                 "dialogue scroll sound", "dialogue end sound", "dialogue texture", "dialogue flashing texture"
                 , 300, 300,1, 0, 0,
                 new MainMenu("C://Users//The Monster//Source//Repos//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//img//absolver.jpg",
                 "C://Users//The Monster//Source//Repos//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//music//waterfall.ogg",
                 "C://Users//The Monster//Source//Repos//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//music//letsgo.wav",
                 "C://Users//The Monster//Source//Repos//the-worst-of-friends-cmpsc488//GUI_Test2//codegen_test//fonts//arial.otf"),
                 new List<string>(),new List<string>());
            */


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

            string setImageTexturesCode = getSetImageTextureCode();

            code.AppendLine(setImageTexturesCode);


            code.AppendLine("}");
            StreamWriter outputStream = new StreamWriter(filePath);

            outputStream.WriteLine(code.ToString());

            outputStream.Close();

            return true;
        }

        private static string getSetGameSettingsCode()
        {
            


            StringBuilder code = new StringBuilder();
            code.AppendLine("sf::Font defaultFont;");
            code.AppendLine("if (defaultFont.loadFromFile(\"" + Game.oldPathToNewPath[Game.gameSettings.defaultFontPath] + "\"))");
            code.AppendLine("\tstd::cout<<\"Error loading font file\" << std::endl;");
            code.AppendLine("sf::Texture defaultDialoguePane;");
         
            code.AppendLine("(*game).setStart(&nav" + Game.navNameToCodeIndex[Game.gameSettings.startNavigable] + ");");
            code.AppendLine("(*game).setStartOfRound(&nav" + Game.navNameToCodeIndex[Game.gameSettings.startOfRoundNav] + ");");
            code.AppendLine("(*game).setEndOfRound(&nav" + Game.navNameToCodeIndex[Game.gameSettings.endOfRoundNav] + ");");

            code.AppendLine("(*game).setMainMenuImageTexture(menuImage);");
            code.AppendLine("(*game).setMainMenuMusic(music, \"" + Game.oldPathToNewPath[Game.gameSettings.mainMenu.mainMenuSoundPath] + "\");"); 

            //code.AppendLine("if (defaultDialoguePane.loadFromFile(\"" + Game.oldPathToNewPath[Game.gameSettings.dialoguePaneTexturePath] + "\"))");
            //code.AppendLine("\tstd::cout<<\"Error loading dialogue pane file\" << std::endl;");

            return code.ToString();
        }

        private static string getSetImageTextureCode()
        {
            int ctr = 0;
            StringBuilder code = new StringBuilder(); 
            foreach (Navigable nav in Game.navIndex.Values)
            {
                if (navNameToImageIndex.ContainsKey(nav.getName()))
                {
                    code.AppendLine("nav" + ctr + ".setImageTexture(texture" + navNameToImageIndex[nav.getName()] + ");");
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

            
            foreach (Navigable nav in Game.navIndex.Values)
            {
                if (nav.getNavType() == Navigable.PATHGROUP)
                {
                    PathGroup pg = (PathGroup)nav;
                   
                    int pathCtr = 0;
                        foreach (string p in pg.pathsInGroup)
                        {
                        code.AppendLine("Requirements req" + pathCtr + "(" + attributeMap + ");");
                        foreach (Requirement r in pg.pathRequirements[pathCtr])
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
                                code.AppendLine("req" + pathCtr + ".addRequirement((Attributable**)game, \"" + r.name +"\", " + op + ", " + r.value + ");");
                            if (r.scope == Requirement.PLAYER)
                                code.AppendLine("req" + pathCtr + ".addRequirement((Attributable**)(*game).getCurrentPlayerPointer(), \"" + r.name + "\", " + op + ", " + r.value + ");");
                            if (r.scope == Requirement.HUB)
                                code.AppendLine("req" + pathCtr + ".addRequirement((Attributable**), &nav" + navNameToCodeIndex[r.hub] + ", \"" + r.name + "\", " + op + "," + r.value + ");");
                            
                        }
                        code.AppendLine("nav" +navNameToCodeIndex[pg.name] + ".addPath(" + pg.tiersofEachPath[pathCtr] + ", &nav" + navNameToCodeIndex[pg.pathsInGroup[pathCtr]] + ", " + pg.weightsofEachPath[pathCtr] + ", " + "&req" + pathCtr + ");");
                        pathCtr++;
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
            copyFileTo(Game.gameSettings.defaultFontPath, "\\assets\\fonts\\defaultFont");               
            
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
