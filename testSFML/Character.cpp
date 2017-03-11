
#include <iostream>

#include "Character.h"
Character::Character()
{
}


Character::~Character()
{
}

void Character::addCharacterImage(std::string key, std::string val)
{
	sf::Texture add;
	if (!add.loadFromFile(val)) {
		std::cout << "Error loading character texture from file: " << val << std::endl;
		return;
	}

	if (characterImages.find(key) == characterImages.end()) {
		characterImages[key] = add;
	}
	else {
		std::cout << "Duplicate key " << key << std::endl;
	}
}

void Character::draw(sf::RenderWindow & window, std::string key, sf::Vector2f position)
{
	if (characterImages.find(key) != characterImages.end()) {
		characterRect.setTexture(&characterImages[key]);
		characterRect.setSize(sf::Vector2f(characterImages[key].getSize().x, characterImages[key].getSize().y));
		characterRect.setPosition(position);
		window.draw(characterRect);
	}
	else {
		std::cout << key << " image not found." << std::endl;
	}
}
