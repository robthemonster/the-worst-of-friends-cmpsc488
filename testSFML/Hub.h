#pragma once
#include "Navigable.h"
#include "Attributable.h"
class ButtonScreen;
class Hub :
	public Navigable, public Attributable
{
private:
	ButtonScreen * buttonScreen;
public:
	void addButton(sf::Vector2f position, sf::Vector2f size, Navigable * target);
	void setImageTexture(sf::Texture & texture);
	void display(sf::RenderWindow & window, sf::View & view);
	Hub();
	~Hub();
};

