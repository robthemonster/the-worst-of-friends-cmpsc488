#include <iostream>
#include "ButtonScreen.h"
#include "DialogueScreen.h"
#include "DialogueLine.h"
#include "FButton.h"
#include "Interface.h"
#include "Impact.h"
#include "Game.h"

#include "Path.h"

void Path::display(sf::RenderWindow & window, sf::View & view)
{
	if (this->hasMusic) {
		(*this->music).openFromFile(this->musicFile);
		(*this->music).setLoop(true);
		(*this->music).play();
	}
	

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



void Path::addDialogueLine(std::string dialogueLine)
{
	if (this->dialogueScreen != NULL) {
		(*this->dialogueScreen).addDialogueLine(DialogueLine(dialogueLine));
	}
	else {
		std::cout << "Path has no dialogue screen! Cannot add dialogue" << std::endl;
	}
}

void Path::addDialogueLine(std::string dialogueLine, Attributable ** target, std::string key, int op, int val)
{
	if (this->dialogueScreen != NULL) {
		DialogueLine line(dialogueLine);
		line.setImpact(new Impact((*this->game).getAttributeMapPointer(), target, key, op, val));
		(*this->dialogueScreen).addDialogueLine(line);
	}
	else {
		std::cout << "Path has no dialogue screen! Cannot add dialogue" << std::endl;
	}
}

void Path::setButtonSize(sf::Vector2f size) {

	if (this->buttonScreen == NULL)
		this->buttonScreen = new ButtonScreen(this->game);
	this->buttonSize = size;
}

void Path::setButtonCharSize(int size) {

	if (this->buttonScreen == NULL)
		this->buttonScreen = new ButtonScreen(this->game);
	this->buttonCharSize = size;
}

void Path::addButton(std::string buttonText, Navigable * target, sf::Vector2f position, sf::Texture * buttonTexture)
{
	if (this->buttonScreen == NULL)
		this->buttonScreen = new ButtonScreen(this->game);
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

void Path::setMusic(sf::Music & music, std::string fileName)
{
	this->music = &music;
	this->musicFile = fileName;
	this->hasMusic = true;
}



Path::Path(Game * game)
{
	this->game = game;
	this->buttonScreen = NULL;
	this->dialogueScreen = new DialogueScreen(this->game);
	(*this->dialogueScreen).setDestination(&this->buttonScreen);
}


Path::~Path()
{
}
