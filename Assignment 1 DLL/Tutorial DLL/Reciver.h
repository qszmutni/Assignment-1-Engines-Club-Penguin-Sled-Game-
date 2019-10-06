#pragma once
#include "input.h"
#include "redo.h"
#include "undo.h"

#include "PluginSettings.h"
//#include "history.h"
class PLUGIN_API Reciver : public input, public undo, public redo
{
public:
	void excuteCommand();

	void callInput();
	void callUndo();
	void callRedo();
	void callHistory();

private:

};