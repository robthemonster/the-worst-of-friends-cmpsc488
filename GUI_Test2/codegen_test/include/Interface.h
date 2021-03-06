#pragma once
#include <SFML/Graphics.hpp>
class Player;
class FButton;
class AttributeMap;
class Game;
class Interface
{
	FButton * quit;
	FButton * continueGame;
	AttributeMap * attributeMap;
	sf::Font font;
	sf::RectangleShape pauseMenuRect;
	sf::RectangleShape fadeRect;
	bool paused = false;
	std::vector<std::string> visiblePlayerAttributes;
	std::vector <std::string> visibleGlobalAttributes;
public:
	bool getPaused();
	void setFont(sf::Font font);
	void setPaused(bool paused);
	void setContinueHightlight(bool set);
	void setQuitHighlight(bool set);
	bool quitHighlighted();
	bool continueHighlighted();
	void addVisiblePlayerAttribute(std::string key);
	void addVisibleGlobalAttributes(std::string key);
	void drawPauseMenu(sf::RenderWindow & window, sf::View & view, bool mouseMode);
	void drawPlayerAttributes(sf::RenderWindow & window, sf::View & view, Player * player, sf::Color playerColor);
	void drawGlobalAttributes(sf::RenderWindow & window, sf::View & view,Game * game, sf::Color globalColor);
	void displayPlayerTurnStart(sf::RenderWindow & window, sf::View & view, std::string playerName, sf::Color fill);
	void drawFade(sf::RenderWindow & window, sf::View & view,int millisecElapsed, bool increasing);

	Interface(AttributeMap * attributeMap);
	~Interface();
};

