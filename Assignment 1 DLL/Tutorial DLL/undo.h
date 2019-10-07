#pragma once
#include "command.h"
#include "history.h"
#include <string>
class undo : public Command, public history
{
public:

	void callCommand();

	std::vector<float> callStackUndo(std::string);
	void popStackUndo(std::string);
	void pushStackUndo(std::vector<float>, std::string);


};

