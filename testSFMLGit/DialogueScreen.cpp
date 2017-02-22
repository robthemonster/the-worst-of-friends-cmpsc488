#include "DialogueScreen.h"
#include <vector>
#include "DialogueLine.h"
#include <iostream>
#include "ButtonScreen.h"

DialogueScreen::DialogueScreen(sf::Texture & texture)
{
	this->image = texture;
}



void DialogueScreen::setTextOrigin(sf::Vector2f & origin) {
	this->textOrigin = origin;
}

void DialogueScreen::setDestination(ButtonScreen * b)
{
	this->destination = b;
}

 void DialogueScreen::resizeView(sf::RenderWindow& window, sf::View& view) {
	float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
	std::cout << aspectRatio << std::endl;
//	this->bg.setSize(sf::Vector2f(this->SCREEN_WIDTH, this->SCREEN_WIDTH * aspectRatio));
	view.setSize(this->SCREEN_WIDTH, this->SCREEN_WIDTH * aspectRatio);
}

void DialogueScreen::display(sf::RenderWindow & dialogueScreen, sf::View & view) {
	//sf::RenderWindow dialogueScreen(sf::VideoMode(800, 600), "Dialogue Window", sf::Style::Close | sf::Style::Resize);
	sf::Font font;
	font.loadFromFile("fonts/regular.otf");
	std::vector<DialogueLine>::iterator it = this->dialogue.begin();
	sf::Texture dialoguePaneTexture;
	sf::Texture background;

	background.loadFromFile("img/bg.jpg");
	dialoguePaneTexture.loadFromFile("img/dialoguePane.png");
	
	
	sf::RectangleShape dialoguePane;
	sf::RectangleShape imageRect;
	
	

	bg.setFillColor(sf::Color::White);
	bg.setTexture(&background);
	bg.setSize(sf::Vector2f(dialogueScreen.getView().getSize().x, dialogueScreen.getView().getSize().y));
	
	bg.setPosition(dialogueScreen.getView().getCenter().x - (dialogueScreen.getView().getSize().x / 2), dialogueScreen.getView().getCenter().y - (dialogueScreen.getView().getSize().y / 2));

	
	
	imageRect.setTexture(&this->image);
	dialoguePane.setTexture(&dialoguePaneTexture);

	dialoguePane.setSize(sf::Vector2f(1500, 320));
	dialoguePane.setPosition(-750, 200);


	imageRect.setPosition(-958, -550);
	imageRect.setSize(sf::Vector2f(1920, 700));


	this->textOrigin = sf::Vector2f(dialoguePane.getPosition().x + dialoguePane.getSize().x * 0.15, dialoguePane.getPosition().y + dialoguePane.getPosition().y * 0.125);

	
	sf::Clock clock;
	clock.restart();
	while (dialogueScreen.isOpen()) {
		sf::Event evnt;
		while (dialogueScreen.pollEvent(evnt)) {
			switch (evnt.type) {
			case sf::Event::Closed:
				dialogueScreen.close();
			case sf::Event::KeyPressed:
				if (sf::Keyboard::isKeyPressed(sf::Keyboard::Return)) {
					//enter pressed
					if (it != this->dialogue.end()) {// if this is the not the last dialogue line
						if ((*it).isDone()) { // if the current line is finished printing
							(*it).setDone(false);
							it++;
							clock.restart();
							if (it == this->dialogue.end() && this->destination != nullptr) {
								(*this->destination).display(dialogueScreen, view);
								return;
							}
						}
						else {
							(*it).setDone(true);
						}
					}
				}
				break;
			case sf::Event::Resized:
				resizeView(dialogueScreen, view);
				break;
			}
		}
	
		dialogueScreen.clear();
		dialogueScreen.draw(bg);
		dialogueScreen.draw(dialoguePane);
		dialogueScreen.draw(imageRect);
		
		if (it != this->dialogue.end())
			(*it).display(dialogueScreen,this->textOrigin, font, 200, 40, 1000,  clock.getElapsedTime().asMilliseconds());
		dialogueScreen.display();

	}
}

void DialogueScreen::addDialogueLine(DialogueLine line) {
	this->dialogue.push_back(line);
}

DialogueScreen::DialogueScreen(const DialogueScreen& copy) {
	this->bg = copy.bg;
	this->dialogue = copy.dialogue;
	this->image = copy.image;
	this->textOrigin = copy.textOrigin;
	this->image = copy.image;
}

DialogueScreen::~DialogueScreen() {
//	delete this->destination;
	
}