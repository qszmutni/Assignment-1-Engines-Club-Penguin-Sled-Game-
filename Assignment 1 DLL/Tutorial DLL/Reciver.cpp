#include "Reciver.h"

void Reciver::excuteCommand()
{
	if (Command::getCommandName() == "input") {
		undo::pushStackUndo(input::returnInput());
		input::clearData();
	}

	if (Command::getCommandName() == "redo") {
		history::getStack();
		undo::pushStackUndo(redo::callStackRedo());
		redo::popStackRedo();
		input::setInputVector(redo::callStackRedo()[0], redo::callStackRedo()[1], redo::callStackRedo()[2]);
	}

	if (Command::getCommandName() == "undo") {
		history::getStack();
		redo::pushStackRedo(undo::callStackUndo());
		undo::popStackUndo();
		input::setInputVector(undo::callStackUndo()[0], undo::callStackUndo()[1], undo::callStackUndo()[2]);
	}

	if (history::getCommandName() == "history") {
		
	}

	
}

void Reciver::callInput()
{
	input::callCommand();
}

void Reciver::callUndo()
{
	undo::callCommand();
}

void Reciver::callRedo()
{
	redo::callCommand();
}

void Reciver::callHistory()
{
	history::callCommand();
}
