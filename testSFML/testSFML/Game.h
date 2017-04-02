#pragma once
#include "Attributable.h"
#include <SFML/Graphics.hpp>

class Player;
class AttributeMap;
class Navigable;
class Requirements;
class Interface;
class Game : public Attributable
{
private:
	int numPlayers;
	Player * players;
	Player * currPlayer;
	AttributeMap * attributeMap;
	Interface * interfacePointer;
	Navigable * start;
	
	Navigable * startOfRound;
	Navigable * endOfRound;
	
	Requirements * gameOverRequirements;

	
	

	public:
	void play(sf::RenderWindow & window, sf::View & view); 
	Player ** getCurrentPlayerPointer();
	void addPlayerAttribute(std::string key, int defaultValue);
	Game(int numberOfPlayers);
	Interface * getInterfacePointer();
	AttributeMap * getAttributeMapPointer();
	void setStart(Navigable * start);
	void setStartOfRound(Navigable * startOfRound);
	void setEndOfRound(Navigable * endOfRound);
	void setGameOverRequirements(Requirements * req);
	void addVisiblePlayerAttribute(std::string key);
	void addGlobalAttribute(std::string key, int defaultValue);


	~Game();
};

