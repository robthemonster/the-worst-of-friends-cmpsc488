#include "Hub.h"
#include "FButton.h"
#include "ButtonScreen.h"


void Hub::addButton(sf::Vector2f buttonSize, std::string buttonText, Navigable * target, sf::Vector2f position, int highlightMode, sf::Texture * buttonTexture, sf::Texture * highlightTexture)
{
	(*this->buttonScreen).addButton(new FButton(buttonSize, target, position, highlightMode, buttonText, this->buttonFont, this->buttonFontCharSize, buttonTexture, highlightTexture));
	
}


void Hub::setImageTexture(sf::Texture & texture)
{
	(*this->buttonScreen).setImageTexture(texture);
}

void Hub::display(sf::RenderWindow & window, sf::View & view)
{
	if (this->hasMusic) {
		(*this->music).openFromFile(this->musicFile);
		(*this->music).setLoop(true);
		(*this->music).play();
	}
	(*this->buttonScreen).display(window, view);
}

void Hub::setMusic(sf::Music & music, std::string fileName)
{
	this->music = &music;
	this->musicFile = fileName;
	this->hasMusic = true;
}

void Hub::setFont(sf::Font font)
{
	this->buttonFont = font;
}

void Hub::setFontCharSize(int charSize)
{
	this->buttonFontCharSize = charSize;
}

Hub::Hub(Game * game)
{
	this->game = game;
	this->buttonScreen = new ButtonScreen(game);
	(*this->buttonScreen).setShowGlobalPane(true);
}


Hub::~Hub()
{
}
