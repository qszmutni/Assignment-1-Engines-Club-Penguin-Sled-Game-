#pragma once
#include "command.h"
#include "history.h"
class undo : public Command, public history
{
public:

	void callCommand();

	std::vector<float> callStackUndo();
	void popStackUndo();
	void pushStackUndo(std::vector<float>);


};

