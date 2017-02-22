#include "FButton.h"





void FButton::draw(sf::RenderWindow& window, sf::View& view) {
	window.draw(this->buttonRect);
}

bool FButton::mouseOver(sf::Vector2f mouseLocation) {
	return this->buttonRect.getGlobalBounds().contains(mouseLocation.x, mouseLocation.y);

	
}

void FButton::setHighlighted(bool highlighted) {
	if (highlighted)
		buttonRect.setFillColor(sf::Color::Yellow);
	else
		buttonRect.setFillColor(sf::Color::White);
}

DialogueScreen * FButton::getDialogueScreen() {
	return this->dialogueScreen;
}

FButton::~FButton() {
	
}

FButton::FButton(sf::Vector2f & size, sf::Texture & texture, ButtonScreen * bs, DialogueScreen * ds, sf::Vector2f &position)
{
	
		this->buttonScreen = bs;
		this->dialogueScreen = ds;

		this->buttonRect = sf::RectangleShape(size);
		this->buttonTexture = texture;
		this->buttonRect.setPosition(position);
		this->buttonRect.setTexture(&texture);



	
}
