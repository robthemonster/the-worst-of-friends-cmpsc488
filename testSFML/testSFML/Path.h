#pragma once
#include "Navigable.h"
class DialogueLine;
class FButton;
class DialogueScreen;
class ButtonScreen;
class Interface;
class Game;
class Impact;
class Attributable;
class Character;
class Path : public Navigable 
{
private:
	DialogueScreen * dialogueScreen;
	ButtonScreen * buttonScreen;
	int buttonCharSize;
	sf::Font font;
	sf::Vector2f dialoguePanePosition;
	std::string musicFile = "";
	bool hasMusic = false;
	sf::Music * music = NULL;
	Game * game;
public:
	static const int BUTTON_HIGHLIGHT_IMAGE = 2, BUTTON_HIGHLIGHT_TEXT = 1, BUTTON_DO_NOTHING = 0;

	void display(sf::RenderWindow & window, sf::View & view);
	void setImageTexture(sf::Texture &);
	void setDialoguePaneTexture(sf::Texture & texture, sf::Vector2f position);
	void addDialogueLine(std::string);
	void addDialogueLine(std::string, std::vector<Impact *>,
		Character * character = NULL, std::string key = "" , sf::Vector2f charPos = sf::Vector2f());
	void addDialogueLine(std::string, Attributable ** target, std::string key, int op, int val);
	
	void setFontCharSize(int size);
	void addButton(sf::Vector2f buttonSize, std::string buttonText, Navigable * target, sf::Vector2f position, int highlightMode,  sf::Texture * buttonTexture = NULL, sf::Texture * highlightTexture = NULL);
	void setPrompt(std::string prompt);
	void setFont(sf::Font font);
	void setMusic(sf::Music & music, std::string fileName);
	void setDestination(Navigable ** destination);

	Path(Game * game);
	~Path();
};

