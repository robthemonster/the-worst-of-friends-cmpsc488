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
	 sf::Font font;
	 bool highlighted = false;

public:
	~FButton();
	FButton(sf::Vector2f & size,  Navigable * target,  sf::Vector2f &position, std::string buttonText = "", sf::Font font = sf::Font(), int charSize = 0,
		sf::Texture * buttonTexture = NULL);
	void draw(sf::RenderWindow&, sf::View&);
	bool mouseOver(sf::Vector2f mouseLocation);
	void setHighlighted(bool highlighted);
	void setPosition(float x, float y);
	bool isHighlighted();
	Navigable * getTarget();
};

