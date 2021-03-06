#pragma once
#include <SFML\Graphics.hpp>
#include "Navigable.h"
class DialogueLine;
class ButtonScreen;
class Interface;
class Game;
class DialogueScreen:public Navigable
{
private:
	std::vector<DialogueLine > dialogue;
	sf::Vector2f textOrigin;
	sf::Font font;
	sf::RectangleShape imageRect, dialoguePaneRect, enterSymbol;
	Navigable ** destination = NULL;
	Game * game;
	const float SCREEN_WIDTH = 1920.0;
	const float SCREEN_HEIGHT = 1080.0;
public:
	void setTextOrigin(sf::Vector2f & origin);
	void setDestination(Navigable ** b);
	void setImageTexture(sf::Texture & texture);
	void setDialoguePaneTexture(sf::Texture & texture, sf::Vector2f position);
	void setEnterSymbolTexture(sf::Texture & texture);
	void setFont(sf::Font font);

	virtual void display(sf::RenderWindow& window, sf::View & view, bool fadeIn);

	void addDialogueLine(DialogueLine line);
	void resizeView(sf::RenderWindow& window, sf::View& view);

	DialogueScreen(Game * game);
	
	DialogueScreen(const DialogueScreen&);
	~DialogueScreen();
};

