#pragma once
#include "MyStruct.h"
#include <iostream>
#include <string>

namespace Tom {
	static class MyStaticClass
	{
	public:
		
		static void ShowMessage(std::string msg);
	};
}
