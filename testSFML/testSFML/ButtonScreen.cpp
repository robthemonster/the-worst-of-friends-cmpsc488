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
void ButtonScreen::setPrompt(std::string prompt, sf::Font font, int charSize) {
	this->font = font;
	this->promptText = sf::Text(prompt, this->font, charSize);
	//this->promptText.setOrigin(sf::Vector2f(this->promptText.getLocalBounds().width / 2, this->promptText.getLocalBounds().height /2));
	this->promptText.setPosition(this->dialoguePane.getPosition().x + (this->dialoguePane.getSize().x / 2), this->dialoguePane.getPosition().y + 10);
}
ButtonScreen::ButtonScreen(const ButtonScreen & copy)
{
	buttons = copy.buttons;
	promptText = copy.promptText;
	game = copy.game;
	imageRect = copy.imageRect;
	dialoguePane = copy.dialoguePane;
	
}





void ButtonScreen::addButton(FButton * button) {
	this->buttons.push_back(button);
}

void ButtonScreen::setShowGlobalPane(bool set)
{
	this->showGlobalPane = set;
}


void ButtonScreen::display(sf::RenderWindow & window, sf::View & view, bool fadeIn)  {
	

	if (fadeIn) {
		sf::Clock fadeIn;
		imageRect.setPosition(view.getSize().x * -0.5, view.getSize().y * -0.5);
		imageRect.setSize(view.getSize());
		while (window.isOpen() && fadeIn.getElapsedTime().asMilliseconds() <= 1000) {
			window.clear();
			window.draw(imageRect);
			(*(*this->game).getInterfacePointer()).drawFade(window, view, fadeIn.getElapsedTime().asMilliseconds(), false);
			window.display();
		}
	}
	std::vector<FButton* >::iterator it;

	Player * currPlayer = *(*this->game).getCurrentPlayerPointer();

//	imageRect.setPosition(-958, -550);
	if (this->buttons.begin() == this->buttons.end()) {
		std::cout << "No buttons in button screen! Skipping this button screen. May have called setButtonSize or setFontCharSize but didn't add any buttons" << std::endl;
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
									(*(**it).getTarget()).display(window, view, false);
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
			(**it).draw(window, view, (*(*this->game).getInterfacePointer()).getPaused());
			it++;
		}

		(*(*this->game).getInterfacePointer()).drawPauseMenu(window, view);
		
		if (currPlayer != NULL)
			(*(*this->game).getInterfacePointer()).drawPlayerAttributes(window, view, currPlayer, (*currPlayer).getPlayerColor());
			
		if (this->game != NULL)
			(*(*this->game).getInterfacePointer()).drawGlobalAttributes(window, view, this->game, sf::Color(255, 255, 255, 130));

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