#include "ImageDisplay.h"


ImageDisplay::ImageDisplay(sf::Texture* texture) {
	
	img.setTexture(*texture);
	//img..setSize(sf::Vector2f((float)(*texture).getSize().x, (float)(*texture).getSize().y)); 
	img.setOrigin(img.getTextureRect().width/ 2, img.getTextureRect().height / 2);

}


ImageDisplay::ImageDisplay()
{
}


ImageDisplay::~ImageDisplay()
{
}

sf::Sprite ImageDisplay::get() {
	return img;
}

void ImageDisplay::setPosition(float x, float y) {
	img.setPosition(x, y);
	
}

void ImageDisplay::setTexture(sf::Texture * texture) {
	img.setTexture(*texture, true);
	//img..setSize(sf::Vector2f((float)(*texture).getSize().x, (float)(*texture).getSize().y)); 
	img.setOrigin(img.getTextureRect().width / 2, img.getTextureRect().height / 2);
}