#pragma once
#include <SFML\/Graphics.hpp>
#include "Navigable.h"
class DialogueLine;
class FButton;
class DialogueScreen;
class ButtonScreen;
class Path : public Navigable 
{
private:
	DialogueScreen * dialogueScreen;
	ButtonScreen * buttonScreen;
	int buttonCharSize;
	sf::Vector2f buttonSize;
	sf::Font font;
	sf::Vector2f dialoguePanePosition;
public:
	void display(sf::RenderWindow & window, sf::View & view);
	void setImageTexture(sf::Texture &);
	void setDialoguePaneTexture(sf::Texture & texture, sf::Vector2f position);
	void addDialogueLine(DialogueLine*);
	void setButtonSize(sf::Vector2f size);
	void setButtonCharSize(int size);
	void addButton(std::string buttonText, Navigable * target, sf::Vector2f position, sf::Texture * buttonTexture = NULL);
	
	void setPrompt(std::string prompt);
	void setFont(sf::Font font);
	Path();
	~Path();
};

