#pragma once
#include <SFML\Graphics.hpp>
class DialogueLine;
class ButtonScreen;
class DialogueScreen
{
private:
	std::vector<DialogueLine > dialogue;
	sf::Clock clock;
	sf::Vector2f textOrigin;
	sf::Texture image;
	sf::RectangleShape bg;
	ButtonScreen * destination;
	const float SCREEN_WIDTH = 1920.0;
	const float SCREEN_HEIGHT = 1080.0;
public:
	void setTextOrigin(sf::Vector2f & origin);
	void setDestination(ButtonScreen * b);
	void setImageTexture(sf::Texture & texture);
	void display(sf::RenderWindow& window, sf::View & view);
	void addDialogueLine(DialogueLine line);
	void resizeView(sf::RenderWindow& window, sf::View& view);
	DialogueScreen(sf::Texture & texture);

	DialogueScreen();
	
	DialogueScreen(const DialogueScreen&);
	~DialogueScreen();
};

