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
    }
    [Serializable]
    public class Path : Navigable {
        public string name;
        public List <String> dialogueNames;
        public List<String> dialogueContents;
        public List<Button> buttons;
        //public List<Button> buttons;

        public Path() {
        }
        public Path(String n, List<String> names, List<String> contents,List<Button> btns) {
            name = n;
            dialogueNames = names;
            dialogueContents = contents;
            //List<int, int> appl;
            buttons = btns;
            //buttons = btons;
        }
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
        //img, sound
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
        public string name;
        public Navigable nextDefault;

        //public Navigable getNext();
    }

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
        public List<Path> prereqs;
        public List<Comparison> comparison;
    }

    [Serializable]
    public class Comparison {
        public string stat;
        public string suffix;
        public dynamic val;
        public string stat2;
    }

    [Serializable]
    public class Attribs
    {
        public List<string> names;
        public List<int> scopes;
    }

}
