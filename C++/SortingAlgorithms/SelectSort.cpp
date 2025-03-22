#include "SelectSort.h"

template<typename T>
void select_sort(std::vector<T>& arr)
{
	int size = arr.size();

	for (int i = 0; i < size - 1; i++) {

		T min = arr[i];
		int minIdx = i;

		for (int j = i + 1; j < size; j++) {

			if (arr[j] < min) {
				min = arr[j];
				minIdx = j;
			}
		}

		if (minIdx == i) continue;
		
		arr[minIdx] = arr[i];
		arr[i] = min;
	}
}

template void select_sort(std::vector<int>&);