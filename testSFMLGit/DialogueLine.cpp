#include "DialogueLine.h"
#include <sstream>
#include <iostream>
#include <vector>
#include <iterator>




DialogueLine::DialogueLine(sf::String words) {
	
	std::istringstream input(words);
	
	int i = 0;
	do {
		std::string read;
		input >> read;
		this->words.push_back(sf::String(read));
		i++;
	} while (input);
	
	this->wordsCount = i;
	
	
}


void DialogueLine::draw(sf::RenderWindow & window,  sf::Vector2f origin, sf::Font &font, int wordDelayMs, int charSize, float width, int millisecElapsed ) {
	
	sf::Text space(sf::String(" "), font, charSize);
	sf::Text capital(sf::String("T"), font, charSize);
	int sec = millisecElapsed / 1000;

	std::vector<sf::String>::iterator it = this->words.begin();
	float cursorX = origin.x;
	float cursorY = origin.y;
	if (wordDelayMs <= 0 || done) {
		while (it != this->words.end()) {
			sf::Text word(*it, font, charSize);
			word.setOutlineColor(sf::Color::Black);
			word.setOutlineThickness(2);
			word.setPosition(sf::Vector2f(cursorX, cursorY));
			window.draw(word);
			cursorX = cursorX + word.getLocalBounds().width + space.getLocalBounds().width;

			if (cursorX > origin.x + width) {
				cursorY = cursorY +  (capital.getLocalBounds().height * 1.5);
				cursorX = origin.x;
			}
			it++;
		}
		done = true;
	}
	else {

		for (int i = 0; i < millisecElapsed / wordDelayMs && it != this->words.end(); i++) {


			sf::Text word(*it, font, charSize);
			word.setOutlineThickness(2);
			word.setPosition(sf::Vector2f(cursorX, cursorY));
			window.draw(word);
			cursorX = cursorX + word.getLocalBounds().width + space.getLocalBounds().width;
			if (cursorY > window.getView().getSize().y)
				std::cout << "Text cut off in Y direction" << std::endl;
			if (cursorX > window.getView().getSize().x)
				std::cout << "Text cut off in X direction "<< std::endl;
			if (cursorX > origin.x + width) {
				cursorY = cursorY +(capital.getLocalBounds().height * 1.5);
				cursorX = origin.x;
			}
			it++;

		}
		if (it == this->words.end())
			done = true;
	}

}

bool DialogueLine::isDone() {
	return done;
}
void DialogueLine::setDone(bool set) {
	this->done = set;
}

DialogueLine::~DialogueLine()
{
}

