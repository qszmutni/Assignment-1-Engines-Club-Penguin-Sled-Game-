#include "history.h"


void history::callCommand() {
	setCommandName("history");
}


std::stack<std::vector<float>> history::getStack()
{
	if (getCommandName() == "undo") {
		return cmdHistoryUndo;
	}
	if (getCommandName() == "redo") {
		return cmdHistoryRedo;
	}

	if (getCommandName() == "input") { //Memory problem is here, getCommandName is blank even though I call it in main.cpp
										//And it shows up under Input Class->Command Class->CommandName but doesn't get set anywhere else
										//Eg Command::commandName doesn't have input as what was set.
		return cmdHistoryUndo;
										//Work Around would be to derive input, redo, undo classes and scope Input::getCommandName



											/* Workaround that I think will work (I think it will just cause even more issues though)
											if (Input::getCommandName() == "input") { 
											return cmdHistoryUndo;
											}
											*/
	}

}
