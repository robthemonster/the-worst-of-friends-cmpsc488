#pragma once
#include <SFML\Graphics.hpp>
#include "Navigable.h"
class DialogueLine;
class ButtonScreen;
class Interface;
class DialogueScreen:public Navigable
{
private:
	std::vector<DialogueLine > dialogue;
	sf::Vector2f textOrigin;
	sf::Font font;
	sf::RectangleShape imageRect, dialoguePaneRect;
	ButtonScreen ** destination;
	Interface * interfacePointer;

	const float SCREEN_WIDTH = 1920.0;
	const float SCREEN_HEIGHT = 1080.0;
public:
	void setTextOrigin(sf::Vector2f & origin);
	void setDestination(ButtonScreen ** b);
	void setImageTexture(sf::Texture & texture);
	void setDialoguePaneTexture(sf::Texture & texture, sf::Vector2f position);
	void setFont(sf::Font font);

	virtual void display(sf::RenderWindow& window, sf::View & view);

	void addDialogueLine(DialogueLine line);
	void resizeView(sf::RenderWindow& window, sf::View& view);

	DialogueScreen(Interface * interfacePointer);
	
	DialogueScreen(const DialogueScreen&);
	~DialogueScreen();
};

