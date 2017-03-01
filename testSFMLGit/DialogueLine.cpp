#include "DialogueLine.h"
#include <sstream>
#include <iostream>
#include <vector>
#include <iterator>




DialogueLine::DialogueLine(sf::String words) {
	this->words = words;
}



void DialogueLine::draw(sf::RenderWindow & window, sf::Vector2f origin, sf::Font &font,
	int charDelayMs, int charSize, float width, int millisecElapsed) {
	sf::Text curr;
	if (charDelayMs <= 0 || done) {
		drawWords(curr, font, charSize, origin, width, window, charDelayMs, millisecElapsed);
	}
	else {
		drawWords(curr, font, charSize, origin, width, window, charDelayMs, millisecElapsed);
	}
}

void DialogueLine::drawWords(sf::Text curr, sf::Font font, int charSize, sf::Vector2f origin, int width, sf::RenderWindow & window, int charDelayMs, int millisecElapsed)
{
	sf::Text space(" ", font, charSize);
	sf::Text capital("T", font, charSize);
	int cursorX = origin.x, cursorY= origin.y;
	for (int i = 0; (done || i < millisecElapsed / charDelayMs) && i < words.length(); i++) {
		if (millisecElapsed / charDelayMs >= words.length())
		{
			done = true;
		}
		curr = sf::Text(this->words[i], font, charSize);
		curr.setOutlineColor(sf::Color::Black);
		curr.setOutlineThickness(2);
		curr.setPosition(sf::Vector2f(cursorX, cursorY));
		window.draw(curr);
		cursorX = cursorX + curr.getLocalBounds().width;
		if (cursorX > origin.x + width) {
			cursorY = cursorY + (capital.getLocalBounds().height * 1.5);
			cursorX = origin.x;
		}
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

