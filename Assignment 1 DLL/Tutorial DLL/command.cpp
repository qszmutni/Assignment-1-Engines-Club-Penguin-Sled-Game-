#include "command.h"


Command::Command()
{

}

Command::~Command()
{
}

std::string Command::getCommandName() {
	return commandName;
}
void Command::setCommandName(std::string _name) {
	commandName = _name;
}



