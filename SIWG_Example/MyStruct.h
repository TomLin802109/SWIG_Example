#pragma once
#include <string>

namespace Tom {
	struct MyVector3 {
	public:
		double X = NAN;
		double Y= NAN;
		double Z= NAN;
		MyVector3() {}
		MyVector3(double x, double y, double z) {
			this->X = x; this->Y = y; this->Z = z;
		}

	};

	struct MyData {
	private:
		double value;
	public:
		std::string str;
		short int16;
		int int32;
		float singal;
		MyData() {}
		MyData(double a, std::string b, short c, int d, float e) 
		{
			value = a;
			str = b;
			int16 = c;
			int32 = d;
			singal = e;
		}
	};

	struct MyCoordinate {
	public:
		std::string CoordinateString;
		MyVector3 X;
		MyVector3 Y;
		MyVector3 Z;
		MyCoordinate() {}
		MyCoordinate(MyVector3 a, MyVector3 b, MyVector3 c) {
			this->X = a; this->Y = b; this->Z = c;
			this->CoordinateString = std::to_string(a.X) + "," + std::to_string(a.Y) + "," + std::to_string(a.Z);
		}
	};
}