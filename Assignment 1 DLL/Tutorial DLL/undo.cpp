#include "undo.h"


void undo::callCommand() {

	Command::setCommandName("undo");
}

std::vector<float> undo::callStackUndo()
{
	return getStack().top();
}

void undo::popStackUndo()
{
	getStack().pop();
}

void undo::pushStackUndo(std::vector<float> i)
{
	getStack().push(i);
}
