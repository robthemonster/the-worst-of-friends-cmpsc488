#include "Hub.h"
#include "FButton.h"
#include "ButtonScreen.h"


void Hub::addButton(sf::Vector2f position, sf::Vector2f size, Navigable * target)
{
	(*this->buttonScreen).addButton(new FButton(size, target, position, FButton::DO_NOTHING));
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

Hub::Hub(Game * game)
{
	this->game = game;
	this->buttonScreen = new ButtonScreen(game);
}


Hub::~Hub()
{
}
