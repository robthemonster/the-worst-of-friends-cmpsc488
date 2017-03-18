#include "Game.h"
#include "Player.h"
#include "Navigable.h"
#include "AttributeMap.h"
#include "Interface.h"

void Game::play(sf::RenderWindow & window, sf::View & view)
{
	while (window.isOpen()) {
		for (int i = 0; i < this->numPlayers; i++) {
			this->currPlayer = &players[i];
			(*this->start).display(window, view);
		}
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

Game::Game(int numberOfPlayers, Requirements * gameOverRequirements)
{
	sf::Color colors[4];
	colors[0] = sf::Color::Red;
	colors[1] = sf::Color::Blue;
	colors[2] = sf::Color::Green;
	colors[3] = sf::Color::Yellow;

	this->attributeMap = new AttributeMap;
	this->interfacePointer = new Interface(attributeMap);
	this->players = new Player[numPlayers];
	this->numPlayers = numberOfPlayers;
	this->gameOverRequirements = gameOverRequirements;

	for (int i = 0; i < numberOfPlayers; i++) {
		(*this->attributeMap).addAttribute((Attributable*)&this->players[i], "pnum", i + 1);
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

void Game::setStart(Navigable * start)
{
	this->start = start;
}

void Game::addVisiblePlayerAttribute(std::string key)
{
	(*this->interfacePointer).addVisiblePlayerAttribute(key);
}



Game::~Game()
{
}
