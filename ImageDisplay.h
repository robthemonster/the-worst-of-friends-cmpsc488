#pragma once
#include <SFML\Graphics.hpp>
class ImageDisplay
{
private:
	sf::Sprite img;
public:
	ImageDisplay(sf::Texture* texture);
	ImageDisplay();
	~ImageDisplay();
	sf::Sprite get();
	void setPosition(float x, float y);
	void setTexture(sf::Texture * texture);
};

