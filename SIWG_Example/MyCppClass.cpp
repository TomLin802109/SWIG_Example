#include "pch.h"
#include "MyCppClass.h"

using namespace std;

namespace Tom {

	double MyCppClass::PrivateAdd(double a, double b) {
		return a + b;
	}

	MyVector3 MyCppClass::CreateVector3() {
		MyVector3 ans(1.12, 2.23, 3.34);
		return ans;
	}

	MyVector3 MyCppClass::Add(MyVector3 a, MyVector3 b) {
		return PrivateAdd(a, b);
	}

	MyVector3 MyCppClass::PrivateAdd(MyVector3 a, MyVector3 b) {
		return MyVector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
	}

	std::vector<MyVector3> MyCppClass::GetMyCollection() {
		auto collection = std::vector<MyVector3>(5);
		for (int i = 0; i < 5; i++)
		{
			collection[i] = MyVector3(i, i + 0.1f, i + 0.2f);
			std::cout << "From Cpp: " << i << " " << collection[i].X << collection[i].Y << collection[i].Z << std::endl;
		}
		return collection;
	}

	std::vector<MyVector3> MyCppClass::ShiftMyCollection(std::vector<MyVector3> ary) {
		for (int i = 0; i < ary.size()-1; i++)
		{
			ary[i] = PrivateAdd(ary[i], ary[i + 1]);
		}
		ary.push_back(PrivateAdd(ary[0], ary[ary.size() - 1]));
		return ary;
	}


}
	