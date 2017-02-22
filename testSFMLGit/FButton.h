#pragma once
#include <SFML\Graphics.hpp>

class ButtonScreen;
class DialogueScreen;
class FButton
{
private:
	sf::Texture buttonTexture;
	sf::RectangleShape buttonRect;
	 ButtonScreen  * buttonScreen;
	 DialogueScreen * dialogueScreen;
	
	
public:
	~FButton();
	FButton(sf::Vector2f & size, sf::Texture & texture, ButtonScreen *bs, DialogueScreen *ds, sf::Vector2f &position);
	void draw(sf::RenderWindow&, sf::View&);
	bool mouseOver(sf::Vector2f mouseLocation);
	void setHighlighted(bool highlighted);
	DialogueScreen* getDialogueScreen();
};

