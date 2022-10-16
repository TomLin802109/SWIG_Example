#include "MyStaticClass.h"


namespace Tom {
	void MyStaticClass::ShowMessage(std::string msg) {
		std::cout << "Message showing from C++:\r\n" << msg << std::endl;
	}
}