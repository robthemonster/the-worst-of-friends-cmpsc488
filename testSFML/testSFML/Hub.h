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
	bool hasMusic = false;
	Game * game;
public:
	void addButton(sf::Vector2f position, sf::Vector2f size, Navigable * target);
	void setImageTexture(sf::Texture & texture);
	void display(sf::RenderWindow & window, sf::View & view);
	void setMusic(sf::Music & music, std::string fileName);
	Hub(Game * game);
	~Hub();
};

