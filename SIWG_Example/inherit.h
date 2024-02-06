#pragma once

#ifndef INHERIT_H
#define INHERIT_H
#include <vector>
#include "MyStruct.h"

#include <stdexcept>

namespace Tom {
	class ParentClass {
	public:
		virtual void ShowSelfName();
		std::vector<int> GetIndices();
		std::vector<MyVector3> GetDataArray();
		void ActivateStdException1() const {
			throw std::exception("cpp std exception");
		}
		void ActivateStdException2() const {
			throw std::out_of_range("cpp argument: index");
		}
		void ActivateStdException3() const {
			throw std::invalid_argument("cpp argument: id");
		}
	protected:
		ParentClass() = default;
		~ParentClass() = default;
		void SetIndices(const std::vector<int>& indices);
		void SetDataArray(const std::vector<MyVector3>& data);

	private:
		std::vector<int> _indices;
		std::vector<MyVector3> _data;
	};


	class Child_A : public ParentClass {
	public:
		Child_A() {
			SetIndices(std::vector<int>{ 2, 4, 6, 8 });
			SetDataArray(std::vector<MyVector3>{ MyVector3(1, 2, 3), MyVector3(4, 5, 6), MyVector3(7, 8, 9), MyVector3(10, 11, 12)});
		}
		void ShowSelfName() override;
	};

	class Child_B : public ParentClass {
	public:
		Child_B() {
			SetIndices(std::vector<int>{ 3,5,7 });
			SetDataArray(std::vector<MyVector3>{ MyVector3(-1, 2, -3), MyVector3(-4, -5, 6), MyVector3(7, -8, -9)});
		}
		void ShowSelfName() override;
	};
}
#endif // !INHERIT_H

