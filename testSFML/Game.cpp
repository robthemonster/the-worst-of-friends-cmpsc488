#include "Game.h"
#include "Player.h"
#include "Navigable.h"
#include "AttributeMap.h"


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

Game::Game(int numberOfPlayers, AttributeMap * attributeMap, Navigable * start, Requirements * gameOverRequirements)
{
	this->numPlayers = numberOfPlayers;
	this->players = new Player[numberOfPlayers];
	this->attributeMap = attributeMap;
	this->start = start;
	this->gameOverRequirements = gameOverRequirements;

	for (int i = 0; i < numberOfPlayers; i++) {
		(*this->attributeMap).addAttribute(&players[i], "pnum", i+1);
	}
}



Game::~Game()
{
}
