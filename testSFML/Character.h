#pragma once
#include <SFML\Graphics.hpp>
class Character
{
private:
	sf::RectangleShape characterRect;
	std::map<std::string, sf::Texture > characterImages;
public:
	Character();
	~Character();
	void addCharacterImage(std::string key, std::string fileName);
	void draw(sf::RenderWindow & window, std::string key, sf::Vector2f position);
};

