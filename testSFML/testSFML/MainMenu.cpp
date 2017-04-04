#include "FButton.h"
#include "MainMenu.h"



void MainMenu::setImageTexture(sf::Texture & texture)
{
	this->image.setTexture(&texture);
}

void MainMenu::setMusicFile(sf::Music & stream, std::string file)
{
	this->music = &stream;
	this->musicFile = file;
}

void MainMenu::setPlayGameSound(std::string file)
{
	this->playGameSoundFile = file;
}

void MainMenu::display(sf::RenderWindow & window, sf::View & view)
{
	if (this->music != NULL) {
		(*this->music).openFromFile(this->musicFile);
		(*this->music).setLoop(true);
		(*this->music).play();
	}
	if (this->playGameSoundFile != "") {
		this->playGameSoundBuffer.loadFromFile(this->playGameSoundFile);
		this->playGameSound.setBuffer(this->playGameSoundBuffer);
	}
	this->image.setPosition(window.getView().getSize().x * -0.5, window.getView().getSize().y * -0.5);
	this->image.setSize(window.getView().getSize());

	while (window.isOpen()) {

		
		sf::Event evnt;
		while (window.pollEvent(evnt)) {
			switch (evnt.type) {
			case sf::Event::MouseButtonReleased:
				switch (evnt.mouseButton.button) {
				case sf::Mouse::Left:
					if ((*this->playGame).isHighlighted()) {
						(*music).stop();
						playGameSound.play();
							return;
					}
					else if ((*this->quit).isHighlighted())
						window.close();
					break;
				}
				break;
			}
		}
		(*this->playGame).setHighlighted((*this->playGame).mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window))));
		(*this->quit).setHighlighted((*this->quit).mouseOver(window.mapPixelToCoords(sf::Mouse::getPosition(window))));
		(*this->playGame).setPosition(0, window.getView().getSize().y * 0.15);
		(*this->quit).setPosition(0, window.getView().getSize().y *0.2);
		
		window.clear();
		window.draw(this->image);
		(*this->playGame).draw(window, view);
		(*this->quit).draw(window, view);

		window.display();
	}
}



MainMenu::MainMenu()
{
	sf::Vector2f buttonSize(300, 200);

	sf::Vector2f playGamePos, quitGamePos;

	sf::Font font;
	font.loadFromFile("fonts/8bit.ttf");

	this->playGame = new FButton(buttonSize,NULL, playGamePos, "Play Game", font, 40);
	this->quit = new FButton(buttonSize, NULL, quitGamePos, "Quit", font, 40);
}


MainMenu::~MainMenu()
{
}
