#include "Hub.h"
#include "FButton.h"
#include "ButtonScreen.h"


void Hub::addButton(sf::Vector2f position, sf::Vector2f size, Navigable * target)
{
	(*this->buttonScreen).addButton(new FButton(size, target, position));
}

void Hub::setImageTexture(sf::Texture & texture)
{
	(*this->buttonScreen).setImageTexture(texture);
}

void Hub::display(sf::RenderWindow & window, sf::View & view)
{
	(*this->buttonScreen).display(window, view);
}

Hub::Hub()
{
	this->buttonScreen = new ButtonScreen;
}


Hub::~Hub()
{
}
