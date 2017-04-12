using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Test2
{
    [Serializable]
    public class Project
    {
        //public List<NPC> characters;
        public List<String> pathGroups;
        public List<String> hubs;
        //public List<P2PG> p2PG;
        public Dictionary<String, Navigable> navIndex;
        public String navigableName;
        public List<String> paths;
        public List<Attrib> attribs;
        public Dictionary<string, NPC> characters;
        public EndingGen endingGen;

        public Project()
        {
            pathGroups = new List<string>();
            hubs = new List<string>();
            navIndex = new Dictionary<String, Navigable>();
            navigableName = "";
            paths = new List<String>();
            attribs = new List<Attrib>();
            characters = new Dictionary<string, NPC>();
            endingGen = new EndingGen();
        }

        public Project(List<String> pg, List<String> h, Dictionary<String, Navigable> nI, string nN, List<String> p,List<Attrib> attribs, Dictionary<string, NPC> c, EndingGen eG)
        {
            pathGroups = pg;
            hubs = h;
            navIndex = nI;
            navigableName = nN;
            paths = p;
            this.attribs = attribs;
            characters = c;
            endingGen = eG;
        }
    }

    [Serializable]
    public static class Game
    {
        //public List<NPC> characters;
        //public Dictionary<String,Path> paths;
        public static List<String> pathGroups = new List<string>();
        public static List<String> hubs = new List<string>();
        //public List<P2PG> p2PG;
        public static Dictionary<String, Navigable> navIndex = new Dictionary<String, Navigable>();
        public static String navigableName = "";
        public static List<String> paths = new List<String>();
        public static EndingGen endingGen = new EndingGen();

        public static void init(List<String> pg, List<String> h, Dictionary<String, Navigable> nI, string nN, List<String> p, EndingGen eG)
        {
            pathGroups = pg;
            hubs = h;
            navIndex = nI;
            navigableName = nN;
            paths = p;
            endingGen = eG;
        }

        public static void setPathGroup(List<String> pg)
        {
            pathGroups = pg;
        }

        public static void setHubs(List<String> h)
        {
            hubs = h;
        }

        public static void setNavIndex(Dictionary<String, Navigable> nI)
        {
            navIndex = nI;
        }

        public static void setNavigableName(string nN)
        {
            navigableName = nN;
        }

        public static void setPaths(List<String> p)
        {
            paths = p;
        }

        public static void setEndingGenerator(EndingGen eg)
        {
            endingGen = eg;
        }

        public static void generateCode()
        {

            String vsCommandPath = System.Environment.GetEnvironmentVariable("windir") + "\\System32\\cmd.exe";
            String mainPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\codegen_test\\main.cpp";
            DirectoryInfo directory = Directory.GetParent(mainPath);

            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo f in files)
            {
                if (f.Name == "main.exe" || f.Name == "main.cpp")
                    f.Delete();
            }

            ProcessStartInfo cmd = new ProcessStartInfo(vsCommandPath);
            cmd.Arguments = @"/c cd " + directory + @"&& VC\bin\vcvars32 && VC\bin\cl /EHsc /I .\include /I .\SFML-2.4.2\include .\include\*.cpp  /link /LIBPATH:.\SFML-2.4.2\lib sfml-system.lib sfml-window.lib sfml-graphics.lib sfml-audio.lib sfml-network.lib ";
           
            Process compiler = Process.Start(cmd);
            compiler.WaitForExit();

            StreamWriter output = new StreamWriter(mainPath);
            string s = @"
                #include <SFML\Graphics.hpp>
#include <iostream>

#include <SFML/Audio.hpp>
#include <string>
#include <fstream>
#include <ctime>
#include <cstdlib>
#include <Windows.h>
#include <sstream>

#include ""Path.h""
#include ""PathGroup.h""
#include ""Character.h""
#include ""Requirements.h""
#include ""Game.h""
#include ""Player.h""
#include ""AttributeMap.h""
#include ""Hub.h""
#include ""Interface.h""
#include ""Impact.h""
#include ""MainMenu.h""

static float VIEW_HEIGHT = 1080.0f;
            static float VIEW_WIDTH = 1920.0f;
            sf::Vector2f dialoguePanePos(-750, 200);

            static std::vector<std::string> split(std::string str, char delimiter) {
                std::vector < std::string> internal;
	std::stringstream ss(str); // Turn the string into a stream.
        std::string tok;

	while (std::getline(ss, tok, delimiter)) {
		internal.push_back(tok);
    }

	return internal;
}

void resizeView(sf::RenderWindow& window, sf::View& view)
{
    float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
    std::cout << aspectRatio << std::endl;

    view.setSize(VIEW_WIDTH, VIEW_WIDTH * aspectRatio);
}






int main()
{

    /* sf::Font font;
	sf::Texture dialoguePaneTexture;
	sf::Vector2f dialoguePane(-750, 200);
	sf::Vector2f buttonSize(300, 100);
	sf::Vector2f button1Pos(-200, 300);
	sf::Vector2f button2Pos(200, 300);
	sf::Vector2f charPos(-650, -220);

	sf::Music witcher;
	witcher.openFromFile(""music/witcher.ogg"");
	witcher.setVolume(10);

	Character protag;
	
	protag.addCharacterImage(""happy"", ""img/characters/happy_face.png"");
	protag.addCharacterImage(""neutral"", ""img/characters/neutral_face.png"");
	protag.addCharacterImage(""sad"", ""img/characters/sad_face.png"");
	protag.addCharacterImage(""shocked"", ""img/characters/shocked_face.png"");


	font.loadFromFile(""fonts/8bit.ttf"");
	dialoguePaneTexture.loadFromFile(""img/dialoguePane.png"");

	std::string dialogueLines[7][2];
	
	dialogueLines[0][0] = ""Your family has been tasked with guarding a mysterious trap door for as far back as your family tree can be traced. The job has always been quiet and boring. But not today. Today you walked into the small shack containing the trap door to find your siblings scattered about the ground and the trap door flung open."";
	dialogueLines[0][1] = ""The sound of flesh upon flesh echoes up through the open door, to your horror. The groans and odors explain your siblings' unconscious state. As the noises get louder, you realize this is the moment your family has waited on for so many generations."";
	
	dialogueLines[1][0] = ""With no means of descending beyond the trap door, you leap into the darkness.  The fall is surprisingly short. You look around to get some sense of where you are and see nothing but rock formations from ground to ceiling.  The fleshy groans bounce off each structure and penetrate your ears."";
	dialogueLines[1][1] = ""A sense of knowing comes over you as you begin searching for your target; the instinct of your ancestors guides you. It is not long before you find that whatever abomination you search for is around the next rock formation."";

	dialogueLines[2][0] = ""You jump around the corner to start at the creature. It's so awful. Skinny, stick-like, and shrill in most areas, with folds of plump, loose skin in the worst places. It sees you before you make your next move and lunges as you, groaning its pleasureful disdain."";
	dialogueLines[2][1] = ""You side step the creature and it rushes past you into one of the rock structures, smashing through and causing the cave to begin to collapse. You make haste back to the trap door and make your way through, locking it tightly behind you. The ground shakes for the next day, and then nothing is ever heard from the trap door again."";

	dialogueLines[3][0] = ""Your keen senses quickly become overstimulated and anxiety takes hold. The growing stench of the creature begins the physical push that sends you rushing for the trap door. The creature clearly hears your retreat as the groans suddenly intensify and the echoes begin to creak about in new directions. You scream out in terror as you lunge your body upward and through the trap door, locking it tightly behind you."";
	dialogueLines[3][1] = ""Within moments, the slam from below reverberates out from the trap door. You are knocked to your feet and you see that your siblings are starting to rouse. They shout in confusion and look to you for answers, but you have none. The slamming continues daily until your death, when your duties are continued by your children."";

	dialogueLines[4][0] = ""You turn and run right back out the door as fast as you can. The groans are etched into your memory, as if new grooves have been carved into your ears such that every sound from now on will have the faint echo of that moment. You don't stop running until you encounter your cousin along the cliffs, beneath the village in the distance."";
	dialogueLines[4][1] = ""Your cousin asks why you aren't at the shack and you explain yourself. They look to the village in the distance and insist that you must warn them. They decide to head to the shack to try to control the damage. You could head to the village, or run farther way."";

	dialogueLines[5][0] = ""You make your way to the village in the cliffs. Everyone is going about their day, innocent to the horrors held within the shack. A mother holding her baby accidentally bumps into and apprehensively apologizes. You grab hold of her shoulders and tell her everyone you heard and smelled that day. She drops her baby and shrieks in horror."";
	dialogueLines[5][1] = ""The mother's shriek was the harbinger of the panic that shot through the village as your story spread. A mod stampeded out of the village as your cousin reemerged from the shack with the abomination from below in pursuit. The mass of villagers meeting with the creature had a gruesomely obvious climax before the creature fled. Haunted by the carnage, you hide from tales of the wandering abomination for the rest of your days."";

	dialogueLines[6][0] = ""The anxiety repulses you from the direction of the village. Instead, you keep running. First down the cliffs into the lowlands, then into the world beyond. You don't stop for at least a week before wondering what became of your cousin and the trap door. You rest for several days in a nearby village and wait for news."";
	dialogueLines[6][1] = ""Days go by before reports of your cousin, the hero, reach you. As it turns out, your cousin drew some abomination out of a cave system beneath the trap door, was chased by it out to the cliff where the village could see, and managed to side step at the last moment, sending it tumbling down the cliff. You never return to the shack and live elsewhere in shame for the rest of your days."";

	sf::Texture pathTextures[7];

	pathTextures[0].loadFromFile(""img/trap_door.jpg"");
	pathTextures[1].loadFromFile(""img/dark_cave.jpg"");
	pathTextures[2].loadFromFile(""img/cave_fight.jpg"");
	pathTextures[3].loadFromFile(""img/gray_funeral.jpg"");
	pathTextures[4].loadFromFile(""img/cliff_village.jpg"");
	pathTextures[5].loadFromFile(""img/cliff_village_interior.jpg"");
	pathTextures[6].loadFromFile(""img/jungle_village.jpg"");

	Path paths[7];

	for (int i = 0; i < 7; i++) {
		paths[i].setImageTexture(pathTextures[i]);
		paths[i].setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);
		paths[i].setButtonCharSize(40);
		paths[i].setButtonSize(buttonSize);
		paths[i].setFont(font);
	}


	
	paths[0].addDialogueLine(&DialogueLine(dialogueLines[0][0]));
	paths[0].addDialogueLine(&DialogueLine(dialogueLines[0][1], &protag, ""shocked"", charPos));

	paths[1].addDialogueLine(&DialogueLine(dialogueLines[1][0], &protag, ""neutral"", charPos));
	paths[1].addDialogueLine(&DialogueLine(dialogueLines[1][1]));

	paths[2].addDialogueLine(&DialogueLine(dialogueLines[2][0]));
	paths[2].addDialogueLine(&DialogueLine(dialogueLines[2][1], &protag, ""happy"", charPos));

	paths[3].addDialogueLine(&DialogueLine(dialogueLines[3][0], &protag, ""sad"", charPos));
	paths[3].addDialogueLine(&DialogueLine(dialogueLines[3][1]));

	paths[4].addDialogueLine(&DialogueLine(dialogueLines[4][0]));
	paths[4].addDialogueLine(&DialogueLine(dialogueLines[4][1], &protag, ""neutral"", charPos));

	paths[5].addDialogueLine(&DialogueLine(dialogueLines[5][0]));
	paths[5].addDialogueLine(&DialogueLine(dialogueLines[5][1], &protag, ""shocked"", charPos));

	paths[6].addDialogueLine(&DialogueLine(dialogueLines[6][0], &protag, ""sad"", charPos));
	paths[6].addDialogueLine(&DialogueLine(dialogueLines[6][1]));

	paths[0].setPrompt(""What do you do?"");
	paths[1].setPrompt(""What do you do?"");
	paths[4].setPrompt(""What do you do?"");

	paths[0].addButton(""Enter the Trap Door"", &paths[1], button1Pos);
	paths[0].addButton(""Flee the Shack"", &paths[4], button2Pos);

	paths[1].addButton(""Fight!"", &paths[2], button1Pos);
	paths[1].addButton(""Run!"", &paths[3], button2Pos);

	paths[4].addButton(""Warn the Village"", &paths[5], button1Pos);
	paths[4].addButton(""Keep Running"", &paths[6], button2Pos);


	paths[2].addButton(""Restart"", &paths[0], button1Pos);
	paths[3].addButton(""Restart"", &paths[0], button1Pos);
	paths[5].addButton(""Restart"", &paths[0], button1Pos);
	paths[6].addButton(""Restart"", &paths[0], button1Pos);


	sf::RenderWindow window(sf::VideoMode(1600, 900), ""Game Window"", sf::Style::Close | sf::Style::Resize);
	sf::View view(sf::Vector2f(0.0f, 0.0f), sf::Vector2f(VIEW_WIDTH, VIEW_HEIGHT));
	window.setView(view);

	witcher.play();
	paths[0].display(window, view);
	*/


    srand(time(NULL));



    sf::Texture buttonUnhighlight, buttonHighlight;

    buttonUnhighlight.loadFromFile(""img/button.png"");
    buttonHighlight.loadFromFile(""img/highlight.png"");

    sf::Font font;
    sf::Texture dialoguePane;
    sf::Vector2f dialoguePanePos(-750, 200);
    sf::Vector2f buttonSize(300, 100);
    sf::Vector2f button1Pos(-200, 300);
    sf::Vector2f button2Pos(200, 300);

    font.loadFromFile(""fonts/arial.ttf"");


    dialoguePane.loadFromFile(""img/dialoguePane.png"");






    std::vector < std::string> english, sentences;
    std::ifstream englishIn, sentencesIn;
    englishIn.open(""strings/words.txt"");
    sentencesIn.open(""strings/sentences.txt"");
    std::string word, sentence;
    while (englishIn >> word)
    {
        english.push_back(word);
    }
    while (std::getline(sentencesIn, sentence))
    {
        if (sentence.length() > 0 && sentence.length() < 200)
            sentences.push_back(sentence);
    }







    sf::Music songStream;
    songStream.setVolume(50);
    sf::Texture dialoguePaneTexture;

    dialoguePaneTexture.loadFromFile(""img/dialoguePane.png"");





    std::string imageFiles[] = { ""evil.jpg"",
        ""giant.jpg"",
        ""cold.jpg"",
        ""bastion.jpg"",
        ""satellites.jpg"",
        ""titan.jpg"",
        ""thumbsup.jpg"",
        ""sentry.jpg"",
        ""absolver.jpg"",
        ""scout.jpg"",
        ""jaguar.jpg"",
        ""sands.jpg"",
        ""shenfei.jpg"",
        ""church.jpg"",
        ""deer.jpg"",
        ""tower.jpg"",
        ""deserttemple.jpg"",
        ""bridge.jpg"",
        ""link.jpg"",
        ""wrath.jpg"" };

    sf::Texture* imageTextures = new sf::Texture[ARRAYSIZE(imageFiles)];

    for (int i = 0; i < ARRAYSIZE(imageFiles); i++)
    {
        if (!imageTextures[i].loadFromFile(""img/"" + imageFiles[i]))
            std::cout << imageFiles[i] << "" failed to load"" << std::endl;
    }




    Game* game = new Game(1);

    Requirements gameOver(*(*game).getAttributeMapPointer());
    gameOver.addRequirement((Attributable**)&game, ""day"", Requirements::GEQ, 4);

    (*game).setGameOverRequirements(&gameOver);

    PathGroup roundStart, roundEnd;
    std::vector<Path*> dayStart, dayEnd;
    std::vector<Requirements*> daysReq;

    roundStart.setTiers(3);
    roundEnd.setTiers(3);



    for (int i = 0; i < 3; i++)
    {
        daysReq.push_back(new Requirements(*(*game).getAttributeMapPointer()));
        (*daysReq[i]).addRequirement((Attributable**)&game, ""day"", Requirements::EQ, (i + 1));

        std::string start = ""Start of day "";
        start.append(std::to_string(i + 1));

        dayStart.push_back(new Path(game));
        (*dayStart[i]).setFont(font);
        (*dayStart[i]).setImageTexture(imageTextures[13]);
        (*dayStart[i]).addDialogueLine(start);
        (*dayStart[i]).setDialoguePaneTexture(dialoguePane, dialoguePanePos);
        roundStart.addPath(i, dayStart[i], 1, daysReq[i]);


        dayEnd.push_back(new Path(game));
        (*dayEnd[i]).setFont(font);
        (*dayEnd[i]).setImageTexture(imageTextures[13]);
        (*dayEnd[i]).addDialogueLine(""End of day "" + std::to_string(i + 1), (Attributable**)&game, ""day"", Impact::INCREASE, 1);
        (*dayEnd[i]).setDialoguePaneTexture(dialoguePane, dialoguePanePos);
        roundEnd.addPath(i, dayEnd[i], 1, daysReq[i]);
    }

    (*game).setStartOfRound(&roundStart);
    (*game).setEndOfRound(&roundEnd);



    Hub hub(game);
    Path left(game), right(game);
    PathGroup leftPg, rightPg;
    Path leftSucceed(game), leftFail(game);
    Path rightSucceed(game), rightFail(game);


    (*game).addGlobalAttribute(""day"", 1);

    (*game).addPlayerAttribute(""strength"", 5);
    (*game).addPlayerAttribute(""wisdom"", 5);
    (*game).addPlayerAttribute(""score"", 0);
    (*game).addPlayerAttribute(""passedTestOfStrength"", 0);
    (*game).addPlayerAttribute(""passedTestOfWisdom"", 0);

    (*game).addVisiblePlayerAttribute(""strength"");
    (*game).addVisiblePlayerAttribute(""wisdom"");
    (*game).addVisiblePlayerAttribute(""score"");
    (*game).setStart(&hub);


    leftPg.setTiers(2);
    rightPg.setTiers(2);

    hub.setMusic(songStream, ""music/quiet.ogg"");
    left.setMusic(songStream, ""music/waterfall.ogg"");
    right.setMusic(songStream, ""music/premonition.ogg"");


    leftSucceed.setButtonCharSize(40);
    leftSucceed.setButtonSize(buttonSize);
    leftSucceed.setFont(font);

    leftFail.setButtonCharSize(40);
    leftFail.setButtonSize(buttonSize);
    leftFail.setFont(font);

    rightSucceed.setButtonCharSize(40);
    rightSucceed.setButtonSize(buttonSize);
    rightSucceed.setFont(font);

    rightFail.setButtonCharSize(40);
    rightFail.setButtonSize(buttonSize);
    rightFail.setFont(font);

    left.setButtonCharSize(40);
    left.setFont(font);


    right.setButtonCharSize(40);
    right.setFont(font);

    left.setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);
    right.setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);
    leftSucceed.setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);
    leftFail.setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);
    rightSucceed.setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);
    rightFail.setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);


    left.setPrompt(""What do you do?"");
    left.addDialogueLine(""You will need 7 strength to proceed"");
    left.addButton("""", &leftPg, button1Pos, Path::BUTTON_HIGHLIGHT_IMAGE, &buttonUnhighlight, &buttonHighlight);

    right.addDialogueLine(""You will need 7 wisdom to proceed."");
    right.setPrompt(""What do you do?"");
    right.addButton(""Test your widsom"", &rightPg, button2Pos, Path::BUTTON_HIGHLIGHT_TEXT);

    Requirements noReq(*(*game).getAttributeMapPointer()), tenStrength(*(*game).getAttributeMapPointer()), tenWisdom(*(*game).getAttributeMapPointer());
    tenStrength.addRequirement((Attributable**)(*game).getCurrentPlayerPointer(), ""strength"", Requirements::GEQ, 7);
    tenWisdom.addRequirement((Attributable**)(*game).getCurrentPlayerPointer(), ""wisdom"", Requirements::GEQ, 7);


    leftPg.addPath(1, &leftSucceed, 1, &tenStrength);
    leftPg.addPath(0, &leftFail, 1, &noReq);

    rightPg.addPath(1, &rightSucceed, 1, &tenWisdom);
    rightPg.addPath(0, &rightFail, 1, &noReq);


    leftSucceed.addDialogueLine(""You succeeded by having 7 strength! +10 Points"", (Attributable**)(*game).getCurrentPlayerPointer(), ""score"", Impact::INCREASE, 10);
    rightSucceed.addDialogueLine(""You  succeeded by having 7 wisdom! +10 Points"", (Attributable**)(*game).getCurrentPlayerPointer(), ""score"", Impact::INCREASE, 10);
    leftFail.addDialogueLine(""You failed, but gained 1 strength in your efforts"", (Attributable**)(*game).getCurrentPlayerPointer(), ""strength"", Impact::INCREASE, 1);
    rightFail.addDialogueLine(""You failed, but gained 1 wisdom in your efforts"", (Attributable**)(*game).getCurrentPlayerPointer(), ""wisdom"", Impact::INCREASE, 1);



    leftSucceed.setImageTexture(imageTextures[8]);
    leftFail.setImageTexture(imageTextures[11]);
    rightSucceed.setImageTexture(imageTextures[10]);
    rightFail.setImageTexture(imageTextures[14]);
    left.setImageTexture(imageTextures[11]);
    right.setImageTexture(imageTextures[14]);




    sf::Vector2f leftPath(-650, -100), rightPath(200, -250);
    sf::Vector2f leftSize(250, 300), rightSize(700, 400);


    hub.setImageTexture(imageTextures[13]);
    hub.addButton(leftPath, leftSize, &left);
    hub.addButton(rightPath, rightSize, &right);



    Path goodEnding(game), badEnding(game);



    goodEnding.setFont(font);
    goodEnding.setImageTexture(imageTextures[3]);
    goodEnding.setDialoguePaneTexture(dialoguePane, dialoguePanePos);

    badEnding.setFont(font);
    badEnding.setImageTexture(imageTextures[4]);
    badEnding.setDialoguePaneTexture(dialoguePane, dialoguePanePos);

    Requirements twentyPoints(*(*game).getAttributeMapPointer());
    twentyPoints.addRequirement((Attributable**)(*game).getCurrentPlayerPointer(), ""score"", Requirements::GEQ, 10);

    goodEnding.addDialogueLine(""lmao gj u got the good ending"");
    badEnding.addDialogueLine(""o no u got the bad ending"");
    (*game).setEndingTiers(1);
    (*game).addEnding(0, &goodEnding, &twentyPoints);
    (*game).addEnding(0, &badEnding, &noReq);




    sf::RenderWindow gameWindow(sf::VideoMode(1600, 900), ""Game Window"", sf::Style::Close | sf::Style::Resize );
    sf::View view(sf::Vector2f(0.0f, 0.0f), sf::Vector2f(VIEW_WIDTH, VIEW_HEIGHT));
    gameWindow.setView(view);
    gameWindow.setFramerateLimit(60);






    (*game).setMainMenuImageTexture(imageTextures[10]);
    (*game).setMainMenuMusic(songStream, ""music/animalcrossing.ogg"");
    (*game).setMainMenuPlayButtonSound(""music/letsgo.wav"");
    (*game).setMenuFont(font);
    (*game).play(gameWindow, view);

    return 0;
    /*	


        Path * p = new Path[ARRAYSIZE(imageFiles)];

        for (int i = 0; i < ARRAYSIZE(imageFiles); i++) {

            p[i].setFont(font);
            p[i].setButtonCharSize(40);
            p[i].setButtonSize(buttonSize);
            p[i].setImageTexture(imageTextures[i]);
            p[i].setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);

            p[i].addButton(english[rand()%english.size()], &p[rand() % ARRAYSIZE(imageFiles)], button1Pos);
            p[i].addButton(english[rand() % english.size()], &p[rand() % ARRAYSIZE(imageFiles)], button2Pos);

            std::string prompt;
            while (prompt.size() < 10 || prompt.size() > 50)
            prompt = sentences[rand() % sentences.size()];

            if (prompt[prompt.size() - 1] == '.')
            prompt = prompt.substr(0, prompt.size() -1) + ""?"";

            p[i].setPrompt(prompt);

            std::string * dialogue = new std::string[2];
            for (int j = 0; j < 30; j++) {
                dialogue[0] += "" ""+ english[rand() % english.size()] ;
                dialogue[1] += "" "" + english[rand() % english.size()] ;
                if (j % 13 == 0 && j > 0) {
                    dialogue[0] += "","";
                    dialogue[1] += "","";
                }
                if (j % 7 == 0 && j > 0) {
                    dialogue[0] += ""."";
                    dialogue[1] += ""."";
                }
            }
            dialogue[0] = sentences[rand() % sentences.size()];
            dialogue[1] = sentences[rand() % sentences.size()];

            p[i].addDialogueLine(&DialogueLine(dialogue[0]));
            p[i].addDialogueLine(&DialogueLine(dialogue[1]));


        }



        Navigable * n = &p[rand() % ARRAYSIZE(imageFiles)];



        sf::RenderWindow gameWindow(sf::VideoMode(1600, 900), ""Game Window"", sf::Style::Close | sf::Style::Resize);
        sf::View view(sf::Vector2f(0.0f, 0.0f), sf::Vector2f(VIEW_WIDTH, VIEW_HEIGHT));
        gameWindow.setView(view);
        gameWindow.setFramerateLimit(60);

        song.play();
        (*n).display(gameWindow, view);*/


}
"; //TODO: fix
            output.WriteLine(s);
            output.Close();
            cmd.Arguments = @"/c cd " + directory + @" && VC\bin\vcvars32 && VC\bin\cl /EHsc /I .\include /I .\SFML-2.4.2\include main.cpp /link /LIBPATH:.\SFML-2.4.2\lib sfml-system.lib sfml-window.lib sfml-graphics.lib sfml-audio.lib sfml-network.lib /LIBPATH:.\ *.obj";
                            
            compiler = Process.Start(cmd);
            
            compiler.WaitForExit();

        

            foreach (FileInfo f in directory.GetFiles())
            {
                if (f.Extension == ".obj" || f.Name == "main.cpp" || (f.Extension == ".exe" && f.Name != "main.exe"))
                    f.Delete();
            }

            ProcessStartInfo game = new ProcessStartInfo(directory + "\\main.exe");
            game.WorkingDirectory = directory.ToString();
            Process gameProc = Process.Start(game);
            gameProc.WaitForExit();
            
       

        }
    }
}
