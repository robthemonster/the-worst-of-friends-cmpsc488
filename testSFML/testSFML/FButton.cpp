#include "FButton.h"
#include <iostream>




void FButton::draw(sf::RenderWindow& window, sf::View& view) {
	setHighlighted(this->mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window))));

		window.draw(this->buttonRect);
		window.draw(this->buttonText);
		window.draw(this->highlightRect);
	
	
}

bool FButton::mouseOver(sf::Vector2f mouseLocation) {
	return this->buttonRect.getGlobalBounds().contains(mouseLocation.x, mouseLocation.y) || this->buttonText.getGlobalBounds().contains(mouseLocation.x, mouseLocation.y);

	
}

void FButton::setHighlighted(bool highlighted) {
	if (highlighted) {
		if (buttonRect.getTexture() == NULL) {
			if (buttonText.getString().getSize() == 0)
				buttonRect.setOutlineColor(sf::Color::Yellow);
			else
				buttonText.setFillColor(sf::Color(255, 255, 0, 255));
		
		}
		else
		{
			highlightRect.setFillColor(sf::Color(255, 255, 0, 90));
		}
	}else {
		if (buttonText.getString().getSize() == 0 && buttonRect.getTexture() == NULL)
			buttonRect.setOutlineColor(sf::Color::Black);
		buttonText.setFillColor(sf::Color::White);
		highlightRect.setFillColor(sf::Color::Transparent);
	}


	this->highlighted = highlighted;
}

void FButton::setPosition(float x, float y)
{
	this->buttonRect.setPosition(x, y);
	this->buttonText.setPosition(x, y);
	this->highlightRect.setPosition(x, y);
}

bool FButton::isHighlighted()
{
	return highlighted;
}

Navigable * FButton::getTarget() {
	return this->target;
}

FButton::~FButton() {
	
}

FButton::FButton(sf::Vector2f & size,  Navigable * target, sf::Vector2f &position, 
	std::string buttonText, sf::Font font, int charSize, sf::Texture * buttonTexture) {

	this->target = target;
	this->buttonRect = sf::RectangleShape(size);

	this->buttonRect.setPosition(position);
	this->buttonRect.setTexture(buttonTexture);
	this->highlightRect = sf::RectangleShape(size);
	this->highlightRect.setPosition(position);
	this->highlightRect.setFillColor(sf::Color::Transparent);

	if (buttonText.size() > 0) {
		this->font = font;
		this->buttonText = sf::Text(buttonText, this->font, charSize);
		this->buttonText.setOutlineThickness(3);
		this->buttonText.setOutlineColor(sf::Color::Black);
	//	this->buttonText.setOrigin(sf::Vector2f(this->buttonText.getLocalBounds().width / 2, this->buttonText.getLocalBounds().height / 2));
		this->buttonText.setPosition(position);
		this->buttonRect.setSize(sf::Vector2f(this->buttonText.getLocalBounds().width, this->buttonText.getLocalBounds().height));
		this->highlightRect.setSize(sf::Vector2f(this->buttonText.getLocalBounds().width, this->buttonText.getLocalBounds().height));
	}
	if (buttonTexture == NULL) {
		
		this->buttonRect.setFillColor(sf::Color::Transparent);
		if (this->buttonText.getString().getSize() == 0) {
			std::cout << "Button created without texture or text. Creating outline as placeholder." << std::endl;
			buttonRect.setOutlineColor(sf::Color::Black);
			buttonRect.setOutlineThickness(4);
		}
		
	}


	
}
