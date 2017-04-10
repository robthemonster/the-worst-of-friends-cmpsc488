using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Test2
{
    [Serializable]
    public class Attrib
    {
        public String name;
        public String hub;
        public int scope;
        public int value;
        public Attrib(String name, int scope, int value, string hub= "")
        {
            this.name = name;
            this.scope = scope;
            this.value = value;
            this.hub = hub;
        }
    }


    [Serializable]
    static class Attributes
    {
        public static List<Attrib> attribs = new List<Attrib>();

        

        public static bool Add(int scope, String name, int value,string hub="") {

            foreach (Attrib a in attribs)
            {
                if (a.name.Equals(name))
                {
                    return false;
                }
            }

            if (attribs.Count == 0)
            {
                attribs.Add(new Attrib(name, scope, value, hub));
            }
            else
            {
                bool inserted = false;
                for (int i=0; i<Attributes.attribs.Count;++i)
                {
                    if (name.CompareTo(Attributes.attribs[i].name) < 0&&!inserted)
                    {
                        Attributes.attribs.Insert(i, new Attrib(name, scope, value, hub));
                        inserted = true;
                        break;
                    }
                }
                if (!inserted)
                {
                    Attributes.attribs.Add(new Attrib(name, scope, value, hub));
                }
            }
            return true;

        }

        public static bool Remove(String name)
        {
            foreach (Attrib a in Attributes.attribs)
            {
                if (a.name.Equals(name))
                {
                    Attributes.attribs.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public static List<String> getScope(int scope, String hub = "")
        {
            List<String> resultList = new List<string>();
            
            foreach (Attrib a in Attributes.attribs)
            {
                if (a.scope == scope && a.hub.Equals(""))
                {
                    resultList.Add(a.name);
                }
            }
            
            if (scope==1 && !hub.Equals(""))
            {
                foreach (Attrib a in Attributes.attribs)
                {
                    if (a.scope == scope && a.hub.Equals(hub))
                    {
                        resultList.Add(a.name);
                    }
                }
            }
            return resultList;
        }

        public static Attrib get(string name)
        {
            foreach(Attrib a in Attributes.attribs)
            {
                if (a.name.Equals(name))
                {
                    return a;
                }
            }
            return null;
        }
    }
}
