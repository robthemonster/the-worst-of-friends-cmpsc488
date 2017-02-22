#pragma once
#include <SFML\Graphics.hpp>


class FButton;
class DialogueScreen;
class ButtonScreen
{
public:
	sf::RectangleShape imageRect;
	sf::Texture imageTexture;

	std::vector<FButton * >  buttons;
	 DialogueScreen * destination;
	const float SCREEN_WIDTH = 1920.0;
	const float SCREEN_HEIGHT = 1080.0;


	ButtonScreen(sf::Texture & texture);
	ButtonScreen(const ButtonScreen&);
	~ButtonScreen();
	void addButton(FButton * button);
	void display(sf::RenderWindow & window, sf::View & view);
	void resizeView(sf::RenderWindow &, sf::View&, sf::RectangleShape&);
};

