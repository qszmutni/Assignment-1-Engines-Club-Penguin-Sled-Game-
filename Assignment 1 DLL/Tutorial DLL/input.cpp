#include "input.h"

void input::callCommand() {
	setCommandName("input");
}


float input::getInputVector(int i)
{
	return inputVector[i];
}

void input::setInputVector(float x, float y, float z)
{
	inputVector.push_back(x);
	inputVector.push_back(y);
	inputVector.push_back(z);
}

void input::clearData()
{
	inputVector.clear();
}

std::vector<float> input::returnInput()
{
	return inputVector;
}
