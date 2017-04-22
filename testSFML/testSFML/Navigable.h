#pragma once
#include <SFML/Graphics.hpp>
#include <SFML/Audio.hpp>
class Navigable
{
private:

public:
	virtual void display(sf::RenderWindow &window, sf::View &view, bool fadeIn) = 0;
	 ~Navigable();
};

