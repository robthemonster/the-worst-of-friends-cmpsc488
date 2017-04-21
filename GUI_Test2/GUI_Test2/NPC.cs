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
           

        }
        public void addImage(string iname, string ipath) {
            imageNames.Add(iname);
            imagePaths.Add(ipath);
           
        }
        public void removeImage(int i)
        {
            imageNames.RemoveAt(i);
            imagePaths.RemoveAt(i);
           
        }
       
    }

  
}
