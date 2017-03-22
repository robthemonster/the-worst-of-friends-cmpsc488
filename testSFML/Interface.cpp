#include "Interface.h"
#include "FButton.h"
#include "AttributeMap.h"


bool Interface::getPaused()
{
	return this->paused;
}

void Interface::setPaused(bool paused)
{
	this->paused = paused;
}

bool Interface::quitHighlighted()
{
	return (*this->quit).isHighlighted();
}

bool Interface::continueHighlighted()
{
	return (*this->continueGame).isHighlighted();
}

void Interface::addVisiblePlayerAttribute(std::string key)
{
	this->visiblePlayerAttributes.push_back(key);
}

void Interface::drawPauseMenu(sf::RenderWindow & window, sf::View & view)
{
	if (paused) {
		this->pauseMenuRect.setPosition(0, 0);
		(*this->continueGame).setHighlighted((*this->continueGame).mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window))));
		(*this->quit).setHighlighted((*this->quit).mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window))));

		window.draw(pauseMenuRect);
		(*this->continueGame).draw(window, view);
		(*this->quit).draw(window, view);
	}
}

void Interface::drawPlayerAttributes(sf::RenderWindow & window, sf::View & view, Player * player, sf::Color playerColor)
{
	
	sf::Font font;
	font.loadFromFile("fonts/8bit.ttf");

	sf::Vector2f startPos(800, -300);
	sf::Vector2f currPos(startPos);

	sf::RectangleShape statPane;
	std::vector<sf::Text> stats;

	float maxSizeX = 0;
	for (int i = 0; i < this->visiblePlayerAttributes.size(); i++) {
		std::string attribute = this->visiblePlayerAttributes[i] + ": " + std::to_string((*this->attributeMap).getAttribute((Attributable *)player, this->visiblePlayerAttributes[i]));
		sf::Text currText(sf::String(attribute), font, 30);
		currText.setOutlineColor(sf::Color::Black);
		currText.setOutlineThickness(1);
		currText.setPosition(currPos);
		stats.push_back(currText);
		currPos.y += font.getLineSpacing(20);
		
		if (currText.getLocalBounds().width > maxSizeX)
			maxSizeX = currText.getLocalBounds().width;
	}
	statPane.setOrigin(sf::Vector2f(5, 0));
	statPane.setPosition(startPos);
	statPane.setSize(sf::Vector2f(maxSizeX*1.1, currPos.y - startPos.y + font.getLineSpacing(30)));
	statPane.setFillColor(playerColor);
	window.draw(statPane);
	for (int i = 0; i < stats.size(); i++) {
		window.draw(stats[i]);
	}

	

}

Interface::Interface(AttributeMap * attributeMap)
{
	this->attributeMap = attributeMap;
	this->pauseMenuRect = sf::RectangleShape(sf::Vector2f(600, 500));
	this->pauseMenuRect.setFillColor(sf::Color(255, 255, 255, 150));
	this->pauseMenuRect.setOutlineColor(sf::Color::White);
	this->pauseMenuRect.setOutlineThickness(2);
	this->pauseMenuRect.setOrigin(this->pauseMenuRect.getSize().x / 2, this->pauseMenuRect.getSize().y / 2);

	sf::Vector2f buttonSize(300, 200);
	sf::Vector2f continueButtonPosition(pauseMenuRect.getPosition().x - 40, pauseMenuRect.getPosition().y - 150);
	sf::Vector2f quitButtonPosition(pauseMenuRect.getPosition().x - 40, pauseMenuRect.getPosition().y + 150);
	
	this->font.loadFromFile("fonts/8bit.ttf");
	this->continueGame = new FButton(buttonSize, NULL, continueButtonPosition,"continue", font, 40);
	
	this->quit = new FButton(buttonSize, NULL, quitButtonPosition,"quit", font, 40);
}


Interface::~Interface()
{
	
}
