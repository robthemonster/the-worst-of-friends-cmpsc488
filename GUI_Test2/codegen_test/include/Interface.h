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
	sf::Font font;
	sf::RectangleShape pauseMenuRect;
	bool paused = false;
	std::vector<std::string> visiblePlayerAttributes;
public:
	bool getPaused();
	void setFont(sf::Font font);
	void setPaused(bool paused);
	bool quitHighlighted();
	bool continueHighlighted();
	void addVisiblePlayerAttribute(std::string key);
	void drawPauseMenu(sf::RenderWindow & window, sf::View & view);
	void drawPlayerAttributes(sf::RenderWindow & window, sf::View & view, Player * player, sf::Color playerColor);
	Interface(AttributeMap * attributeMap);
	~Interface();
};

