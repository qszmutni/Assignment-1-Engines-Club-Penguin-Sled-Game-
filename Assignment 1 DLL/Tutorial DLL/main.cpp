#include "Reciver.h"

void main() {
	Reciver reciverCall;

	reciverCall.setInputVector(1.0f, 1.0f, 1.0f);
	reciverCall.callInput();
	reciverCall.excuteCommand();

	reciverCall.setInputVector(2.0f, 2.0f, 2.0f);
	reciverCall.callInput();
	reciverCall.excuteCommand();

	reciverCall.callUndo();
	reciverCall.excuteCommand();


}