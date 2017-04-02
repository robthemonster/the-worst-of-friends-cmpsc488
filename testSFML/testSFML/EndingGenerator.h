#pragma once
#include "Navigable.h"

class Path;
class Requirements;
class EndingGenerator :public Navigable
{
private:
	std::vector<std::vector <std::tuple <Path *, Requirements * > > > endings;
public:
	void display(sf::RenderWindow window, sf::View view);
	EndingGenerator();
	~EndingGenerator();
};