#include "PathGroup.h"
#include "Requirements.h"
#include "Path.h"
#include <iostream>

PathGroup::PathGroup()
{
}


PathGroup::~PathGroup()
{
}

void PathGroup::setTiers(int tiers)
{
	for (int i = 0; i <= tiers; i++) {
		paths.push_back(std::vector<std::tuple<Navigable *, int, Requirements*> >());
	}
}

void PathGroup::addNavigable(int tier, Navigable * path, int weight, Requirements * req )
{
	this->paths.at(tier).push_back(std::make_tuple(path, weight, req));
}

void PathGroup::display(sf::RenderWindow & window, sf::View & view, bool fadeIn)
{
	srand(time(NULL));

	int tierSum = 0;
	int selectedTier;
	Navigable * currPath;
	Requirements * currReq;
	if (paths.size() < 1) {
		std::cout << "No paths path group. Make sure you set tier # and insert paths" << std::endl;
		return;
	}

	for (int i = paths.size() -1; i >= 0 && tierSum == 0; i--) { //iterating down the tiers
		
		for (int j = 0; j < paths[i].size(); j++) { //iterating through paths in this tier
			currPath = std::get<0>(paths[i][j]);
			currReq = std::get<2>(paths[i][j]);
			if ((*currReq).meetsAllRequirements()) //requirements for this path are met
				tierSum += std::get<1>(paths[i][j]); //add weight to tierSum
		}
		selectedTier = i;
	}
	if (tierSum == 0) {
		std::cout << "No paths with met requirements found. Cannot proceed" << std::endl;
		return;
	}
	else {
		int randomIndex = rand() % tierSum;
		int runningTotal = 0;
		for (int i = 0; i < paths[selectedTier].size(); i++) {
			currPath = std::get<0>(paths[selectedTier][i]);
			currReq = std::get<2>(paths[selectedTier][i]);
			if ((*currReq).meetsAllRequirements()) {
				runningTotal += std::get<1>(paths[selectedTier][i]);
				if (randomIndex < runningTotal) {
					(*currPath).display(window, view, fadeIn);
					return;
				}

			}
		}
		
	}
}

