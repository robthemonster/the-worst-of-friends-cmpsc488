using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Test2
{
    [Serializable]
    public class NPC
    {
        public string name;
        //public Dictionary<String, String> image;

        public NPC()
        {
        }

        public NPC(string n)
        {
            name = n;
        }
    }

    [Serializable]
    static class Characters
    {
        public static Dictionary<string, NPC> characters = new Dictionary<string, NPC>();

        public static void Add(string n, NPC c)
        {
            characters.Add(n, c);
        }

        public static void Remove(string n)
        {
            characters.Remove(n);
        }

        public static List<string> getKeys()
        {
            List<string> keys = new List<string>();
            foreach (string i in Characters.characters.Keys)
            {
                keys.Add(i);
            }

            return keys;
        }
    }
}
