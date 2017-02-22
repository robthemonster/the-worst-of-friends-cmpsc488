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

static float VIEW_HEIGHT = 1080.0f;
static float VIEW_WIDTH = 1920.0f;
sf::Texture buttonTexture1, buttonTexture2;


void resizeView(sf::RenderWindow& window, sf::View& view) {
	float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
	std::cout << aspectRatio << std::endl;

	view.setSize(VIEW_WIDTH, VIEW_WIDTH * aspectRatio);
}

static sf::Vector2f Vector2iTo2f(sf::Vector2i& in) {
	return sf::Vector2f((float)in.x, (float)in.y);
}
static FButton *  getFButton1( ButtonScreen * bs, DialogueScreen * ds) {
	return new FButton(sf::Vector2f(buttonTexture1.getSize().x, buttonTexture1.getSize().y), buttonTexture1, bs, ds, sf::Vector2f(-500, 300));
}
static FButton *getFButton2( ButtonScreen * bs, DialogueScreen*  ds) {
	return new FButton(sf::Vector2f(buttonTexture2.getSize().x, buttonTexture2.getSize().y), buttonTexture2, bs, ds, sf::Vector2f(400, 300));

}
	

int main() {
	
	std::vector<std::string> english;
	std::ifstream englishIn;
	englishIn.open("words.txt");
	std::string word;
	while (englishIn>>word) {
		english.push_back(word);
	}
	sf::Music song;
	sf::Texture background, imageTextureCold,imageTextureBastion, imageTextureSatellites, imageTextureSniffer;
	song.openFromFile("mp3/song.ogg");
	song.play();
	
	sf::RenderWindow gameWindow(sf::VideoMode(1600, 900), "Game Window", sf::Style::Close | sf::Style::Resize);
	sf::View view(sf::Vector2f(0.0f, 0.0f), sf::Vector2f(VIEW_WIDTH, VIEW_HEIGHT));
	gameWindow.setView(view);
	
//	gameWindow.setJoystickThreshold(0);
	

	background.loadFromFile("img/bg.jpg");
	imageTextureCold.loadFromFile("img/cold.jpg");
	imageTextureBastion.loadFromFile("img/bastion.jpg");
	imageTextureSatellites.loadFromFile("img/satellites.jpg");
	imageTextureSniffer.loadFromFile("img/sniffer.jpg");

	buttonTexture1.loadFromFile("img/option0.png");
	buttonTexture2.loadFromFile("img/option1.png");


	DialogueScreen ds1(imageTextureBastion);
	DialogueScreen ds2(imageTextureCold);
	DialogueScreen ds3(imageTextureSatellites);
	DialogueScreen ds4(imageTextureSniffer);
	std::string* dialogues = new std::string[8];

	std::srand(time(NULL));
	for (int i = 0; i < 30; i++) {
		for (int j = 0; j < 8; j++)
			dialogues[j] += english.at(rand() % english.size()) + " ";
			
			
	
	}

	
		ds1.addDialogueLine(DialogueLine(dialogues[0]));
		ds1.addDialogueLine(DialogueLine(dialogues[1]));

		ds2.addDialogueLine(DialogueLine(dialogues[2]));
		ds2.addDialogueLine(DialogueLine(dialogues[3]));

		ds3.addDialogueLine(DialogueLine(dialogues[4]));
		ds3.addDialogueLine(DialogueLine(dialogues[5]));

		ds4.addDialogueLine(DialogueLine(dialogues[6]));
		ds4.addDialogueLine(DialogueLine(dialogues[7]));
	
	


	ButtonScreen bs1(imageTextureBastion);
	ButtonScreen bs2(imageTextureCold);
	ButtonScreen bs3(imageTextureSatellites);
	ButtonScreen bs4(imageTextureSniffer);
	
	ButtonScreen ** bs = new ButtonScreen*[4];
	bs[0] = &bs1;
	bs[1] = &bs2;
	bs[2] = &bs3;
	bs[3] = &bs4;
	

	
		int *x1 = new int[4]; 
		int *x2 = new int[4]; 
		for (int i = 0; i < 4; i++) {
			x1[i] = rand() % 4;
			x2[i] = rand() % 4;
		}
		DialogueScreen * tar1,* tar2;
		for (int i = 0; i < 4; i++) {
			int xA = x1[i], xB = x2[i];

			switch (xA) {
			case 0:
				tar1 = &ds1;
				break;
			case 1:
				tar1 = &ds2;
				break;
			case 2:
				tar1 = &ds3;
				break;
			case 3:
				tar1 = &ds4;
				break;
			default:
				tar1 = NULL;
				break;

			}
			switch (xA) {
			case 0:
				tar2 = &ds1;
				break;
			case 1:
				tar2 = &ds2;
				break;
			case 2:
				tar2 = &ds3;
				break;
			case 3:
				tar2 = &ds4;
				break;
			default:
				tar2 = NULL;
				break;
			}
			if (tar1 != nullptr)
				(*bs[i]).addButton(getFButton1(bs[i], tar1));
			if (tar2 != nullptr)
				(*bs[i]).addButton(getFButton2(bs[i], tar2));
		}
	
		
	

	ds1.setDestination(bs[0]);
	ds2.setDestination(bs[1]);

	ds3.setDestination(bs[2]);
	ds4.setDestination(bs[3]);
	
	
	
	(*tar1).display(gameWindow, view);

	delete bs;


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