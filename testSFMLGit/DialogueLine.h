#pragma once
#include <SFML\Graphics.hpp>

class DialogueLine
{
private:
	std::vector<sf::String> words;
	int wordsCount;
	int timeOnDialogue;
	sf::Clock clock;
	bool done = false;
	
public:
	bool isDone();
	void setDone(bool set);
	DialogueLine();
	DialogueLine(sf::String);
	void display(sf::RenderWindow & window, sf::Vector2f origin, sf::Font & font, int wordDelayMs, int charSize, float width, int millisecElapsed);
	~DialogueLine();
};

