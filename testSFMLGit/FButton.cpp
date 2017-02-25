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
		if (buttonRect.getTexture() == NULL)
			buttonText.setFillColor(sf::Color(255, 255, 0, 255));
		else
		{
			highlightRect.setFillColor(sf::Color(255, 255, 0, 90));
		}
	}
	else {
		buttonText.setFillColor(sf::Color::White);
		highlightRect.setFillColor(sf::Color::Transparent);
	}
}

DialogueScreen * FButton::getDialogueScreen() {
	return this->dialogueScreen;
}

FButton::~FButton() {
	
}

FButton::FButton(sf::Vector2f & size,  DialogueScreen * ds, sf::Vector2f &position, 
	sf::Text & buttonText, sf::Texture * buttonTexture) {

	this->dialogueScreen = ds;
	this->buttonRect = sf::RectangleShape(size);
	this->buttonRect.setPosition(position);
	this->highlightRect = sf::RectangleShape(size);
	this->highlightRect.setPosition(position);
	this->highlightRect.setFillColor(sf::Color::Transparent);

	this->buttonText = buttonText;		
	this->buttonText.setOutlineThickness(3);
	this->buttonText.setOutlineColor(sf::Color::Black);
	this->buttonRect.setTexture(buttonTexture);
	this->buttonText.setOrigin(sf::Vector2f(this->buttonText.getLocalBounds().width / 2, this->buttonText.getLocalBounds().height / 2));
	this->buttonText.setPosition(sf::Vector2f(position.x + (size.x / 2), position.y + (size.y / 2)));
	
	if (buttonTexture == NULL) {
		this->buttonRect.setFillColor(sf::Color::Transparent);
		if (this->buttonText.getString().getSize() == 0) {
			std::cout << "Button created without texture or text. Creating outline as placeholder." << std::endl;
			buttonRect.setOutlineColor(sf::Color::Black);
			buttonRect.setOutlineThickness(4);
		}
	}


	
}
