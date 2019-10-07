#include "Reciver.h"

void Reciver::excuteCommand()
{
	if (Command::getCommandName() == "input") {
		undo::pushStackUndo(input::returnInput(), Command::getCommandName());
		input::clearData();
		
	}

	if (Command::getCommandName() == "redo") {
		//history::getStack(Command::getCommandName());
		undo::pushStackUndo(redo::callStackRedo(Command::getCommandName()), Command::getCommandName());
		redo::popStackRedo(Command::getCommandName());
		input::setInputVector(redo::callStackRedo(Command::getCommandName())[0], 
		redo::callStackRedo(Command::getCommandName())[1], redo::callStackRedo(Command::getCommandName())[2]);
	}

	if (Command::getCommandName() == "undo") {
		//history::getStack(Command::getCommandName());
		redo::pushStackRedo(undo::callStackUndo(Command::getCommandName()), Command::getCommandName());
		undo::popStackUndo(Command::getCommandName());
		input::setInputVector(undo::callStackUndo(Command::getCommandName())[0],
		undo::callStackUndo(Command::getCommandName())[1], undo::callStackUndo(Command::getCommandName())[2]);
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
