#include "HIndex.h"
#include "../SortingAlgorithms/MergeSortDescending.h"

int hIndex(std::vector<int> list)
{
	merge_sort_desc(list);

	int left = 0, right = list.size() - 1;

	return hIndex_recursive(list, left, right);
}

int hIndex_recursive(std::vector<int> list, int left, int right)
{
	if (left >= right) return right + 1;

	int middle = left + (right - left) / 2 + 1;

	if (middle + 1 == list[middle]) {
		return middle + 1;
	}
	else if (middle + 1 < list[middle]) {
		return hIndex_recursive(list, middle, right);
	}
	else {
		return hIndex_recursive(list, left, middle - 1);
	}
}