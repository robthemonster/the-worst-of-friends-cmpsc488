using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Test2
{

    
    public interface Navigable
    {
        String getName();
        Boolean isPathGroup();
    }
    [Serializable]
    public class Path : Navigable {
        public string name;
        public List <String> dialogueNames;
        public List<String> dialogueContents;
        public List<Button> buttons;
        //public List<Button> buttons;

        public Path() {}

        public Path(String n, List<String> names, List<String> contents,List<Button> btns) {
            name = n;
            dialogueNames = names;
            dialogueContents = contents;
            //List<int, int> appl;
            buttons = btns;
            //buttons = btons;
        }

        public String getName() { return name; }
        public Boolean isPathGroup() { return false; }
    }

    [Serializable]
    public class Dialogue {
        public string name;
        public string content;
        public List<Impact> impacts;
    }

    [Serializable]
    public class Impact {
        public string attribute;
        public char sym;
        public string val;
    }

    [Serializable]
    public class Hub : Navigable {
        public string name;
        public List<Button> buttons;
        //public something image;
        //public something sound;
        public String getName() { return name; }
        public Boolean isPathGroup() { return false; }
    }

    [Serializable]
    public class Button {
        //text,X,Y, NavRef ,Picname
        public string text;
        public int x;
        public int y;
        public Navigable next;
        //img,sound
    }

    [Serializable]
    public class PathGroup : Navigable {
        public String name;
        public List<List<PathCondition>> pathConds;
        public List<String> pathsInGroup;
        public List<int> weights;
        public List<int> tiers;
        //public Navigable nextDefault;
        //public Navigable getNext();

        public PathGroup() { }
        public PathGroup(String n, List<String> pIG, List<int>w, List<int> t)
        {
            name = n;
            pathsInGroup = pIG;
            weights = w;
            tiers = t;
        }
        public String getName() { return name; }
        public Boolean isPathGroup() { return true; }
    }

    //Attributes is its own class

    [Serializable]
    public class P2PG{
        public Path path;
        public PathGroup pathGroup;
        public int tier;
        public byte weight;
        public PathCondition condition;
    }

    [Serializable]
    public class PathCondition {
        //public List<Path> prereqs;
        public List<Comparison> comparison;
    }

    [Serializable]
    public class Comparison {
        public string stat;
        public List<string> names;
        public List<int> scopes;
    }

}



