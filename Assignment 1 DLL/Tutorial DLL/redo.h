#pragma once
#include "command.h"
#include "history.h"
#include <string>

class redo : public Command, public history
{
public:

	void callCommand();

	std::vector<float> callStackRedo(std::string);
	void popStackRedo(std::string);
	void pushStackRedo(std::vector<float>, std::string);


};

