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
	 sf::Texture * buttonTexture, *highlightedButtonTexture;
	 sf::Text buttonText;
	 sf::Font font;

	
	 bool highlighted = false;

	 int highlightMode = -1;

public:
	static const int HIGHLIGHT_IMAGE = 2, HIGHLIGHT_TEXT = 1, DO_NOTHING = 0;
	~FButton();
	FButton(sf::Vector2f & size,  Navigable * target,  sf::Vector2f &position, int highlightMode, std::string buttonText = "", sf::Font font = sf::Font(), int charSize = 0,
		sf::Texture * buttonTexture = NULL, sf::Texture * highlightedButtonTexture = NULL);
	void draw(sf::RenderWindow&, sf::View&,bool mouseMode, bool paused);
	bool mouseOver(sf::Vector2f mouseLocation);
	void setHighlighted(bool highlighted);
	void setPosition(float x, float y);
	bool isHighlighted();
	Navigable * getTarget();
};

