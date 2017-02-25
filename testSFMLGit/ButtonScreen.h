#pragma once
#include <SFML\Graphics.hpp>
#include "Navigable.h"

class FButton;
class DialogueScreen;
class ButtonScreen:public Navigable
{

public:
	sf::RectangleShape imageRect;
	sf::RectangleShape dialoguePane;
	sf::Text promptText;

	std::vector<FButton * >  buttons;
	 DialogueScreen * destination;
	const float SCREEN_WIDTH = 1920.0;
	const float SCREEN_HEIGHT = 1080.0;


	ButtonScreen(sf::Texture & imageTexture, sf::Texture & textPaneTexture, sf::Vector2f dialoguePanePos, sf::Text prompt);
	ButtonScreen();
	void setImageTexture(sf::Texture & texture);
	void setDialoguePaneTexture(sf::Texture & texture, sf::Vector2f dialoguePanePos);
	void setPrompt(sf::Text text);
	ButtonScreen(const ButtonScreen&);
	~ButtonScreen();
	void addButton(FButton * button);

	virtual void display(sf::RenderWindow & window, sf::View & view) ;
	

	void resizeView(sf::RenderWindow &, sf::View&, sf::RectangleShape&);

};

