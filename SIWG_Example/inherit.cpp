#include "inherit.h"
#include <iostream>

namespace Tom {
	void ParentClass::ShowSelfName() {
		std::cout << "This is Parent class" << std::endl;
	}

	std::vector<int> ParentClass::GetIndices() {
		return _indices;
	}

	std::vector<MyVector3> ParentClass::GetDataArray() {
		std::vector<MyVector3> vec(_data.size());
		for (auto i = 0; i < _data.size(); i++) {
			vec[i] = _data[i];
		}
		return vec;
	}

	void ParentClass::SetIndices(const std::vector<int>& indices) {
		_indices = indices;
	}
	void ParentClass::SetDataArray(const std::vector<MyVector3>& data) {
		_data = data;
	}

	void Child_A::ShowSelfName() {
		std::cout << "This is Child A class" << std::endl;
	}

	void Child_B::ShowSelfName() {
		std::cout << "This is Child B class" << std::endl;
	}
}