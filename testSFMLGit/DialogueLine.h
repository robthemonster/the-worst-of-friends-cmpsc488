#pragma once
#include <SFML\Graphics.hpp>

class DialogueLine
{
private:
	//std::vector<sf::String> words;
	std::string words;
	int wordsCount;
	int timeOnDialogue;
	sf::Clock clock;
	bool done = false;
	void drawWords(sf::Text curr, sf::Font font, int charSize, sf::Vector2f origin, int width,
		sf::RenderWindow & window, int charDelayMs, int millisecElapsed);
public:
	bool isDone();
	void setDone(bool set);
	
	DialogueLine();
	DialogueLine(sf::String);
	void draw(sf::RenderWindow & window, sf::Vector2f origin, sf::Font & font, int wordDelayMs, int charSize, float width, int millisecElapsed);
	~DialogueLine();
};

