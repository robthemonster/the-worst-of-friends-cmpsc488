#pragma once
class Navigable;
class AttributeMap;
class Attributable;
class Impact
{
	private:
		AttributeMap * attributeMap;
		Attributable ** target;
		std::string key;
		int op;
		int val;
	public:
		static const int SET = 0, INCREASE = 1, DECREASE = 2;
		void processImpact();
		Impact(AttributeMap * attributeMap, Attributable ** target, std::string key, int op, int val);
		~Impact();
};

