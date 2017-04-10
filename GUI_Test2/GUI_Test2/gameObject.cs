using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft;
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
        //public List<P2PG> p2PG;
        public Dictionary<String, Navigable> navIndex;
        public String navigableName;
        public List<String> paths;
        public List<Attrib> attribs;
        public Dictionary<string, NPC> characters;

        public Project()
        {
            pathGroups = new List<string>();
            hubs = new List<string>();
            navIndex = new Dictionary<String, Navigable>();
            navigableName = "";
            paths = new List<String>();
            attribs = new List<Attrib>();
            characters = new Dictionary<string, NPC>();
        }

        public Project(List<String> pg, List<String> h, Dictionary<String, Navigable> nI, string nN, List<String> p,List<Attrib> attribs, Dictionary<string, NPC> c)
        {
            pathGroups = pg;
            hubs = h;
            navIndex = nI;
            navigableName = nN;
            paths = p;
            this.attribs = attribs;
            characters = c;
        }
    }

    [Serializable]
    public static class Game
    {
        //public List<NPC> characters;
        //public Dictionary<String,Path> paths;
        public static List<String> pathGroups = new List<string>();
        public static List<String> hubs = new List<string>();
        //public List<P2PG> p2PG;
        public static Dictionary<String, Navigable> navIndex = new Dictionary<String, Navigable>();
        public static String navigableName = "";
        public static List<String> paths = new List<String>();

        public static void init(List<String> pg, List<String> h, Dictionary<String, Navigable> nI, string nN, List<String> p)
        {
            pathGroups = pg;
            hubs = h;
            navIndex = nI;
            navigableName = nN;
            paths = p;
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

        public static void setNavigableName(string nN)
        {
            navigableName = nN;
        }

        public static void setPaths(List<String> p)
        {
            paths = p;
        }

        public static void generateCode()
        {

            String vsCommandPath = System.Environment.GetEnvironmentVariable("windir") + "\\System32\\cmd.exe";
            String directory = Directory.GetCurrentDirectory() + "\\..\\..\\..\\codegen_test\\aaaa.cpp";

            StreamWriter output = new StreamWriter(directory);
            String s = @"#include <iostream>
//#include ""Game.h""
int main(){
    //Game g = new Game(1, NULL);
    //sf::Vector2f v(0, 0);
    std::cout<<""Hello World""<< std::endl;
    return 0;
}";
            output.WriteLine(s);
            output.Close();
            Process compile = new Process();
            compile.StartInfo.FileName = vsCommandPath;
            compile.StartInfo.RedirectStandardInput = true;
            compile.StartInfo.RedirectStandardOutput = true;
            compile.StartInfo.CreateNoWindow = true;
            compile.StartInfo.UseShellExecute = false;
            compile.Start();

            DirectoryInfo d = Directory.GetParent(directory);
            
            Console.Out.WriteLine(directory);
            compile.StandardInput.WriteLine("cd " + d );
            compile.StandardInput.WriteLine(@"VC\bin\vcvars32");
            compile.StandardInput.WriteLine(@"VC\bin\cl /EHsc aaaa.cpp");
            compile.StandardInput.Flush();
            


           Console.Out.WriteLine(compile.StandardOutput.ReadToEnd());
            Console.Out.WriteLine(compile.StandardError.ReadToEnd());
            compile.Close();
           // compile.WaitForExit();
            
        }
    }
}
