#include <SFML\Graphics.hpp>
#include <iostream>
#include "DialogueScreen.h"
#include "DialogueLine.h"
#include "ButtonScreen.h"
#include "FButton.h"
#include <SFML/Audio.hpp>
#include <string>
#include <fstream>
#include <ctime>
#include <cstdlib>
#include <Windows.h>

static float VIEW_HEIGHT = 1080.0f;
static float VIEW_WIDTH = 1920.0f;
sf::Vector2f dialoguePanePos(-750, 200);

static FButton *  getFButton(DialogueScreen * ds, std::string word, int x, int y);

void resizeView(sf::RenderWindow& window, sf::View& view) {
	float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
	std::cout << aspectRatio << std::endl;

	view.setSize(VIEW_WIDTH, VIEW_WIDTH * aspectRatio);
}

static sf::Vector2f Vector2iTo2f(sf::Vector2i& in) {
	return sf::Vector2f((float)in.x, (float)in.y);
}



sf::Font font;
sf::Texture buttonTexture;

int main() {
	
	std::vector<std::string> english;
	std::ifstream englishIn;
	englishIn.open("words.txt");
	std::string word;
	while (englishIn>>word) {
		english.push_back(word);
	}
	sf::Music song; 
	sf::Texture background, imageTexture1,imageTexture2, imageTexture3, imageTexture4;
	sf::Texture dialoguePaneTexture;
	
	font.loadFromFile("fonts/8bit.ttf");
	dialoguePaneTexture.loadFromFile("img/dialoguePane.png");
	song.openFromFile("mp3/song.ogg");
	song.play();
	
	sf::RenderWindow gameWindow(sf::VideoMode(1600, 900), "Game Window", sf::Style::Close | sf::Style::Resize );
	sf::View view(sf::Vector2f(0.0f, 0.0f), sf::Vector2f(VIEW_WIDTH, VIEW_HEIGHT));
	gameWindow.setView(view);
	
//	gameWindow.setJoystickThreshold(0);
	

	//buttonTexture.loadFromFile("img/orangebutton.png");
	background.loadFromFile("img/bg.jpg");
	std::string imageFiles[] = { "evil.jpg",
		"giant.jpg",
		"cold.jpg",
		"bastion.jpg",
		"satellites.jpg",
		"titan.jpg",
		"thumbsup.jpg",
		"sentry.jpg",
		"absolver.jpg",
		"scout.jpg",
		"jaguar.jpg",
		"sands.jpg",
		"shenfei.jpg",
		"church.jpg",
		"deer.jpg",
		"tower.jpg",
		"deserttemple.jpg",
		"bridge.jpg",
		"link.jpg",
		"wrath.jpg" };
	
	sf::Texture * imageTextures = new sf::Texture[ARRAYSIZE(imageFiles)];

	for (int i = 0; i < ARRAYSIZE(imageFiles); i++) {
		if (!imageTextures[i].loadFromFile("img/" + imageFiles[i]))
			std::cout << imageFiles[i] << " failed to load" << std::endl;
	}

	DialogueScreen * ds= new DialogueScreen[ARRAYSIZE(imageFiles)];
	ButtonScreen * bs = new ButtonScreen[ARRAYSIZE(imageFiles)];

	for (int i = 0; i < ARRAYSIZE(imageFiles); i++) {
		ds[i].setImageTexture(imageTextures[i]);
		bs[i].setImageTexture(imageTextures[i]);
		ds[i].setDestination(&bs[i]);
		
		DialogueScreen * d1, *d2;
		d1 = &ds[std::rand() % ARRAYSIZE(imageFiles)];
		
		d2 = &(ds[std::rand() % ARRAYSIZE(imageFiles)]);
		

		bs[i].addButton(getFButton(d1, english[rand() % english.size()], -400, 300));
		bs[i].addButton(getFButton(d2, english[rand() % english.size()], 200, 300));
		bs[i].setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);
		std::string prompt;
		for (int j = 0; j < 6; j++) {
			prompt += english[rand() % english.size()] + " ";
		}
		prompt += "?";
		bs[i].setPrompt(sf::Text(sf::String(prompt), font, 40));
		
		std::string * dialogue = new std::string[2];
		for (int j = 0; j < 30; j++) {
			dialogue[0] += " "+ english[rand() % english.size()] ;
			
			dialogue[1] += " " + english[rand() % english.size()] ;

			if (j % 6 == 0)
				dialogue[0] += ".";
			if (j % 8 == 0)
				dialogue[1] += ".";
			
		}
		ds[i].addDialogueLine(DialogueLine(dialogue[0]));
		ds[i].addDialogueLine(DialogueLine(dialogue[1]));

	}
	
	ds[rand() % ARRAYSIZE(imageFiles)].display(gameWindow, view);


	/*DialogueLine d(sf::String("You better off voting for doernlkd trumpfndf"));


	

	if (!buttonHighlighted.loadFromFile("img/buttonHighlight.jpg"))
		std::cout << "FUCK" << std::endl;

	buttonClicked.loadFromFile("img/buttonClicked.jpg");
	imageTexture.loadFromFile("img/1.jpg");
	buttonTexture.loadFromFile("img/button.jpg");
	ImageDisplay image(&imageTexture);
	ImageDisplay button(&buttonTexture);
	bool displayed = false;
	sf::Clock clock;
	sf::Font f;
	f.loadFromFile("fonts/regular.otf");
	DialogueLine hello("How exactly does one get pussy while living at the white house as a teenage boy? The secret service always cock blocking you. when you're trying to run game on some foreign prime ministers daughter the news media catches you smiling at her and immediately blows shit out if proportion speculating that you are somehow breaking international law with your awkward teenage flirting, so you have to testify before congress that you didn't give away any top secret documents to her and are made to admit live on C-SPAN that you've never even kissed a girl . Then you get blue balls from some hot conservative girl winking at you and flashing her panties under her skirt and making sexy faces and blow job motions to you while you were going through some airport or public event, and when you passed by and shook her hand she leans in whispering she is going to diddle her clit thinking about you tonight and how much she wants to suck your dick off, just to fuck with you. Then you try to look up some porn when you get home just to relieve the tension but you just know the CIA is monitoring and 3 other govornment agencies are watching you beat off. Then you finally break down and Jack off in the shower which sets off some fucking biohazard drain alarm and the entire place is on lock down until they can find the source of the specimen and you end up getting debriefed by the joint chiefs of staff about your masturbatory habits and how you almost created a national security issue with your dick. Then wikileaks leaks your search history showing you looked up penis enlargement techniques when it was actually just some click bait you'd accidentally clicked and TYT spends all next week talking about your supposed micro penis. So you end up squirming a little since you are so wound up and being judged constantly and now people are saying you look like a fucking mental patient and you start to think you'll never get any pussy.");
	DialogueScreen fuck;
	fuck.addDialogueLine(hello);
	
	while (gameWindow.isOpen()) {
		sf::Event evnt;
		while (gameWindow.pollEvent(evnt)) {
			switch (evnt.type) {
			case sf::Event::Closed:
				gameWindow.close();
				break;
			case sf::Event::Resized:
				resizeView(gameWindow, view);
				break;
			case sf::Event::MouseButtonReleased:
				if (evnt.mouseButton.button == sf::Mouse::Left) {
					//left click release
					if (button.get().getGlobalBounds().contains(gameWindow.mapPixelToCoords(sf::Mouse::getPosition(gameWindow)))) {
						button.setTexture(&buttonClicked);
						std::cout << "Button Clicked" << std::endl;
					}
					std::cout << sf::Mouse::getPosition(gameWindow).x << " " << sf::Mouse::getPosition(gameWindow).y << std::endl;
				}
				if (evnt.mouseButton.button == sf::Mouse::Right) {
					//right click release
				}
				std::cout << "LOL" << std::endl;
				break;
			case sf::Event::MouseMoved:
				if (button.get().getGlobalBounds().contains(gameWindow.mapPixelToCoords(sf::Mouse::getPosition(gameWindow)))) {
					if (button.get().getTexture() != &buttonHighlighted) {
						button.setTexture(&buttonHighlighted);

						std::cout << "Mouse moved over button" << std::endl;
					}

				}
				else if (button.get().getTexture() != &buttonTexture) {
					button.setTexture(&buttonTexture);

				}
			}

		}
			
			gameWindow.clear();
		
			

			

			view.setCenter(image.get().getPosition());
			gameWindow.draw(image.get());
			button.setPosition(image.get().getPosition().x, image.get().getPosition().y + (image.get().getTextureRect().height/2) + (button.get().getTextureRect().height /2));
			gameWindow.draw(button.get());
			
				gameWindow.display();

			if (!displayed) {
				displayed = true;
				clock.restart();
			}
			
		
	}*/

	
}


static FButton *getFButton(DialogueScreen*  ds, std::string word, int x, int y) {
	return new FButton(sf::Vector2f(300, 100), ds, sf::Vector2f(x, y), sf::Text(sf::String(word), font, 50), NULL);
}