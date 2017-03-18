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
	this->attributeMap = new AttributeMap;
	this->interfacePointer = new Interface(attributeMap);

	this->numPlayers = numberOfPlayers;
	this->players = new Player[numberOfPlayers];
	this->gameOverRequirements = gameOverRequirements;

	for (int i = 0; i < numberOfPlayers; i++) {
		(*this->attributeMap).addAttribute(&players[i], "pnum", i+1);
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
