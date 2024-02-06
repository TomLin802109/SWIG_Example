#pragma once

#include "MyStruct.h"
#include <vector>
#include <iostream>

namespace Tom {
	class MyCppClass
	{
	public:
		MyCppClass() {}
		~MyCppClass() {}
		double Add(double a, double b) {
			return PrivateAdd(a, b);
		}
		MyVector3 CreateVector3();
		MyVector3 Cross(MyVector3 a, MyVector3 b) {
			return MyVector3(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
		}
		MyVector3 Add(MyVector3 a, MyVector3 b);
		std::vector<MyVector3> GetMyCollection();
		std::vector<MyVector3> ShiftMyCollection(std::vector<MyVector3> ary);
		void ExpandMyCollection(std::vector<MyVector3>& ary) {
			
			ary.insert(ary.begin(), ary[ary.size() - 1]);
			ary.push_back(ary[0]);
		}

	private:
		double PrivateAdd(double a, double b);
		MyVector3 PrivateAdd(MyVector3 a, MyVector3 b);
	};
}


