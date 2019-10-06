#pragma once
#include "command.h"
#include <stack>
#include <vector>


class history : public Command
{
public:
	void callCommand();

	std::stack <std::vector<float>> getStack();

private:
	std::stack <std::vector<float>> cmdHistoryUndo;
	std::stack <std::vector<float>> cmdHistoryRedo;
};
