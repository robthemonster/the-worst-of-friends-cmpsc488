#pragma once
#include <SFML/Graphics.hpp>
#include <SFML/Audio.hpp>
class Navigable
{
private:

public:
	virtual void display(sf::RenderWindow &window, sf::View &view) = 0;
	 ~Navigable();
};

