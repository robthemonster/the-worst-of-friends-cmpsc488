#include "Player.h"



Player::Player() {

}

sf::Color Player::getPlayerColor()
{
	return this->playerColor;
}

Player::Player(sf::Color playerColor)
{
	this->playerColor = playerColor;
}

Player::~Player()
{
}
