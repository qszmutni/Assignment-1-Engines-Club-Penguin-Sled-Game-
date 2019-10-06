#include "Wrapper.h"

Reciver reciverCall;

void InputDLL(float x, float y, float z) {
	reciverCall.setInputVector(x, y, z);
	reciverCall.callInput();
	reciverCall.excuteCommand();
}

void Undo()
{
	reciverCall.callUndo();
	reciverCall.excuteCommand();
}

void Redo() {
	reciverCall.callRedo();
	reciverCall.excuteCommand();
}

void History() {
	reciverCall.callHistory();
	reciverCall.excuteCommand();
}

float X() {
	return reciverCall.getInputVector(0);
}

float Y() {
	return reciverCall.getInputVector(1);
}


float Z() {
	return reciverCall.getInputVector(2);
}
