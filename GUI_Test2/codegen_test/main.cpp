#include "Game.h"
#include "Path.h"
#include "PathGroup.h"
#include "Hub.h"
#include "Requirements.h"
#include "Impact.h"
#include "Character.h"
#include <iostream>

static float VIEW_HEIGHT = 1080.0f;
static float VIEW_WIDTH = 1920.0f;

int main() {
Game * game = new Game(1);
sf::Music music;
sf::Texture texture0;
if (!texture0.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/img0.jpg"))
 std::cout<< "Error loading image file" << std::endl;
sf::Texture texture1;
if (!texture1.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/img1.jpg"))
 std::cout<< "Error loading image file" << std::endl;
sf::Texture texture2;
if (!texture2.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/img2.jpg"))
 std::cout<< "Error loading image file" << std::endl;
sf::Texture texture3;
if (!texture3.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/img3.jpg"))
 std::cout<< "Error loading image file" << std::endl;
sf::Texture texture4;
if (!texture4.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/img4.jpg"))
 std::cout<< "Error loading image file" << std::endl;
sf::Texture texture5;
if (!texture5.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/menuImage.jpg"))
 std::cout<< "Error loading image file" << std::endl;
sf::Texture texture6;
if (!texture6.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/defaultDialoguePane.png"))
 std::cout<< "Error loading image file" << std::endl;
sf::Font font0;
if (!font0.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/fonts/menuFont.otf"))
	std::cout << "Error loading font file" << std::endl;
sf::Font font1;
if (!font1.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/fonts/defaultFont.ttf"))
	std::cout << "Error loading font file" << std::endl;
sf::Texture menuImage;
if (!menuImage.loadFromFile("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/menuImage.jpg"))
 std::cout<< "Error loading image file" << std::endl;

Path * nav0 = new Path(game);
Path * nav1 = new Path(game);
PathGroup * nav2= new PathGroup;
PathGroup * nav3= new PathGroup;
Path * nav4 = new Path(game);
Path * nav5 = new Path(game);
Hub * nav6= new Hub(game);

Requirements noReq(*(*game).getAttributeMapPointer());
(*nav2).setTiers(0);
(*nav2).addNavigable(0, nav5, 1, &noReq);
(*nav3).setTiers(-1);

(*game).setStart(nav6);
(*game).setStartOfRound(nav2);
(*game).setEndOfRound(nav3);
Requirements gameOver(*(*game).getAttributeMapPointer());
gameOver.addRequirement((Attributable**)&game, "Grundle", Requirements::GEQ, 2);
(*game).setGameOverRequirements(&gameOver);
(*game).setMenuFont(font0);
(*game).setMainMenuImageTexture(texture5);
(*game).setMainMenuMusic(music, "G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/music/menuMusic.ogg");
(*game).setMainMenuPlayButtonSound("G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/music/menuPressPlay.wav");

(*game).addGlobalAttribute("Grundle", 0);
(*game).addVisibleGlobalAttribute("Grundle");
(*game).addPlayerAttribute("trea", 0);
(*game).addVisiblePlayerAttribute("trea");

(*nav0).setFont(font1);
(*nav0).setFontCharSize(30);
(*nav1).setFont(font1);
(*nav1).setFontCharSize(30);
(*nav4).setFont(font1);
(*nav4).setFontCharSize(30);
(*nav5).setFont(font1);
(*nav5).setFontCharSize(30);
(*nav6).setFont(font1);
(*nav6).setFontCharSize(30);

(*nav6).addButton(sf::Vector2f(300, 100),"button text", nav0, sf::Vector2f(-200, 0), 1, NULL, NULL);

(*nav0).setImageTexture(texture0);
(*nav1).setImageTexture(texture1);
(*nav4).setImageTexture(texture2);
(*nav5).setImageTexture(texture3);
(*nav6).setImageTexture(texture4);

(*nav0).setDialoguePaneTexture(texture6, sf::Vector2f(-750, 200));
(*nav1).setDialoguePaneTexture(texture6, sf::Vector2f(-750, 200));
(*nav4).setDialoguePaneTexture(texture6, sf::Vector2f(-750, 200));
(*nav5).setDialoguePaneTexture(texture6, sf::Vector2f(-750, 200));

Character * character0 = new Character;
(*character0).addCharacterImage("1","G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/character0.png");
(*character0).addCharacterImage("2","G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/character1.png");
Character * character1 = new Character;
(*character1).addCharacterImage("happy","G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/character2.png");
(*character1).addCharacterImage("sad","G:/Repos/the-worst-of-friends-cmpsc488/GUI_Test2/codegen_test/assets/img/character3.png");

std::vector<Impact *> impacts0 = std::vector<Impact *>();
impacts0.push_back(new Impact((*game).getAttributeMapPointer(), (Attributable**)&game, "Grundle", Impact::INCREASE, 1));
(*nav0).addDialogueLine("hisuhe", impacts0);
(*nav0).addDialogueLine("gdsg");
(*nav1).addDialogueLine("FDSFDS");
std::vector<Impact *> impacts1 = std::vector<Impact *>();
impacts1.push_back(new Impact((*game).getAttributeMapPointer(), (Attributable**)(*game).getCurrentPlayerPointer(), "trea", Impact::INCREASE, 0));
(*nav4).addDialogueLine("afsadfa", impacts1);
std::vector<Impact *> impacts2 = std::vector<Impact *>();
impacts2.push_back(new Impact((*game).getAttributeMapPointer(), (Attributable**)&game, "Grundle", Impact::INCREASE, 0));
(*nav4).addDialogueLine("rewqre", impacts2);
std::vector<Impact *> impacts3 = std::vector<Impact *>();
impacts3.push_back(new Impact((*game).getAttributeMapPointer(), (Attributable**)&game, "Grundle", Impact::INCREASE, 1));
(*nav5).addDialogueLine("day 1 start", impacts3);


sf::RenderWindow window(sf::VideoMode::getDesktopMode(), "Game Window", sf::Style::None);
        sf::View view(sf::Vector2f(0.0f, 0.0f), sf::Vector2f(VIEW_WIDTH, VIEW_HEIGHT));
        window.setView(view);
        window.setFramerateLimit(60);

       
        (*game).play(window, view);
}

