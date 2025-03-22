#include "InsertSort.h"

template <typename T>
void insert_sort(std::vector<T>& arr)
{
	int size = arr.size();

	for (int i = 1; i < size; i++) {

		T current = arr[i];
		int j = i - 1;

		while (j >= 0 && arr[j] > current) {

			arr[j + 1] = arr[j];
			j--;
		}

		arr[j + 1] = current;
	}
}


template void insert_sort<int>(std::vector<int>&);