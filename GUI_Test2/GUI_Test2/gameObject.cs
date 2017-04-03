using System;
using System.Collections.Generic;
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

        public Project()
        {
            pathGroups = new List<string>();
            hubs = new List<string>();
            navIndex = new Dictionary<String, Navigable>();
            navigableName = "";
            paths = new List<String>();
            attribs = new List<Attrib>(); 
        }

        public Project(List<String> pg, List<String> h, Dictionary<String, Navigable> nI, string nN, List<String> p,List<Attrib> attribs)
        {
            pathGroups = pg;
            hubs = h;
            navIndex = nI;
            navigableName = nN;
            paths = p;
            this.attribs = attribs;
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
    }
}
