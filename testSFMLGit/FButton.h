#pragma once
#include <SFML\Graphics.hpp>

class DialogueScreen;
class Navigable;
class FButton
{
private:
	 Navigable * target;
	 sf::RectangleShape buttonRect;
	 sf::RectangleShape highlightRect;
	 sf::Text buttonText;
	 bool highlighted = false;

public:
	~FButton();
	FButton(sf::Vector2f & size,  Navigable *ds,  sf::Vector2f &position, sf::Text& buttonText ,
		sf::Texture * buttonTexture);
	void draw(sf::RenderWindow&, sf::View&);
	bool mouseOver(sf::Vector2f mouseLocation);
	void setHighlighted(bool highlighted);
	bool isHighlighted();
	Navigable * getTarget();
};

