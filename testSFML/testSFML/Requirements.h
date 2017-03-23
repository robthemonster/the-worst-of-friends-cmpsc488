#pragma once
#include <string>
#include <tuple>
#include <vector>
class Attributable;
class AttributeMap;
class Requirements
{
private:
	std::vector < std::tuple<Attributable ** ,std::string, int, int> > requirements;
	AttributeMap * attributeMap;
public:
	static const int LT = 0, LEQ = 1, GT = 2, GEQ = 3, EQ = 4;
	
	Requirements(AttributeMap &);
	~Requirements();
	void addRequirement(Attributable ** target, std::string key, int op, int value);
	bool meetsAllRequirements();
};

