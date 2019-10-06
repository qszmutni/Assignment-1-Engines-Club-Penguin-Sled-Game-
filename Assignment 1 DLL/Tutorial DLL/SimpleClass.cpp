#include "SimpleClass.h"

int SimpleClass::SimpleFunction() {

	return 1;
}

void SimpleClass::writeFunction(float x, float y, float z) {
	std::ofstream _posFile ("unityPos.txt");
	setPos(x, y, z);

	if (_posFile.is_open()) {

		_posFile << getPos(); 
		_posFile.close();
	}
}   

void SimpleClass::readFunction() {  
	std::string _posLocal;
	std::ifstream _posFile("unityPos.txt");
	if (_posFile.is_open()) {
		
		getline(_posFile, _posLocal, '\n');
		X = std::stof(_posLocal);

		getline(_posFile, _posLocal, '\n');
		Y = std::stof(_posLocal);

		getline(_posFile, _posLocal, '\n');
		Z = std::stof(_posLocal);
		
		_posFile.close();

	}
	else {
	 	std::cout << "DLL ERROR: File Not Found";
	}

}

void SimpleClass::deleteFunction() {
	remove("unityPos.txt");
}

std::string SimpleClass::getPos() {
	return _pos;
}

//void SimpleClass::setPos(std::string unityPos) {
//	_pos = unityPos;
//	
//}


void SimpleClass::setPos(float x, float y, float z) {

	X = x;
	Y = y;
	Z = z;
	std::string _X = std::to_string(x);
	std::string _Y = std::to_string(y);
	std::string _Z = std::to_string(z);
	_pos = std::string(_X + '\n' + _Y + '\n' + _Z + '\n');

}

void SimpleClass::setPos(std::string unityPos) {
	_pos = unityPos;
}

float SimpleClass::getX(){
	return X;
}

float SimpleClass::getY() {
	return Y;
}

float SimpleClass::getZ() {
	return Z;
}