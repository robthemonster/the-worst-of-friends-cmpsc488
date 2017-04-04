#pragma once
#include "Attributable.h"
#include <SFML/Graphics.hpp>

class Player;
class AttributeMap;
class Navigable;
class Requirements;
class Interface;
class EndingGenerator;
class Path;
class MainMenu;
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
	
	EndingGenerator * ending;
	Requirements * gameOverRequirements;

	MainMenu * mainMenu;

	
	

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
	void setEndingTiers(int tiers);
	void addEnding(int tier, Path * end, Requirements * req);

	void setMainMenuImageTexture(sf::Texture & texture);
	void setMainMenuMusic(sf::Music & stream, std::string musicFile);
	void setMainMenuPlayButtonSound(std::string soundFile);
	


	~Game();
};

