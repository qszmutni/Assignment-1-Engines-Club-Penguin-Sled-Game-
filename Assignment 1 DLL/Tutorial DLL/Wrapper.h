#pragma once

#include "PluginSettings.h"
#include "Reciver.h"

#ifdef __cplusplus
extern "C"
{
#endif

	//Call functions here
	PLUGIN_API void InputDLL(float, float, float);
	PLUGIN_API void Undo();
	PLUGIN_API void Redo();
	PLUGIN_API float X();
	PLUGIN_API float Y();
	PLUGIN_API float Z();



#ifdef __cplusplus 
}
#endif
