#pragma once

#include "PluginSettings.h"
//http://www.cplusplus.com/doc/tutorial/files/

//This is the only resource I used when creating my code base.
class SimpleClass {
public:
	int SimpleFunction();
	void writeFunction(float x, float y, float z);
	void readFunction();
	void deleteFunction();
	
	std::string getPos();
	float getX();
	float getY();
	float getZ();
	void setPos(float x, float y, float z);
	void setPos(std::string unityPos);

private:
	std::string _pos;
	float X, Y, Z;
};
