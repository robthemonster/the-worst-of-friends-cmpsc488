#include <vector>
#include "Requirements.h"
#include "Path.h"
#include "EndingGenerator.h"



void EndingGenerator::setTiers(int tiers)
{
	for (int i = 0; i < tiers; i++) {
		this->endings.push_back(std::vector<std::tuple<Path*, Requirements* > >());
	}
}

void EndingGenerator::addEnding(int tier, Path * path, Requirements * req)
{
	this->endings[tier].push_back(std::make_tuple(path, req));
}

void EndingGenerator::display(sf::RenderWindow & window, sf::View & view)
{
	Path * first = NULL, *curr = NULL, *last = NULL;
	Requirements * currReq;
	for (int i = 0; i < this->endings.size(); i++) {
		for (int j = 0; j < this->endings[i].size(); j++) {
			currReq = std::get<1>(this->endings[i][j]);
			if ((*currReq).meetsAllRequirements()) {
				curr = std::get<0>(this->endings[i][j]);
				if (first == NULL)
					first = curr;
				break;
			}
		}

		if (last != NULL && curr != NULL) {
			(*last).setDestination((Navigable**)&curr);
			last = curr;
		}
	}
	if (first != NULL)
		(*first).display(window, view);
}

EndingGenerator::EndingGenerator()
{
}


EndingGenerator::~EndingGenerator()
{
}
