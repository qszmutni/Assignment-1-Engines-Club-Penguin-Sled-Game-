#pragma once
#include "command.h"
#include "history.h"

class input : public Command
{
public:
	void callCommand();

	float getInputVector(int);
	void setInputVector(float, float, float);
	void clearData();

	std::vector <float> returnInput();

private:
	std::vector <float> inputVector;
};
