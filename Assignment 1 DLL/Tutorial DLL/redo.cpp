#include "redo.h"

void redo::callCommand() {
	setCommandName("redo");
}

std::vector<float> redo::callStackRedo(std::string n)
{
	return getStack(n).top();
}

void redo::popStackRedo(std::string n)
{
	getStack(n).pop();
}

void redo::pushStackRedo(std::vector<float> i, std::string  n)
{
	getStack(n).push(i);
}