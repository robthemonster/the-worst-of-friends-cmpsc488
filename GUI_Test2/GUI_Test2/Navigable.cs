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

    public class Path : Navigable {
        public string name;
        public List <String> dialogueNames;
        public List<String> dialogueContents;
        //public List<Button> buttons;

        public Path() {
        }
        public Path(String n, List<String> names, List<String> contents) {
            name = n;
            dialogueNames = names;
            dialogueContents = contents;
            //buttons = btons;
        }
    }
    public class Dialogue {
        public string name;
        public string content;
        public List<Impact> impacts;
    }
    public class Impact {
        public string attribute;
        public char sym;
        public string val;
    }

    public class Hub : Navigable {
        public string name;
        public List<Button> buttons;
        //img, sound
    }

    public class Button {
        //text,X,Y, NavRef ,Picname
        public string text;
        public int x;
        public int y;
        public Navigable next;
        //img,sound
    }
    public class PathGroup : Navigable {
        public string name;
        public Navigable nextDefault;

        //public Navigable getNext();
    }
    public class P2PG{
        public Path path;
        public PathGroup pathGroup;
        public int tier;
        public byte weight;
        public PathCondition condition;
    }
    public class PathCondition {
        public List<Path> prereqs;
        public List<Comparison> comparison;
    }
    public class Comparison {
        public string stat;
        public string suffix;
        public dynamic val;
        public string stat2;
    }
    public class Attrib
    {
        public string name;
        public int scope;
    }

}
