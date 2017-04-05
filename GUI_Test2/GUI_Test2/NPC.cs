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
        public List<String> imageNames;
        public List<String> imagePaths;

        public NPC() { }

        public NPC(string n)
        {
            name = n;
            imageNames = new List<string>();
            imagePaths = new List<string>();
            Characters.Add(n, this);

        }
        public void addImage(string iname, string ipath) {
            imageNames.Add(iname);
            imagePaths.Add(ipath);
            Characters.Add(this.name, this);
        }
        public void removeImage(int i)
        {
            imageNames.RemoveAt(i);
            imagePaths.RemoveAt(i);
            Characters.Add(this.name, this);
        }
        public void deleteCharacter()
        {
            Characters.Remove(this.name);
        }
    }

    [Serializable]
    static class Characters
    {
        public static Dictionary<string, NPC> characters = new Dictionary<string, NPC>();

        public static void Add(string n, NPC c)
        {
            if (characters.ContainsKey(n))
            {
                characters.Remove(n);
            }
            characters.Add(n, c);
        }

        public static void Remove(string n)
        {
            characters.Remove(n);
        }

        public static List<string> getKeys()
        {
            return characters.Keys.ToList();
        }
    }
}
