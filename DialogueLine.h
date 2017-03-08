#pragma once
#include <SFML\Graphics.hpp>
#include <SFML\Audio.hpp>
class Character;
class DialogueLine
{
private:
	//std::vector<sf::String> words;
	std::string words;
	int wordsCount;
	int timeOnDialogue;
	sf::Clock clock;
	bool done = false;
	

	Character * character = NULL;
	sf::Vector2f characterPosition;
	std::string key;
public:
	bool isDone();
	void setDone(bool set);
	bool hasCharacter();
	DialogueLine(sf::String line, Character * character = NULL, std::string key = "",
		sf::Vector2f characterPosition = sf::Vector2f());
	void drawCharacter(sf::RenderWindow& window);
	void drawWords(sf::Font font, int charSize, sf::Vector2f origin, int width,
		sf::RenderWindow & window, int charDelayMs, int millisecElapsed);
//	void draw(sf::RenderWindow & window, sf::Vector2f origin, sf::Font & font, int wordDelayMs, int charSize, float width, int millisecElapsed);
	~DialogueLine();
};

