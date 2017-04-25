
#include <vector>
#include "DialogueLine.h"
#include <iostream>
#include "ButtonScreen.h"
#include "Interface.h"
#include "Game.h"
#include "Player.h"

#include "DialogueScreen.h"
DialogueScreen::DialogueScreen(Game * game) {
	this->game = game;
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

void DialogueScreen::setEnterSymbolTexture(sf::Texture & texture)
{
	this->enterSymbol.setTexture(&texture);
	sf::Vector2f pos(this->dialoguePaneRect.getPosition());
	pos.x += this->dialoguePaneRect.getSize().x - (texture.getSize().x * 1.05);
	pos.y += this->dialoguePaneRect.getSize().y - (texture.getSize().y * 1.05);
	this->enterSymbol.setPosition(pos);
	this->enterSymbol.setSize(sf::Vector2f(texture.getSize()));
}

void DialogueScreen::setFont(sf::Font font)
{
	this->font = font;
}

void DialogueScreen::setTextOrigin(sf::Vector2f & origin) {
	this->textOrigin = origin;
}

void DialogueScreen::setDestination(Navigable ** b)
{
	this->destination = b;
}

void DialogueScreen::resizeView(sf::RenderWindow& window, sf::View& view) {
	float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
	std::cout << aspectRatio << std::endl;
	view.setSize(this->SCREEN_WIDTH, this->SCREEN_WIDTH * aspectRatio);
}

void DialogueScreen::display(sf::RenderWindow & window, sf::View & view, bool fadeIn) {

	int charSize = 40;
	int charDelay = 20;
	int width = 1300;

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

	Player * currPlayer = *(*this->game).getCurrentPlayerPointer();

	std::vector<DialogueLine>::iterator it = this->dialogue.begin();



	int enterSymbolOpacity;
	bool increasing = true;

	imageRect.setPosition(window.getView().getSize().x * -0.5, window.getView().getSize().y * -0.5);
	imageRect.setSize(window.getView().getSize());
	setTextOrigin(sf::Vector2f(dialoguePaneRect.getPosition().x + 50, dialoguePaneRect.getPosition().y + 50));

	sf::Clock enterSymbolClock;
	sf::Clock dialogueClock;

	sf::Clock fade;
	bool fadingOut = false;

	bool mouseMode = true;
	sf::Vector2f lastMousePos;

	while (window.isOpen()) {
		sf::Event evnt;
		while (window.pollEvent(evnt)) {
			switch (evnt.type) {
			case sf::Event::Closed:
				window.close();
				return;
				break;
			case sf::Event::MouseMoved:
				if (window.mapPixelToCoords(sf::Mouse::getPosition(window)) != lastMousePos) {
					mouseMode = true;
					lastMousePos = window.mapPixelToCoords(sf::Mouse::getPosition(window));
				}
				break;
			case sf::Event::KeyPressed:
				switch (evnt.key.code) {
				case sf::Keyboard::Return:
					if (!(*(*this->game).getInterfacePointer()).getPaused()) {
						if (it != this->dialogue.end()) {// if this is the not the last dialogue line
							if ((*it).isDone()) { // if the current line is finished printing
								(*it).setDone(false);
								it++;
								dialogueClock.restart();
								if (it == this->dialogue.end()) {
									if (*this->destination != nullptr) {
										(**this->destination).display(window, view, false);
										return;
									}
									else {
										fadingOut = true;
										fade.restart();
									}
								}
							}else {
								(*it).setDone(true);
							}
						}
					}
					else {
						if (!mouseMode) {
							if ((*(*this->game).getInterfacePointer()).continueHighlighted()) {
								(*(*this->game).getInterfacePointer()).setPaused(false);
								mouseMode = true;
							}
							else if ((*(*this->game).getInterfacePointer()).quitHighlighted()) {
								window.close();
								return;
							}
						}
					}
					break;
				case sf::Keyboard::Escape:
					(*(*this->game).getInterfacePointer()).setPaused(!(*(*this->game).getInterfacePointer()).getPaused());
					mouseMode = true;
					break;
				case sf::Keyboard::Left:
				case sf::Keyboard::Right:
				case sf::Keyboard::Up:
				case sf::Keyboard::Down:
					if ((*(*this->game).getInterfacePointer()).getPaused()) {
						if (mouseMode) {
							(*(*this->game).getInterfacePointer()).setContinueHightlight(true);
							(*(*this->game).getInterfacePointer()).setQuitHighlight(false);
							mouseMode = false;
						}
						else {
							(*(*this->game).getInterfacePointer()).setContinueHightlight(!(*(*this->game).getInterfacePointer()).continueHighlighted());
							(*(*this->game).getInterfacePointer()).setQuitHighlight(!(*(*this->game).getInterfacePointer()).quitHighlighted());

						}
					}
					break;
				}
				break;
			case sf::Event::Resized:
				resizeView(window, view);
				break;
			case sf::Event::MouseButtonReleased:
				switch (evnt.mouseButton.button) {
				case sf::Mouse::Left:
				if (mouseMode){
					if ((*(*this->game).getInterfacePointer()).getPaused()) {
						if ((*(*this->game).getInterfacePointer()).continueHighlighted()) {
							(*(*this->game).getInterfacePointer()).setPaused(false);
						}
						if ((*(*this->game).getInterfacePointer()).quitHighlighted()) {
							window.close();
						}
					}
					else if (it != this->dialogue.end()) {// if this is the not the last dialogue line
						if ((*it).isDone()) { // if the current line is finished printing
							(*it).setDone(false);
							it++;
							dialogueClock.restart();
							if (it == this->dialogue.end()) {
								if (*this->destination != nullptr) {
									(**this->destination).display(window, view, false);
									return;
								}
								else {
									fadingOut = true;
									fade.restart();
								}

							}
						}
						else {
							(*it).setDone(true);
						}
					}
				}
					break;
				}
				break;
			}
		}


		window.clear();
		if (fadingOut) {
			window.draw(this->imageRect);
			(*(*this->game).getInterfacePointer()).drawFade(window, view, fade.getElapsedTime().asMilliseconds(), true);
			if (fade.getElapsedTime().asMilliseconds() > 1000)
				return;
		}
		else {
			if ((*it).hasCharacter()) {
				window.draw(imageRect);
			}
			else {
				window.draw(imageRect);
			}
			if (it != this->dialogue.end())
				(*it).drawCharacter(window);

			window.draw(dialoguePaneRect);

			if (it != this->dialogue.end()) {
				if ((*it).isDone()) {
					//textSound.stop();

					if (increasing) {

						enterSymbolOpacity = (255 * ((enterSymbolClock.getElapsedTime().asMilliseconds()/* % 1000*/) / 1000.0));
						if (enterSymbolOpacity >= 254) {
							enterSymbolClock.restart();
							enterSymbolOpacity = 254;
							increasing = false;
						}
					}
					else {
						enterSymbolOpacity = 255 - (255 * ((enterSymbolClock.getElapsedTime().asMilliseconds() /*% 1000*/) / 1000.0));
						if (enterSymbolOpacity <= 1) {
							enterSymbolClock.restart();
							enterSymbolOpacity = 1;
							increasing = true;
						}
					}

					sf::Vector2f pos(this->dialoguePaneRect.getPosition());
					pos.x += this->dialoguePaneRect.getSize().x - (this->enterSymbol.getSize().x * 1.1);
					pos.y += this->dialoguePaneRect.getSize().y - (this->enterSymbol.getSize().y * 1.1);
					this->enterSymbol.setPosition(pos);
					this->enterSymbol.setFillColor(sf::Color(255, 255, 255, enterSymbolOpacity));
					window.draw(enterSymbol);
				}
				else {
					//textSound.play();
				}

				(*it).drawWords(font, charSize, textOrigin, width, window, charDelay, dialogueClock.getElapsedTime().asMilliseconds());

			}

			if (currPlayer != NULL)
				(*(*this->game).getInterfacePointer()).drawPlayerAttributes(window, view, currPlayer, (*currPlayer).getPlayerColor());

			(*(*this->game).getInterfacePointer()).drawPauseMenu(window, view, mouseMode);
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
}