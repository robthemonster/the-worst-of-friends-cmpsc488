#include "Interface.h"
#include "FButton.h"
#include "AttributeMap.h"


bool Interface::getPaused()
{
	return this->paused;
}

void Interface::setFont(sf::Font font)
{
	sf::Vector2f buttonSize(300, 200);
	sf::Vector2f continueButtonPosition(pauseMenuRect.getPosition().x - 40, pauseMenuRect.getPosition().y - 150);
	sf::Vector2f quitButtonPosition(pauseMenuRect.getPosition().x - 40, pauseMenuRect.getPosition().y + 150);

	this->font = font;
	this->continueGame = new FButton(buttonSize, NULL, continueButtonPosition, FButton::HIGHLIGHT_TEXT, "continue", this->font, 40);

	this->quit = new FButton(buttonSize, NULL, quitButtonPosition, FButton::HIGHLIGHT_TEXT, "quit", this->font, 40);
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

void Interface::addVisibleGlobalAttributes(std::string key)
{
	this->visibleGlobalAttributes.push_back(key);
}

void Interface::drawPauseMenu(sf::RenderWindow & window, sf::View & view)
{
	if (paused) {
		this->pauseMenuRect.setPosition(0, 0);
		window.draw(pauseMenuRect);
		(*this->continueGame).draw(window, view);
		(*this->quit).draw(window, view);
	}
}

void Interface::drawPlayerAttributes(sf::RenderWindow & window, sf::View & view, Player * player, sf::Color playerColor)
{
	

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

void Interface::drawGlobalAttributes(sf::RenderWindow & window, sf::View & view, Game * game, sf::Color globalColor)
{
	sf::Vector2f pos(view.getSize().x * -0.45, view.getSize().y * -0.45);
	sf::Vector2f currPos(pos);

	sf::RectangleShape globalPane;
	std::vector<sf::Text> stats;

	float maxSizeX = 0;
	for (int i = 0; i < this->visibleGlobalAttributes.size(); i++) {
		std::string attribute = this->visibleGlobalAttributes[i] + ": " + std::to_string((*this->attributeMap).getAttribute((Attributable *)game, this->visibleGlobalAttributes[i]));
		sf::Text currText(sf::String(attribute), font, 30);
		currText.setOutlineColor(sf::Color::Black);
		currText.setOutlineThickness(1);
		currText.setPosition(currPos);
		stats.push_back(currText);
		currPos.y += font.getLineSpacing(20);

		if (currText.getLocalBounds().width > maxSizeX)
			maxSizeX = currText.getLocalBounds().width;
	}

	globalPane.setOrigin(sf::Vector2f(5, 0));
	globalPane.setPosition(pos);
	globalPane.setSize(sf::Vector2f(maxSizeX*1.1, currPos.y - pos.y + font.getLineSpacing(30)));
	globalPane.setFillColor(globalColor);
	window.draw(globalPane);
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

	
	
	
}


Interface::~Interface()
{
	
}
