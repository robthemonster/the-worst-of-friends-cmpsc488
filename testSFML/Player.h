#pragma once
#include <SFML/Graphics.hpp>
#include "Attributable.h"
class Player : public Attributable
{
private: 
	sf::Color playerColor;

public:
	sf::Color getPlayerColor();
	Player();
	Player(sf::Color playerColor);
	~Player();
};

