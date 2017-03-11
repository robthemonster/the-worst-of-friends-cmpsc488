
#include "AttributeMap.h"
void AttributeMap::addAttribute(Attributable * target, std::string key, int defaultValue)
{
	this->attributeMap[target][key] = defaultValue;
}
void AttributeMap::setAttribute(Attributable * target, std::string key, int newValue)
{
	this->attributeMap[target][key] = newValue;
}
void AttributeMap::increaseAttribute(Attributable * target, std::string key, int toAdd)
{
	this->attributeMap[target][key] += toAdd;
}
void AttributeMap::deceaseAttribute(Attributable * target, std::string key, int toSub)
{
	this->attributeMap[target][key] -= toSub;
}
int AttributeMap::getAttribute(Attributable * target, std::string key)
{
	return this->attributeMap[target][key];
}
AttributeMap::AttributeMap()
{
}

AttributeMap::~AttributeMap()
{
}

AttributeMap::AttributeMap(const AttributeMap & copy)
{
	this->attributeMap = copy.attributeMap;
}
