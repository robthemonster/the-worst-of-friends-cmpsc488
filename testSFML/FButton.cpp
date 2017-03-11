#include "FButton.h"
#include <iostream>




void FButton::draw(sf::RenderWindow& window, sf::View& view) {
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
	sf::Text & buttonText, sf::Texture * buttonTexture) {

	this->target = target;
	this->buttonRect = sf::RectangleShape(size);
	this->buttonRect.setOrigin(size.x / 2, size.y / 2);

	this->buttonRect.setPosition(position);
	this->buttonRect.setTexture(buttonTexture);
	this->highlightRect = sf::RectangleShape(size);
	this->highlightRect.setOrigin(size.x / 2, size.y / 2);
	this->highlightRect.setPosition(position);
	this->highlightRect.setFillColor(sf::Color::Transparent);

	this->buttonText = buttonText;		
	this->buttonText.setOutlineThickness(3);
	this->buttonText.setOutlineColor(sf::Color::Black);
	
	this->buttonText.setOrigin(sf::Vector2f(this->buttonText.getLocalBounds().width / 2, this->buttonText.getLocalBounds().height / 2));
	this->buttonText.setPosition(position);
	
	if (buttonTexture == NULL) {
		
		this->buttonRect.setFillColor(sf::Color::Transparent);
		if (this->buttonText.getString().getSize() == 0) {
			std::cout << "Button created without texture or text. Creating outline as placeholder." << std::endl;
			buttonRect.setOutlineColor(sf::Color::Black);
			buttonRect.setOutlineThickness(4);
		}
		
	}


	
}
