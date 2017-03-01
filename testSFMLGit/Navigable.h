#pragma once
#include <SFML/Graphics.hpp>
class Navigable
{
private:

public:
	virtual void display(sf::RenderWindow &window, sf::View &view) = 0;
	 ~Navigable();
};

