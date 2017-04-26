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
	bool soundEffectPlayed = false;
	sf::SoundBuffer textBuffer, textDoneBuffer;
	sf::Sound textSound, textDoneSound;
	
	sf::SoundBuffer soundEffectBuffer;
	sf::Sound soundEffect;


	Character * character = NULL;
	sf::Vector2f characterPosition;
	std::string key;
	std::vector<Impact *> impacts;

public:
	bool isDone();
	void setDone(bool set);
	bool hasCharacter();
	void addImpact(Impact * impact);
	void processImpact();
	DialogueLine(sf::String line, std::string dialogueScrollSound, std::string dialogueEndSound,std::string soundEffectPath, Character * character = NULL, std::string key = "",
		sf::Vector2f characterPosition = sf::Vector2f());
	void drawCharacter(sf::RenderWindow& window);
	void drawWords(sf::Font font, int charSize, sf::Vector2f origin, int width,
		sf::RenderWindow & window, int charDelayMs, int millisecElapsed);
	~DialogueLine();
};

