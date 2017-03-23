#pragma once
#include <string>
#include <map>
class Attributable;
class AttributeMap
{
private:
	std::map <Attributable *, std::map <std::string, int > > attributeMap;
public:
	void addAttribute(Attributable *, std::string key, int defaultValue = 0);
	void setAttribute(Attributable *, std::string key, int newValue);
	void increaseAttribute(Attributable *, std::string key, int toAdd);
	void deceaseAttribute(Attributable *, std::string key, int toSub);
	int getAttribute(Attributable * target, std::string key);
	AttributeMap();
	~AttributeMap();
	AttributeMap(const AttributeMap&);

};

