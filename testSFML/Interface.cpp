#include "Interface.h"
#include "FButton.h"


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

Interface::Interface()
{
	this->pauseMenuRect = sf::RectangleShape(sf::Vector2f(600, 500));
	this->pauseMenuRect.setFillColor(sf::Color(255, 255, 255, 150));
	this->pauseMenuRect.setOutlineColor(sf::Color::White);
	this->pauseMenuRect.setOutlineThickness(2);
	this->pauseMenuRect.setOrigin(this->pauseMenuRect.getSize().x / 2, this->pauseMenuRect.getSize().y / 2);

	sf::Vector2f buttonSize(300, 200);
	sf::Vector2f continueButtonPosition(pauseMenuRect.getPosition().x - 40, pauseMenuRect.getPosition().y - 150);
	sf::Vector2f quitButtonPosition(pauseMenuRect.getPosition().x - 40, pauseMenuRect.getPosition().y + 150);
	sf::Font * font = new sf::Font;
	(*font).loadFromFile("fonts/8bit.ttf");
	this->continueGame = new FButton(buttonSize, NULL, continueButtonPosition, sf::Text(sf::String("continue"), *font, 40));
	
	this->quit = new FButton(buttonSize, NULL, quitButtonPosition, sf::Text(sf::String("quit"), *font, 40));
}


Interface::~Interface()
{
	
}
