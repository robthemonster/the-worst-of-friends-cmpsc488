#pragma once
#include <SFML/Graphics.hpp>
class Player;
class FButton;
class AttributeMap;
class Interface
{
	FButton * quit;
	FButton * continueGame;
	AttributeMap * attributeMap;
	sf::RectangleShape pauseMenuRect;
	bool paused = false;
public:
	bool getPaused();
	void setPaused(bool paused);
	bool quitHighlighted();
	bool continueHighlighted();
	void drawPauseMenu(sf::RenderWindow & window, sf::View & view);
	void drawPlayerAttributes(sf::RenderWindow & window, sf::View & view, Player * player);
	Interface();
	~Interface();
};

