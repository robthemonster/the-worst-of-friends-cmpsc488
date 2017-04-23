#include "FButton.h"
#include "Game.h"
#include "Interface.h"
#include "MainMenu.h"




void MainMenu::setFont(sf::Font font)
{
	this->font = font;
	sf::Vector2f buttonSize(300, 200);

	sf::Vector2f playGamePos, quitGamePos;



	this->playGame = new FButton(buttonSize, NULL, playGamePos, FButton::HIGHLIGHT_TEXT, "Play", font, 40);
	this->quit = new FButton(buttonSize, NULL, quitGamePos, FButton::HIGHLIGHT_TEXT, "Quit", font, 40);
}

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

void MainMenu::display(sf::RenderWindow & window, sf::View & view, bool fadeIn)
{
	bool pressedPlay = false;
	sf::Clock fade;

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

	sf::Vector2f lastMousePos;
	bool mouseMode = true;
	while (window.isOpen()) {

		
		sf::Event evnt;
		while (window.pollEvent(evnt)) {
			switch (evnt.type) {
			case sf::Event::MouseMoved:
				if (window.mapPixelToCoords(sf::Mouse::getPosition(window)) != lastMousePos) {
					mouseMode = true;
					lastMousePos = window.mapPixelToCoords(sf::Mouse::getPosition(window));
				}
				break;
			case sf::Event::KeyPressed:
				switch (evnt.key.code) {
				case sf::Keyboard::Up:
				case::sf::Keyboard::Left:
				case::sf::Keyboard::Right:
				case::sf::Keyboard::Down:
					if (mouseMode) {
						(*playGame).setHighlighted(true);
						(*quit).setHighlighted(false);
						mouseMode = false;
					}
					else {
						(*playGame).setHighlighted(!(*playGame).isHighlighted());
						(*quit).setHighlighted(!(*quit).isHighlighted());
					}
					break;
				case::sf::Keyboard::Return:
					if (!mouseMode) {
						if ((*this->playGame).isHighlighted()) {
							if (music != NULL)
								(*music).stop();
							if (playGameSoundFile != "")
								playGameSound.play();
							fade.restart();
							pressedPlay = true;
						}
						else if ((*this->quit).isHighlighted())
							window.close();
					}
				}
				break;
			case sf::Event::MouseButtonReleased:
				switch (evnt.mouseButton.button) {
				case sf::Mouse::Left:
					if ((*this->playGame).isHighlighted()) {
						if (music != NULL)
							(*music).stop();
						if (playGameSoundFile != "")
							playGameSound.play();
						fade.restart();
						pressedPlay = true;
					}
					else if ((*this->quit).isHighlighted())
						window.close();
					break;
				}
				break;
			
			}
		}
		(*this->playGame).setPosition(0, window.getView().getSize().y * 0.15);
		(*this->quit).setPosition(0, window.getView().getSize().y *0.2);
		
		window.clear();
		window.draw(this->image);
		(*this->playGame).draw(window, view,mouseMode, false);
		(*this->quit).draw(window, view, mouseMode, false);

		if (pressedPlay) {
			(*(*this->game).getInterfacePointer()).drawFade(window, view, fade.getElapsedTime().asMilliseconds(), true);
			if (fade.getElapsedTime().asMilliseconds() >= 1000)
				return;
		}

		window.display();
	}
}



MainMenu::MainMenu(Game * game)
{
	this->game = game;
}


MainMenu::~MainMenu()
{
}
