#include "DialogueScreen.h"
#include <vector>
#include "DialogueLine.h"
#include <iostream>
#include "ButtonScreen.h"

DialogueScreen::DialogueScreen(sf::Texture & texture)
{
	this->image = texture;
}
DialogueScreen::DialogueScreen() {

};
void DialogueScreen::setImageTexture(sf::Texture & texture) {
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

void DialogueScreen::display(sf::RenderWindow & window, sf::View & view) {
	
	sf::Font font;
	
	std::vector<DialogueLine>::iterator it = this->dialogue.begin();
	sf::Texture dialoguePaneTexture;
	sf::Texture background;
	sf::Texture enterSymbol;

	if (!enterSymbol.loadFromFile("img/enter.png")
		||!font.loadFromFile("fonts/8bit.ttf")
		|| !background.loadFromFile("img/bg.jpg")
		|| !dialoguePaneTexture.loadFromFile("img/dialoguePane.png")) {
		std::cout << "Cannot load from file" << std::endl;
	};

	
	
	sf::RectangleShape dialoguePane;
	sf::RectangleShape imageRect;
	sf::RectangleShape enterSymbolRect;
	
	int enterSymbolOpacity;
	bool increasing = true;
	

	bg.setFillColor(sf::Color::White);
	bg.setTexture(&background);
	bg.setSize(sf::Vector2f(window.getView().getSize().x, window.getView().getSize().y));
	
	bg.setPosition(window.getView().getCenter().x - (window.getView().getSize().x / 2), window.getView().getCenter().y - (window.getView().getSize().y / 2));

	
	

	imageRect.setTexture(&this->image);
	dialoguePane.setTexture(&dialoguePaneTexture);
	enterSymbolRect.setTexture(&enterSymbol);



	dialoguePane.setSize(sf::Vector2f(dialoguePaneTexture.getSize().x, dialoguePaneTexture.getSize().y));
	dialoguePane.setPosition(-750, 200);

	enterSymbolRect.setSize(sf::Vector2f(enterSymbolRect.getTextureRect().width * 0.40, enterSymbolRect.getTextureRect().height * 0.40));
	enterSymbolRect.setPosition(500, 420);

	imageRect.setPosition(window.getView().getSize().x * -0.5, window.getView().getSize().y * -0.5);
	imageRect.setSize(window.getView().getSize());

	imageRect.setSize(window.getView().getSize());

	setTextOrigin(sf::Vector2f(dialoguePane.getPosition().x + 50,  dialoguePane.getPosition().y + 10));

	sf::Clock enterSymbolClock;
	sf::Clock dialogueClock;
	while (window.isOpen()) {
		sf::Event evnt;
		while (window.pollEvent(evnt)) {
			switch (evnt.type) {
			case sf::Event::Closed:
				window.close();
			case sf::Event::KeyPressed:
				if (sf::Keyboard::isKeyPressed(sf::Keyboard::Return)) {
					//enter pressed
					if (it != this->dialogue.end()) {// if this is the not the last dialogue line
						if ((*it).isDone()) { // if the current line is finished printing
							(*it).setDone(false);
							it++;
							dialogueClock.restart();
							if (it == this->dialogue.end() && this->destination != nullptr) {
								(*this->destination).display(window, view);
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
				resizeView(window, view);
				break;
			}
		}
	
		window.clear();

		window.draw(bg);
		window.draw(imageRect);
		window.draw(dialoguePane);

		if (it != this->dialogue.end()) {
			if ((*it).isDone()) {
				
				if (increasing) {
					
					 enterSymbolOpacity = (255 * ((enterSymbolClock.getElapsedTime().asMilliseconds() % 1000) / 1000.0));
					 if (enterSymbolOpacity >= 254) {
						 enterSymbolClock.restart();
						 enterSymbolOpacity = 254;
						 increasing = false;
					 }
				}
				else {
					enterSymbolOpacity = 255- (255 * ((enterSymbolClock.getElapsedTime().asMilliseconds() % 1000) / 1000.0));
					if (enterSymbolOpacity <= 1) {
						enterSymbolClock.restart();
						enterSymbolOpacity = 1;
						increasing = true;
					}
				}

				
				enterSymbolRect.setFillColor(sf::Color(255, 255, 255,enterSymbolOpacity));
				window.draw(enterSymbolRect);
			}
		
				(*it).draw(window, this->textOrigin, font, 10, 40, 1300, dialogueClock.getElapsedTime().asMilliseconds());
		
		}
		window.display();

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