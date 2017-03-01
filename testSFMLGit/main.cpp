#include <SFML\Graphics.hpp>
#include <iostream>
#include "DialogueScreen.h"
#include "DialogueLine.h"
#include "ButtonScreen.h"
#include "FButton.h"
#include "Path.h"
#include <SFML/Audio.hpp>
#include <string>
#include <fstream>
#include <ctime>
#include <cstdlib>
#include <Windows.h>
#include <sstream>

static float VIEW_HEIGHT = 1080.0f;
static float VIEW_WIDTH = 1920.0f;
sf::Vector2f dialoguePanePos(-750, 200);


static std::vector<std::string> split(std::string str, char delimiter) {
	std::vector<std::string> internal;
	std::stringstream ss(str); // Turn the string into a stream.
	std::string tok;

	while (std::getline(ss, tok, delimiter)) {
		internal.push_back(tok);
	}

	return internal;
}


static FButton *  getFButton(Navigable * ds, std::string word, int x, int y);

void resizeView(sf::RenderWindow& window, sf::View& view) {
	float aspectRatio = float(window.getSize().y) / float(window.getSize().x);
	std::cout << aspectRatio << std::endl;

	view.setSize(VIEW_WIDTH, VIEW_WIDTH * aspectRatio);
}

static sf::Vector2f Vector2iTo2f(sf::Vector2i& in) {
	return sf::Vector2f((float)in.x, (float)in.y);
}

sf::Font font;


int main() {

	sf::Font font;
	sf::Texture dialoguePane;
	sf::Vector2f dialoguePanePos(-750, 200);
	sf::Vector2f buttonSize(300, 100);
	sf::Vector2f button1Pos(-400, 300);
	sf::Vector2f button2Pos(200, 300);

	font.loadFromFile("fonts/8bit.ttf");

	/*
	dialoguePane.loadFromFile("img/dialoguePane.png");
	sf::Texture winter, fight, die;
	winter.loadFromFile("img/winter.jpg");
	fight.loadFromFile("img/fight.jpg");
	die.loadFromFile("img/die.jpg");

	Path p1, p2, p3;
	p1.setImageTexture(winter);
	p2.setImageTexture(fight);
	p3.setImageTexture(die);

	p1.setDialoguePaneTexture(dialoguePane,dialoguePanePos);
	p2.setDialoguePaneTexture(dialoguePane, dialoguePanePos);
	p3.setDialoguePaneTexture(dialoguePane, dialoguePanePos);

	p1.setFont(font);
	p2.setFont(font);
	p3.setFont(font);

	p1.setButtonSize(buttonSize);
	p2.setButtonSize(buttonSize);
	p3.setButtonSize(buttonSize);
	p1.setButtonCharSize(40);
	p2.setButtonCharSize(40);
	p3.setButtonCharSize(40);
	
	p1.addDialogueLine(&DialogueLine("Blarg blarg. Blarg blarg blarg. Blarg blarg. Blarg blarg blarg."));
	p1.setPrompt("Will u fite or die");
	p1.addButton("fight", &p2, button1Pos);
	p1.addButton("die", &p3, button2Pos);

	p2.addButton("restart", &p1, button1Pos);
	p3.addButton("restart", &p1, button1Pos);

	p2.addDialogueLine(&DialogueLine("u chose to fight."));
	p2.addDialogueLine(&DialogueLine("it didnt go well. sry"));
	p2.addDialogueLine(&DialogueLine("soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas "));

	p3.addDialogueLine(&DialogueLine("u chose to die"));
	p3.addDialogueLine(&DialogueLine("why did you do that?"));
	p3.addDialogueLine(&DialogueLine("soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas soas ")); 

	sf::RenderWindow window(sf::VideoMode(1600, 900), "Game Window", sf::Style::Close | sf::Style::Resize);
	sf::View view(sf::Vector2f(0.0f, 0.0f), sf::Vector2f(VIEW_WIDTH, VIEW_HEIGHT));
	window.setView(view);
	p1.display(window, view);
	*/
	
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

	
	Path * p = new Path[ARRAYSIZE(imageFiles)];

	for (int i = 0; i < ARRAYSIZE(imageFiles); i++) {

		p[i].setFont(font);
		p[i].setButtonCharSize(40);
		p[i].setButtonSize(buttonSize);
		p[i].setImageTexture(imageTextures[i]);
		p[i].setDialoguePaneTexture(dialoguePaneTexture, dialoguePanePos);
		
		p[i].addButton(english[rand()%english.size()], &p[rand() % ARRAYSIZE(imageFiles)], button1Pos);
		p[i].addButton(english[rand() % english.size()], &p[rand() % ARRAYSIZE(imageFiles)], button2Pos);

		std::string prompt;
		for (int j = 0; j < 6; j++) {
			prompt += english[rand() % english.size()] + " ";
		}
		prompt += "?";
		
		p[i].setPrompt(prompt);

		std::string * dialogue = new std::string[2];
		for (int j = 0; j < 30; j++) {
			dialogue[0] += " "+ english[rand() % english.size()] ;
			dialogue[1] += " " + english[rand() % english.size()] ;
			if (j % 13 == 0 && j > 0) {
				dialogue[0] += ",";
				dialogue[1] += ",";
			}
			if (j % 7 == 0 && j > 0) {
				dialogue[0] += ".";
				dialogue[1] += ".";
			}
		}

		p[i].addDialogueLine(&DialogueLine(dialogue[0]));
		p[i].addDialogueLine(&DialogueLine(dialogue[1]));


	}

	

	Navigable * n = &p[rand() % ARRAYSIZE(imageFiles)];


	sf::RenderWindow gameWindow(sf::VideoMode(1600, 900), "Game Window", sf::Style::Close | sf::Style::Resize);
	sf::View view(sf::Vector2f(0.0f, 0.0f), sf::Vector2f(VIEW_WIDTH, VIEW_HEIGHT));
	gameWindow.setView(view);

	(*n).display(gameWindow, view);
	
	
}


static FButton *getFButton(Navigable *  ds, std::string word, int x, int y) {
	return new FButton(sf::Vector2f(300, 100), ds, sf::Vector2f(x, y), sf::Text(sf::String(word), font, 50), NULL);
}