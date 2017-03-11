
#include "Requirements.h"
#include "AttributeMap.h"


Requirements::Requirements(AttributeMap & map)
{
	this->attributeMap = &map;
}


Requirements::~Requirements()
{
}

void Requirements::addRequirement(Attributable ** target, std::string key, int op, int value)
{
	this->requirements.push_back(std::make_tuple(target, key, op, value));
}

bool Requirements::meetsAllRequirements()
{
	Attributable * target;
	std::string key;
	int op, value;
	for (int i = 0; i < this->requirements.size(); i++) {
		target = *std::get<0>(this->requirements.at(i));
		key = std::get<1>(this->requirements.at(i));
		op = std::get<2>(this->requirements.at(i));
		value = std::get<3>(this->requirements.at(i));

	switch (std::get<2>(this->requirements.at(i))) { //operator of req
		case LT:
			if (!((*attributeMap).getAttribute(target, key) < std::get<3>(this->requirements.at(i))))
				return false;
			break;
		case LEQ:
			if (!((*attributeMap).getAttribute(target, key) <= std::get<3>(this->requirements.at(i))))
				return false;
			break;
		case GT:
			if (!((*attributeMap).getAttribute(target, key) > std::get<3>(this->requirements.at(i))))
				return false;
			break;
		case GEQ:
			if (!((*attributeMap).getAttribute(target, key) >= std::get<3>(this->requirements.at(i))))
				return false;
			break;
		case EQ:
			if (!((*attributeMap).getAttribute(target, key) == std::get<3>(this->requirements.at(i))))
				return false;
			break;


		}
	}
	return true;
}
