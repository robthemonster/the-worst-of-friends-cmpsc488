using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Test2
{
    [Serializable]
    class NPC
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
}
