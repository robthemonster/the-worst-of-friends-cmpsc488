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
        public List<String> dialogueContents;
        public List<List<Impact>> dialogueImpactList;
        public List<Button> buttons;
        //public List<Button> buttons;

        public Path() {}

        public Path(String n,  List<String> contents,List<Button> btns, List<List<Impact>> dIL) {
            name = n;
            dialogueContents = contents;
            dialogueImpactList=dIL;
            buttons = btns;
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
        public int scope;
        public string attribute;
        public string hub;
        public int op; //0 = "=", 1 = "-", 2 = "+"
        public int val;
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
        public int sizeX;
        public int sizeY;
        public int posX;
        public int posY;
        public string pic1path;
        public string pic2path;
        public int highlight; //2 picture, 1 text, 0 neither
        public string next;
        //img,sound

        public Button()
        {
            text = "";
            sizeX = 0;
            sizeY = 0;
            posX = 0;
            posY = 0;
            pic1path = "";
            pic2path = "";
            highlight = 0;
            next = "";
        }

        public Button(string t, int sX, int sY, int pX, int pY, string p1p, string p2p, int h, string n)
        {
            text = t;
            sizeX = sX;
            sizeY = sY;
            posX = pX;
            posY = pY;
            pic1path = p1p;
            pic2path = p2p;
            highlight = h;
            next = n;
        }
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



