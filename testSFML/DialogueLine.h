#pragma once
#include <SFML\Graphics.hpp>
#include <SFML\Audio.hpp>
class Character;
class Impact;
class DialogueLine
{
private:
	std::string words;
	int wordsCount;
	int timeOnDialogue;
	sf::Clock clock;
	bool done = false;
	bool textDoneSoundPlayed = false;
	sf::SoundBuffer textBuffer, textDoneBuffer;
	sf::Sound textSound, textDoneSound;
	Character * character = NULL;
	sf::Vector2f characterPosition;
	std::string key;
	Impact * impact = NULL;

public:
	bool isDone();
	void setDone(bool set);
	bool hasCharacter();
	void setImpact(Impact * impact);
	void processImpact();
	DialogueLine(sf::String line, Character * character = NULL, std::string key = "",
		sf::Vector2f characterPosition = sf::Vector2f());
	void drawCharacter(sf::RenderWindow& window);
	void drawWords(sf::Font font, int charSize, sf::Vector2f origin, int width,
		sf::RenderWindow & window, int charDelayMs, int millisecElapsed);
	~DialogueLine();
};

