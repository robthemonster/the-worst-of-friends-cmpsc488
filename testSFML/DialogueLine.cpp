
#include <iostream>
#include "Character.h"



#include "DialogueLine.h"
DialogueLine::DialogueLine(sf::String words, Character * character, std::string key, sf::Vector2f characterPosition) {
	this->words = words;
	this->character = character;
	this->key = key;
	this->characterPosition = characterPosition;

	textBuffer.loadFromFile("music/lttpText.wav");
	textDoneBuffer.loadFromFile("music/lttpTextDone.wav");
	
}

void DialogueLine::drawCharacter(sf::RenderWindow& window) {
	if (character != NULL && !key.empty()) {
		(*character).draw(window, key, characterPosition);

	}
}

void DialogueLine::drawWords(sf::Font font, int charSize, sf::Vector2f origin, int width, sf::RenderWindow & window, int charDelayMs, int millisecElapsed)
{
	if (textSound.getStatus() != sf::Sound::Status::Playing && !textDoneSoundPlayed) { //if the textSound isnt playing, and textDoneSound hasnt been played
		textDoneSound.setBuffer(textDoneBuffer);
		textSound.setBuffer(textBuffer);
		textSound.setLoop(true);
		textSound.play();
	}
	sf::Text curr;
	sf::Text currWord;
	std::string wordRem;
	int lastLetterPos;
	float cursorX = origin.x, cursorY = origin.y;
	for (int i = 0; (done || i < millisecElapsed / charDelayMs) && i < words.length(); i++) {
		if (millisecElapsed / charDelayMs >= words.length())
		{
			done = true;
		}
		if (this->words[i] != ' ') {
			if (this->words.substr(0, i).find_last_of(' ') == i - 1) { //if this is the first letter of a word
				lastLetterPos = this->words.find_first_of(" ", i);
				wordRem = this->words.substr(i, lastLetterPos - i);
				currWord = sf::Text(sf::String(wordRem), font, charSize);
				currWord.setOutlineThickness(2);
				if (cursorX + currWord.getLocalBounds().width > origin.x + width) { //if this word will go out of bounds, go to new line
					cursorY = cursorY + font.getLineSpacing(charSize);
					cursorX = origin.x;
				}
			}
		}
		curr = sf::Text(sf::String(this->words[i]), font, charSize);
		curr.setOutlineColor(sf::Color::Black);
		curr.setOutlineThickness(2);
		curr.setPosition(sf::Vector2f(cursorX, cursorY));
		window.draw(curr);
		cursorX = cursorX + curr.getLocalBounds().width;

	}
	if (words.length() == 0)
		done = true;
	if (done && !textDoneSoundPlayed) {
		textSound.stop();
		textDoneSound.play();
		textDoneSoundPlayed = true;
	}
}


bool DialogueLine::isDone() {
	return done;
}
void DialogueLine::setDone(bool set) {
	this->done = set;
	if (textDoneSoundPlayed && !set) //text-done sound played, but dialogue is being reset, so reset text-done sound played flag
		textDoneSoundPlayed = set;
		
}
bool DialogueLine::hasCharacter() {
	return this->character != NULL;
}

DialogueLine::~DialogueLine()
{
}

