#include "DialogueScreen.h"
#include <vector>
#include "DialogueLine.h"
#include <iostream>
#include "ButtonScreen.h"


DialogueScreen::DialogueScreen() {

};
void DialogueScreen::setImageTexture(sf::Texture & texture) {
	imageRect.setTexture(&texture);
}

void DialogueScreen::setDialoguePaneTexture(sf::Texture & texture, sf::Vector2f position)
{
	this->dialoguePaneRect.setTexture(&texture);
	this->dialoguePaneRect.setPosition(position);
	this->dialoguePaneRect.setSize(sf::Vector2f(texture.getSize().x, texture.getSize().y));
}

void DialogueScreen::setFont(sf::Font font)
{
	this->font = font;
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
	
	
	
	std::vector<DialogueLine>::iterator it = this->dialogue.begin();
	
	sf::Texture enterSymbol;
	sf::RectangleShape enterSymbolRect;
	int enterSymbolOpacity;
	bool increasing = true;

	if (!enterSymbol.loadFromFile("img/enter.png")) {
		std::cout << "Cannot load from file" << std::endl;
	};
	enterSymbolRect.setTexture(&enterSymbol);



	

	enterSymbolRect.setSize(sf::Vector2f(enterSymbolRect.getTextureRect().width * 0.40, enterSymbolRect.getTextureRect().height * 0.40));
	enterSymbolRect.setPosition(500, 420);

	imageRect.setPosition(window.getView().getSize().x * -0.5, window.getView().getSize().y * -0.5);
	imageRect.setSize(window.getView().getSize());


	setTextOrigin(sf::Vector2f(dialoguePaneRect.getPosition().x + 50,  dialoguePaneRect.getPosition().y + 50));

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

		window.draw(imageRect);
		window.draw(dialoguePaneRect);

		if (it != this->dialogue.end()) {
			if ((*it).isDone()) {
				
				if (increasing) {
					
					 enterSymbolOpacity = (255 * ((enterSymbolClock.getElapsedTime().asMilliseconds()/* % 1000*/) / 1000.0));
					 if (enterSymbolOpacity >= 254) {
						 enterSymbolClock.restart();
						 enterSymbolOpacity = 254;
						 increasing = false;
					 }
				}
				else {
					enterSymbolOpacity = 255- (255 * ((enterSymbolClock.getElapsedTime().asMilliseconds() /*% 1000*/) / 1000.0));
					if (enterSymbolOpacity <= 1) {
						enterSymbolClock.restart();
						enterSymbolOpacity = 1;
						increasing = true;
					}
				}

				
				enterSymbolRect.setFillColor(sf::Color(255, 255, 255,enterSymbolOpacity));
				window.draw(enterSymbolRect);
			}
		
				(*it).draw(window, this->textOrigin, font, 25, 40, 1300, dialogueClock.getElapsedTime().asMilliseconds());
		
		}
		window.display();

	}
}

void DialogueScreen::addDialogueLine(DialogueLine line) {
	this->dialogue.push_back(line);
}

DialogueScreen::DialogueScreen(const DialogueScreen& copy) {
	
	this->dialogue = copy.dialogue;
	this->textOrigin = copy.textOrigin;
	this->destination = copy.destination;
	this->dialoguePaneRect = copy.dialoguePaneRect;

	this->imageRect = copy.imageRect;

}

DialogueScreen::~DialogueScreen() {
//	delete this->destination;
	
}