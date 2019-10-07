#pragma once
#include "command.h"
#include <stack>
#include <vector>
#include <string>

class history
{
public:
	

	std::stack <std::vector<float>> getStack(std::string);

private:
	std::stack <std::vector<float>> cmdHistoryUndo;
	std::stack <std::vector<float>> cmdHistoryRedo;
};
