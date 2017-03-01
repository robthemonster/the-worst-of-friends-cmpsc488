#include <iostream>
#include "Path.h"
#include "ButtonScreen.h"
#include "DialogueScreen.h"
#include "DialogueLine.h"
#include "FButton.h"

void Path::display(sf::RenderWindow & window, sf::View & view)
{
	if (this->dialogueScreen != NULL) {
		(*this->dialogueScreen).display(window, view);
	}
	else if (this->buttonScreen != NULL) {
		(*this->buttonScreen).display(window, view);
	}
	else {
		std::cout << "Path has no dialogue screen or button screen" << std::endl;
	}
}

void Path::setImageTexture(sf::Texture & texture)
{
	if (this->buttonScreen != NULL) {
		(*buttonScreen).setImageTexture(texture);
	}
	else {
		std::cout << "Button Screen not set! Cannot apply texture" << std::endl;
	}
	if (this->dialogueScreen != NULL) {
		(*dialogueScreen).setImageTexture(texture);
	}
	else {
		std::cout << "Dialogue Screen not set! Cannot apply texture" << std::endl;

	}
}

void Path::setDialoguePaneTexture(sf::Texture & texture, sf::Vector2f position)
{
	if (this->buttonScreen != NULL) {
		(*buttonScreen).setDialoguePaneTexture(texture, position);
		this->dialoguePanePosition = position;
	}
	else {
		std::cout << "Button Screen not set! Cannot apply texture" << std::endl;
	}
	if (this->dialogueScreen != NULL) {
		(*dialogueScreen).setDialoguePaneTexture(texture, position);
		this->dialoguePanePosition = position;
	}
	else {
		std::cout << "Dialogue Screen not set! Cannot apply texture" << std::endl;

	}
}



void Path::addDialogueLine(DialogueLine * dialogueLine)
{
	if (this->dialogueScreen != NULL) {
		(*this->dialogueScreen).addDialogueLine(*dialogueLine);
	}
	else {
		std::cout << "Path has no dialogue screen! Cannot add dialogue" << std::endl;
	}
}

void Path::setButtonSize(sf::Vector2f size) {
	this->buttonSize = size;
}

void Path::setButtonCharSize(int size) {
	this->buttonCharSize = size;
}

void Path::addButton(std::string buttonText, Navigable * target, sf::Vector2f position, sf::Texture * buttonTexture)
{
	if (this->buttonScreen != NULL) {
		FButton * button = new FButton(this->buttonSize, target, position, sf::Text(sf::String(buttonText), this->font, this->buttonCharSize), buttonTexture);
		
		(*this->buttonScreen).addButton(button);
	}
	else {
		std::cout << "Path has no button screen! Cannot add button" << std::endl;
	}
}

void Path::setPrompt(std::string prompt)
{
	if (this->buttonScreen != NULL) {
		(*this->buttonScreen).setPrompt(sf::Text(sf::String(prompt), this->font, 40));
	}
}

void Path::setFont(sf::Font font)
{
	this->font = font;
	if (this->dialogueScreen != NULL) {
		(*this->dialogueScreen).setFont(font);
	}
	else {
		std::cout << "No dialogue screen! Cannot set font" << std::endl;
	}
}

Path::Path()
{
	this->buttonScreen = new ButtonScreen;
	this->dialogueScreen = new DialogueScreen;
	(*this->dialogueScreen).setDestination(this->buttonScreen);
}


Path::~Path()
{
}
