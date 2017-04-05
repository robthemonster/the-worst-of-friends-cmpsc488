#pragma once
#include "Navigable.h"

class FButton;
class MainMenu : public Navigable
{
private:
	FButton * playGame;
	FButton * quit;

	sf::Music * music = NULL;
	std::string musicFile = "";

	sf::Sound playGameSound;
	sf::SoundBuffer playGameSoundBuffer;

	std::string playGameSoundFile = "";

	sf::RectangleShape image;
	sf::Font font;
	
public:
	void setFont(sf::Font font);
	void setImageTexture(sf::Texture & texture);
	void setMusicFile(sf::Music & stream, std::string file);
	void setPlayGameSound(std::string file);
	void display(sf::RenderWindow & window, sf::View & view);
	MainMenu();
	~MainMenu();
};

