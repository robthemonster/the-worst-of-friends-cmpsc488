#pragma once
#include <set>
#include <tuple>
#include <vector>
#include "Navigable.h"
class Path;
class Requirements;
class PathGroup: public Navigable
{
private:
	std::vector< std::vector< std::tuple< Path* ,int , Requirements* > > > paths; //tiers of <path, weight, requirements>
public:
	PathGroup();
	~PathGroup();
	void setTiers(int tiers);
	void addPath(int tier, Path * path, int weight, Requirements * req);
	void display(sf::RenderWindow & window, sf::View & view);
};

