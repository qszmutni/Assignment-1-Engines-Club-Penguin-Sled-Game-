#include "undo.h"


void undo::callCommand() {

	setCommandName("undo");
}

std::vector<float> undo::callStackUndo(std::string n)
{
	return history::getStack(n).top();
}

void undo::popStackUndo(std::string n)
{
	getStack(n).pop();
}

void undo::pushStackUndo(std::vector<float> i, std::string n)
{
	getStack(n).push(i);
}
