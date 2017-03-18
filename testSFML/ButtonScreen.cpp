#include <vector>
#include <iostream>
#include <iterator>
#include "FButton.h"
#include "DialogueScreen.h"
#include "Interface.h"
#include "Game.h"
#include "Player.h"
#include "ButtonScreen.h"



ButtonScreen::ButtonScreen(Game * game) {
	this->game = game;
}

void ButtonScreen::setImageTexture(sf::Texture & texture) {
	this->imageRect.setTexture(&texture);
}

void ButtonScreen:: setDialoguePaneTexture(sf::Texture & texture, sf::Vector2f dialoguePanePos) {
	this->dialoguePane.setTexture(&texture);
	this->dialoguePane.setPosition(dialoguePanePos);
	this->dialoguePane.setSize(sf::Vector2f(texture.getSize().x, texture.getSize().y));
}
void ButtonScreen::setPrompt(sf::Text text) {
	this->promptText = text;
	this->promptText.setOrigin(sf::Vector2f(text.getLocalBounds().width / 2, 10));
	this->promptText.setPosition(this->dialoguePane.getPosition().x + (this->dialoguePane.getSize().x / 2), this->dialoguePane.getPosition().y + 10);
}
ButtonScreen::ButtonScreen(const ButtonScreen & copy)
{
	buttons = copy.buttons;
	
}





void ButtonScreen::addButton(FButton * button) {
	this->buttons.push_back(button);
}


void ButtonScreen::display(sf::RenderWindow & window, sf::View & view)  {
	
	std::vector<FButton* >::iterator it;

	Player * currPlayer = *(*this->game).getCurrentPlayerPointer();

//	imageRect.setPosition(-958, -550);
	if (this->buttons.begin() == this->buttons.end()) {
		std::cout << "No buttons in button screen! Skipping this button screen. May have called setButtonSize or setButtonCharSize but didn't add any buttons" << std::endl;
		return;
	}
	
	imageRect.setPosition(window.getView().getSize().x * -0.5, window.getView().getSize().y * -0.5);

	imageRect.setSize(window.getView().getSize());
	
	

	bool optionSelected = false;

	promptText.setOutlineColor(sf::Color::Black);
	promptText.setOutlineThickness(3);

	while (window.isOpen()) {

		sf::Event evnt;
		while (window.pollEvent(evnt)) {
			switch (evnt.type) {
				case sf::Event::MouseButtonReleased:
					switch (evnt.mouseButton.button) {
					case sf::Mouse::Left: //left mouse released.
						if (!(*(*this->game).getInterfacePointer()).getPaused()) {
							it = this->buttons.begin();
							while (it != this->buttons.end()) {
								if ((**it).mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window)))) {
									(**it).setHighlighted(false);
									(*(**it).getTarget()).display(window, view);
									return;

								}
								it++;
							}
						}
						else {
							if ((*(*this->game).getInterfacePointer()).continueHighlighted()) {
								(*(*this->game).getInterfacePointer()).setPaused(false);
							}
							if ((*(*this->game).getInterfacePointer()).quitHighlighted()) {
								window.close();
							}
						}
						break;
					}
					break;
				case sf::Event::KeyPressed:
					switch (evnt.key.code) {
					case sf::Keyboard::Escape:
						(*(*this->game).getInterfacePointer()).setPaused(!(*(*this->game).getInterfacePointer()).getPaused());
						break;
					}
					break;
				case sf::Event::Resized:
					resizeView(window, view);
					break;
				case sf::Event::Closed:
					window.close();
					break;
			}
		}



		

		window.clear();
		window.draw(imageRect);
		window.draw(dialoguePane);
		window.draw(promptText);
		 it = this->buttons.begin();
		while (it != this->buttons.end()) {
			(**it).draw(window, view);
			it++;
		}

		(*(*this->game).getInterfacePointer()).drawPauseMenu(window, view);
		(*(*this->game).getInterfacePointer()).drawPlayerAttributes(window, view, currPlayer, (*currPlayer).getPlayerColor());
		window.display();
		
		

	}

	
}

void ButtonScreen::resizeView(sf::RenderWindow& window, sf::View& view) {
	float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
	std::cout << aspectRatio << std::endl;
	view.setSize(this->SCREEN_WIDTH, this->SCREEN_WIDTH * aspectRatio);
}


ButtonScreen::~ButtonScreen() {
		
}