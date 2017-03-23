
#include "AttributeMap.h"

#include "Impact.h"


void Impact::processImpact()
{
	switch (this->op) {
	case SET:
		(*attributeMap).setAttribute(*target, key, val);
		break;
	case INCREASE:
		(*attributeMap).increaseAttribute(*target, key, val);
		break;
	case DECREASE:
		(*attributeMap).deceaseAttribute(*target, key, val);
		break;
	}
}

Impact::Impact(AttributeMap * attributeMap, Attributable ** target,std::string key, int op, int val)
{
	this->attributeMap = attributeMap;
	this->target = target;
	this->key = key;
	this->op = op;
	this->val = val;
}

Impact::~Impact()
{
}
