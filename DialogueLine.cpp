#include "DialogueLine.h"
#include <iostream>
#include "Character.h"




DialogueLine::DialogueLine(sf::String words, Character * character, std::string key, sf::Vector2f characterPosition) {
	this->words = words;
	this->character = character;
	this->key = key;
	this->characterPosition = characterPosition;
}



/*void DialogueLine::draw(sf::RenderWindow & window, sf::Vector2f origin, sf::Font &font,
	int charDelayMs, int charSize, float width, int millisecElapsed) {
	
		drawWords( font, charSize, origin, width, window, charDelayMs, millisecElapsed);
	
}*/
void DialogueLine::drawCharacter(sf::RenderWindow& window) {
	if (character != NULL && !key.empty()) {
		(*character).draw(window, key, characterPosition);

	}
}

void DialogueLine::drawWords(sf::Font font, int charSize, sf::Vector2f origin, int width, sf::RenderWindow & window, int charDelayMs, int millisecElapsed)
{
	sf::Text curr;

	sf::Text currWord;

	

	sf::Text space(" ", font, charSize);
	sf::Text capital("T", font, charSize);
	float cursorX = origin.x, cursorY= origin.y;
	for (int i = 0; (done || i < millisecElapsed / charDelayMs) && i < words.length(); i++) {
		if (millisecElapsed / charDelayMs >= words.length())
		{
			done = true;
		}
		if (this->words[i] != ' ') {
			int lastPos = this->words.find_first_of(" ", i);

			std::string wordRem = this->words.substr(i, lastPos - i);
			if (wordRem.at(wordRem.length() - 1) == '.' && wordRem.length() > 0)
				wordRem = wordRem.substr(0, wordRem.length() - 1);
				
			
			if (wordRem == "their")
				std::cout << std::endl;
			
			
			

			currWord = sf::Text(sf::String(wordRem), font, charSize);
			
		//	currWord.setPosition(sf::Vector2f(cursorX, cursorY));
	

			currWord.getLocalBounds().width;
			
			
			if (cursorX + currWord.getLocalBounds().width > origin.x + width ) {
				wordRem;
				cursorY = cursorY + font.getLineSpacing(charSize);
				cursorX = origin.x;
				
			}
		}
		else {
			std::cout << std::endl;
		}
		
		curr = sf::Text(sf::String(this->words[i]), font, charSize);
		curr.setOutlineColor(sf::Color::Black);
		curr.setOutlineThickness(2);
		curr.setPosition(sf::Vector2f(cursorX, cursorY));
		window.draw(curr);
		cursorX = cursorX + curr.getLocalBounds().width;
		/*if (cursorX > origin.x + width) {
			cursorY = cursorY + (capital.getLocalBounds().height * 1.5);
			cursorX = origin.x;
		}*/
	}
	if (words.length() == 0)
		done = true;
}


bool DialogueLine::isDone() {
	return done;
}
void DialogueLine::setDone(bool set) {
	this->done = set;
}
bool DialogueLine::hasCharacter() {
	return this->character != NULL;
}

DialogueLine::~DialogueLine()
{
}

