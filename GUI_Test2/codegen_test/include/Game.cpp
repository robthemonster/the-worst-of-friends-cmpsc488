
#include "Player.h"
#include "Navigable.h"
#include "AttributeMap.h"
#include "Interface.h"
#include "EndingGenerator.h"
#include "Requirements.h"
#include "MainMenu.h"
#include "Game.h"

void Game::play(sf::RenderWindow & window, sf::View & view)
{
	while (window.isOpen()) {
		(*this->mainMenu).display(window, view, false);

		while (window.isOpen() && !(*this->gameOverRequirements).meetsAllRequirements()) {
			//start of round
			this->currPlayer = NULL;
			if (startOfRound != NULL)
				(*startOfRound).display(window, view, true);

			for (int i = 0; i < this->numPlayers; i++) {
				this->currPlayer = &players[i];
				if (this->numPlayers > 1)
					(*this->interfacePointer).displayPlayerTurnStart(window, view, "Player " + std::to_string(i + 1), (*currPlayer).getPlayerColor());
				(*this->start).display(window, view, true);
			}
			this->currPlayer = NULL;
			//end of round
			if (endOfRound != NULL)
				(*endOfRound).display(window, view, true);
		}
		
			for (int i = 0; i < this->numPlayers; i++) {
				this->currPlayer = &players[i];
				(*this->ending).display(window, view, true);
			
			
		}
			(*this->attributeMap).resetAttributes();
	}
}

Player ** Game::getCurrentPlayerPointer()
{
	return &this->currPlayer;
}

void Game::addPlayerAttribute(std::string key, int defaultValue)
{
	for (int i = 0; i < this->numPlayers; i++) {
		(*this->attributeMap).addAttribute(&players[i], key, defaultValue);
	}
}

Game::Game(int numberOfPlayers)
{
	sf::Color colors[4];
	colors[0] = sf::Color(255, 0, 0, 130);
	colors[1] = sf::Color(0, 255, 0, 130);
	colors[2] = sf::Color(0, 0, 255, 130);
	colors[3] = sf::Color(75, 0, 130, 130);

	this->attributeMap = new AttributeMap;
	this->interfacePointer = new Interface(attributeMap);
	this->players = new Player[numPlayers];
	this->ending = new EndingGenerator;
	this->mainMenu = new MainMenu(this);
	this->numPlayers = numberOfPlayers;
	this->gameOverRequirements = gameOverRequirements;

	for (int i = 0; i < numberOfPlayers; i++) {
		this->players[i] =  Player(colors[i]);
	}

	
}

Interface * Game::getInterfacePointer()
{
	return this->interfacePointer;
}

AttributeMap * Game::getAttributeMapPointer()
{
	return this->attributeMap;
}

void Game::setMenuFont(sf::Font font)
{
	(*this->interfacePointer).setFont(font);
	(*this->mainMenu).setFont(font);
}

void Game::setStart(Navigable * start)
{
	this->start = start;
}

void Game::setStartOfRound(Navigable * startOfRound)
{
	this->startOfRound = startOfRound;
}

void Game::setEndOfRound(Navigable * endOfRound)
{
	this->endOfRound = endOfRound;
}

void Game::setGameOverRequirements(Requirements * req)
{
	this->gameOverRequirements = req;
}

void Game::addVisiblePlayerAttribute(std::string key)
{
	(*this->interfacePointer).addVisiblePlayerAttribute(key);
}

void Game::addVisibleGlobalAttribute(std::string key)
{
	(*this->interfacePointer).addVisibleGlobalAttributes(key);
}

void Game::addGlobalAttribute(std::string key, int defaultValue)
{
	(*this->attributeMap).addAttribute((Attributable*)this, key, defaultValue);
}

void Game::setEndingTiers(int tiers)
{
	(*this->ending).setTiers(tiers);
}

void Game::addEnding(int tier, Path * end, Requirements * req)
{
	(*this->ending).addEnding(tier, end, req);
}

void Game::setMainMenuImageTexture(sf::Texture & texture)
{
	(*this->mainMenu).setImageTexture(texture);
}

void Game::setMainMenuMusic(sf::Music & stream, std::string musicFile)
{
	(*this->mainMenu).setMusicFile(stream, musicFile);
}

void Game::setMainMenuPlayButtonSound(std::string soundFile)
{
	(*this->mainMenu).setPlayGameSound(soundFile);
}





Game::~Game()
{
}
