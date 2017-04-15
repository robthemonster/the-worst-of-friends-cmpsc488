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
        public static string defaultFont = "";
        public static string startTurnNav = "";
        public static string startRoundNav = "";
        public static string endRoundNav = "";

        
        private static DirectoryInfo directory = Directory.GetParent(Directory.GetCurrentDirectory() + "\\..\\..\\..\\codegen_test\\");

        private static Dictionary<String, int> navNameToImageIndex = new Dictionary<string, int>();
        private static Dictionary<String, int> navNameToSoundIndex = new Dictionary<string, int>();
        private static List<string> imageAssets = new List<string>();
        private static List<string> musicAssets = new List<string>();



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


           string loadTextureCode = getLoadTexturesCode();
          
            code.AppendLine(loadTextureCode);

            string instantiateNavigablesCode = getInstantiateNavigablesCode();

            code.AppendLine(instantiateNavigablesCode);

            string setImageTexturesCode = getSetImageTextureCode();

            code.AppendLine(setImageTexturesCode);


            code.AppendLine("}");
            StreamWriter outputStream = new StreamWriter(filePath);

            outputStream.WriteLine(code.ToString());

            outputStream.Close();

            return true;
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
                ctr++;
            }
            return instantiateNavigablesCode.ToString();
        }

        private static bool copyAssetsToDir()
        {
            int imgCounter = 0, soundCounter = 0;
            Console.Out.WriteLine("Copying assets to dir..");
            System.IO.Directory.CreateDirectory(Game.directory+ "\\assets\\img");
            System.IO.Directory.CreateDirectory(Game.directory + "\\assets\\music");
            
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
            return true;
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
