#pragma once
#include "SimpleClass.h"
#include <vector>
class Command
{
public:
	Command();
	~Command();

	virtual void callCommand() = 0;
	std::string getCommandName();
	void setCommandName(std::string);
private:
	std::string commandName;

};

