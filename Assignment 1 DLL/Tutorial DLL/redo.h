#pragma once
#include "command.h"
#include "history.h"

class redo : public Command, public history
{
public:

	void callCommand();

	std::vector<float> callStackRedo();
	void popStackRedo();
	void pushStackRedo(std::vector<float>);


};

