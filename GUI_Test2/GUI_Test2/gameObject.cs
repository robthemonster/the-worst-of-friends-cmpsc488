using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Test2
{
    [Serializable]
    public class Game
    {
        //public List<NPC> characters;
        //public Dictionary<String,Path> paths;
        public List<String> pathGroups;
        public List<String> hubs;
        //public List<P2PG> p2PG;
        public Dictionary<String, Navigable> navIndex;
        public String navigableName;
        public List<String> paths;

        public Game()
        {
            pathGroups = new List<string>();
            hubs = new List<string>();
            navIndex = new Dictionary<String, Navigable>();
            navigableName = "";
            paths = new List<String>();
        }

        public Game(List<String> pg, List<String> h, Dictionary<String, Navigable> nI, string nN, List<String> p)
        {
            pathGroups = pg;
            hubs = h;
            navIndex = nI;
            navigableName = nN;
            paths = p;
        }
    }
}
