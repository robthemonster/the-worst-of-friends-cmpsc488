#pragma once
#include <SFML\Graphics.hpp>

class DialogueScreen;
class FButton
{
private:
	 DialogueScreen * dialogueScreen;
	 sf::RectangleShape buttonRect;
	 sf::RectangleShape highlightRect;
	 sf::Text buttonText;
	

public:
	~FButton();
	FButton(sf::Vector2f & size,  DialogueScreen *ds,  sf::Vector2f &position, sf::Text& buttonText ,
		sf::Texture * buttonTexture);
	void draw(sf::RenderWindow&, sf::View&);
	bool mouseOver(sf::Vector2f mouseLocation);
	void setHighlighted(bool highlighted);
	DialogueScreen* getDialogueScreen();
};

