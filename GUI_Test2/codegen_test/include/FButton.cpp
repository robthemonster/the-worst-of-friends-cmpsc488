#include "FButton.h"
#include <iostream>




void FButton::draw(sf::RenderWindow& window, sf::View& view, bool mouseMode, bool disabled) {
	if (mouseMode)
		setHighlighted(this->mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window))) && !disabled);

		window.draw(this->buttonRect);
		window.draw(this->buttonText);
		window.draw(this->highlightRect);
	
	
}

bool FButton::mouseOver(sf::Vector2f mouseLocation) {


	return this->buttonRect.getGlobalBounds().contains(mouseLocation.x, mouseLocation.y) || this->buttonText.getGlobalBounds().contains(mouseLocation.x, mouseLocation.y);

	
}

void FButton::setHighlighted(bool highlighted) {
	if (highlighted) {
		switch (this->highlightMode) {
		case 2:	if (this->buttonTexture != NULL) {
				if (this->highlightedButtonTexture != NULL) {
					this->buttonRect.setTexture(this->highlightedButtonTexture);
				}

				else {
					this->highlightRect.setOutlineColor(sf::Color::Yellow);
				}
			}
				break;

		case 1: if (this->buttonText.getString().getSize() > 0) {
			this->buttonText.setFillColor(sf::Color::Yellow);
		}
				break;
		}
	}else {
		switch (this->highlightMode) {
		case 2:
			if (this->buttonTexture != NULL) {
				this->buttonRect.setTexture(this->buttonTexture);
			}
			else {
				this->highlightRect.setOutlineColor(sf::Color::Transparent);
			}
			break;
		case 1:
			if (this->buttonText.getString().getSize() > 0) {
				this->buttonText.setFillColor(sf::Color::White);
			}
			break;

		}
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



FButton::FButton(sf::Vector2f & size,  Navigable * target, sf::Vector2f &position, int highlightMode, 
	std::string buttonText, sf::Font font, int charSize, sf::Texture * buttonTexture, sf::Texture * highlightedButtonTexture) {

	this->target = target;
	this->highlightMode = highlightMode;
	this->highlightRect = sf::RectangleShape();
	this->buttonRect = sf::RectangleShape();
	this->highlightRect.setPosition(position);
	this->buttonRect.setPosition(position);
	if (buttonTexture != NULL) {
		this->buttonRect.setTexture(buttonTexture);
		this->buttonTexture = buttonTexture;
		this->buttonRect.setSize(sf::Vector2f((*buttonTexture).getSize().x, (*buttonTexture).getSize().y));
		this->highlightedButtonTexture = highlightedButtonTexture;
		this->highlightRect.setSize(buttonRect.getSize());
		this->highlightRect.setFillColor(sf::Color::Transparent);
		
	}
	if (buttonText.size() > 0) {
		this->font = font;
		this->buttonText = sf::Text(buttonText, this->font, charSize);
		this->buttonText.setOutlineThickness(3);
		this->buttonText.setOutlineColor(sf::Color::Black);
		this->buttonText.setPosition(position);
		}
	if (buttonTexture == NULL && buttonText.size() == 0) {
		this->buttonRect.setSize(size);
		this->highlightRect.setSize(size);
		this->buttonRect.setFillColor(sf::Color::Transparent);
		this->highlightRect.setFillColor(sf::Color::Transparent);
		
	}


	
}
