#include "ButtonScreen.h"
#include <vector>
#include <iostream>
#include <iterator>
#include "FButton.h"
#include "DialogueScreen.h"


ButtonScreen::ButtonScreen(sf::Texture & texture)
{
	this->imageTexture = texture;
}

ButtonScreen::ButtonScreen(const ButtonScreen & copy)
{
	buttons = copy.buttons;
	destination = (copy.destination);
}





void ButtonScreen::addButton(FButton * button) {
	this->buttons.push_back(button);
}


void ButtonScreen::display(sf::RenderWindow & window, sf::View & view) {
	sf::Texture  backgroundTexture;
	sf::RectangleShape  background;

	std::vector<FButton* >::iterator it;
	
	
	backgroundTexture.loadFromFile("img/bg.jpg");
	imageRect.setTexture(&imageTexture);



	imageRect.setPosition(-958, -550);
	imageRect.setSize(sf::Vector2f(1920, 700));

//	imageRect.setPosition(window.getPosition().x - window.getSize().x * 0.60, window.getPosition().y - window.getSize().y*0.6);

	background.setTexture(&backgroundTexture);

	background.setPosition(window.getView().getCenter().x - (window.getView().getSize().x / 2), window.getView().getCenter().y - (window.getView().getSize().y / 2));


	background.setSize(sf::Vector2f(window.getView().getSize().x, window.getView().getSize().y));

	bool optionSelected = false;

	while (window.isOpen()) {

		sf::Event evnt;
		while (window.pollEvent(evnt)) {
			switch (evnt.type) {
				case sf::Event::MouseMoved :
					it = this->buttons.begin();
					while (it != this->buttons.end()) {
						if ((**it).mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window)))) {
							(**it).setHighlighted(true);
						}
						else { 
							(**it).setHighlighted(false);
						}
						it++;
					}
				break;
				case sf::Event::MouseButtonReleased:
					switch (evnt.mouseButton.button) {
					case sf::Mouse::Left: //left mouse released.
						it = this->buttons.begin();
						while (it != this->buttons.end()) {
							if ((**it).mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window)))) {
								(**it).setHighlighted(false);
								(*(**it).getDialogueScreen()).display(window, view);
								return;

							}
							it++;
						}
						break;
					}
					break;
				case sf::Event::Resized:
					resizeView(window, view, background);
					break;
				case sf::Event::Closed:
					window.close();
					break;
			}
		}



		

		window.clear();
		window.draw(background);
		window.draw(imageRect);

		 it = this->buttons.begin();
		while (it != this->buttons.end()) {
			(**it).draw(window, view);
			it++;
		}
		window.display();
		if (optionSelected) {
			(*this->destination).display(window, view);
		}
		

	}

	
}

void ButtonScreen::resizeView(sf::RenderWindow& window, sf::View& view, sf::RectangleShape &background) {
	float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
	std::cout << aspectRatio << std::endl;
	background.setSize(sf::Vector2f(this->SCREEN_WIDTH, this->SCREEN_WIDTH * aspectRatio));
	view.setSize(this->SCREEN_WIDTH, this->SCREEN_WIDTH * aspectRatio);
}

ButtonScreen::~ButtonScreen() {
//	delete &buttons;
	//delete destination;
}