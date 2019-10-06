#include "redo.h"

void redo::callCommand() {
	Command::setCommandName("redo");
}

std::vector<float> redo::callStackRedo()
{
	return getStack().top();
}

void redo::popStackRedo()
{
	getStack().pop();
}

void redo::pushStackRedo(std::vector<float> i)
{
	getStack().push(i);
}