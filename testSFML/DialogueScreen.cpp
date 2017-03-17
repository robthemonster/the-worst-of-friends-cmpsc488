
#include <vector>
#include "DialogueLine.h"
#include <iostream>
#include "ButtonScreen.h"
#include "Interface.h"

#include "DialogueScreen.h"
DialogueScreen::DialogueScreen(Interface * interfacePointer) {
	this->interfacePointer = interfacePointer;
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

void DialogueScreen::setDestination(ButtonScreen ** b)
{
	this->destination = b;
}

void DialogueScreen::resizeView(sf::RenderWindow& window, sf::View& view) {
	float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
	std::cout << aspectRatio << std::endl;
	view.setSize(this->SCREEN_WIDTH, this->SCREEN_WIDTH * aspectRatio);
}

void DialogueScreen::display(sf::RenderWindow & window, sf::View & view) {

	int charSize = 40;
	int charDelay = 20;
	int width = 1300;

	std::vector<DialogueLine>::iterator it = this->dialogue.begin();

	sf::Texture enterSymbol;
	sf::RectangleShape enterSymbolRect;
	int enterSymbolOpacity;
	bool increasing = true;

	sf::Shader blurShader;
	if (!blurShader.loadFromFile("shaders/blur.glsl", sf::Shader::Type::Fragment))
		std::cout << "Shader failed to load" << std::endl;
	blurShader.setUniform("texture", *imageRect.getTexture());
	blurShader.setUniform("blur_radius", 0.0025f);
	sf::RenderStates blurStates(&blurShader);

	if (!enterSymbol.loadFromFile("img/enter.png")) {
		std::cout << "Cannot load from file" << std::endl;
	};
	enterSymbolRect.setTexture(&enterSymbol);
	enterSymbolRect.setSize(sf::Vector2f(enterSymbolRect.getTextureRect().width * 0.40, enterSymbolRect.getTextureRect().height * 0.40));
	enterSymbolRect.setPosition(500, 420);
	imageRect.setPosition(window.getView().getSize().x * -0.5, window.getView().getSize().y * -0.5);
	imageRect.setSize(window.getView().getSize());
	setTextOrigin(sf::Vector2f(dialoguePaneRect.getPosition().x + 50, dialoguePaneRect.getPosition().y + 50));

	sf::Clock enterSymbolClock;
	sf::Clock dialogueClock;

	while (window.isOpen()) {
		sf::Event evnt;
		while (window.pollEvent(evnt)) {
			switch (evnt.type) {
			case sf::Event::Closed:
				window.close();
			case sf::Event::KeyPressed:
				if (sf::Keyboard::isKeyPressed(sf::Keyboard::Return) && !(*this->interfacePointer).getPaused()) {
					//enter pressed
					if (it != this->dialogue.end()) {// if this is the not the last dialogue line
						if ((*it).isDone()) { // if the current line is finished printing
							(*it).setDone(false);
							it++;
							dialogueClock.restart();
							if (it == this->dialogue.end()) {
								if (*this->destination != nullptr)
									(**this->destination).display(window, view);
								return;
							}
						}
						else {
							(*it).setDone(true);
						}
					}
				}
				if (sf::Keyboard::isKeyPressed(sf::Keyboard::Escape)) {
					(*this->interfacePointer).setPaused(!(*this->interfacePointer).getPaused());
				}
				break;
			case sf::Event::Resized:
				resizeView(window, view);
				break;
			case sf::Event::MouseButtonReleased:
				switch (evnt.mouseButton.button) {
				case sf::Mouse::Left:
					if ((*this->interfacePointer).getPaused()) {
						if ((*this->interfacePointer).continueHighlighted()) {
							(*this->interfacePointer).setPaused(false);
						}
						if ((*this->interfacePointer).quitHighlighted()) {
							window.close();
						}
					}
					break;
				}
				break;
			}
		}


		window.clear();

		if ((*it).hasCharacter()) {
			window.draw(imageRect, blurStates);
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


				enterSymbolRect.setFillColor(sf::Color(255, 255, 255, enterSymbolOpacity));
				window.draw(enterSymbolRect);
			}
			else {
				//textSound.play();
			}

			(*it).drawWords(font, charSize, textOrigin, width, window, charDelay, dialogueClock.getElapsedTime().asMilliseconds());

		}
		(*this->interfacePointer).drawPauseMenu(window, view);
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