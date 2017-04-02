#pragma once
#include "Navigable.h"

class Path;
class Requirements;
class EndingGenerator :public Navigable
{
private:
	std::vector<std::vector <std::tuple <Path *, Requirements * > > > endings;
public:
	void setTiers(int tiers);
	void addEnding(int tier, Path * path, Requirements * req);
	void display(sf::RenderWindow window, sf::View view);
	EndingGenerator();
	~EndingGenerator();
};