#pragma once
#include "Navigable.h"
#include "Attributable.h"
class ButtonScreen;
class Interface;
class Game;
class Hub :
	public Navigable, public Attributable
{
private:
	//test comment
	ButtonScreen * buttonScreen;
	sf::Music * music;
	std::string musicFile = "";
	sf::Font buttonFont;
	int buttonFontCharSize;
	bool hasMusic = false;
	Game * game;
public:
	void addButton(sf::Vector2f buttonSize, std::string buttonText, Navigable * target, sf::Vector2f position, int highlightMode,  sf::Texture * buttonTexture = NULL, sf::Texture * highlightTexture = NULL);
	void setImageTexture(sf::Texture & texture);
	void display(sf::RenderWindow & window, sf::View & view);
	void setMusic(sf::Music & music, std::string fileName);
	void setFont(sf::Font font);
	void setFontCharSize(int charSize);
	Hub(Game * game);
	~Hub();
};

