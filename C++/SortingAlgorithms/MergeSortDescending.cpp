#include "MergeSortDescending.h"


template<typename T>
void merge_sort_desc(std::vector<T>& arr)
{
	merge_sort_recursive_desc(arr, 0, arr.size() - 1);
}

template<typename T>
void merge_sort_recursive_desc(std::vector<T>& arr, int p, int r)
{
	if (p >= r) return;

	int q = p + (r - p) / 2;

	merge_sort_recursive_desc(arr, p, q);
	merge_sort_recursive_desc(arr, q + 1, r);

	merge_desc(arr, p, q, r);
}

template<typename T>
void merge_desc(std::vector<T>& arr, int p, int q, int r)
{
	if (arr[q] > arr[q + 1]) return;

	int nL = q - p + 1;
	int nR = r - q;

	auto startL = arr.begin() + p;
	auto endL = startL + nL;

	std::vector<T> L(startL, endL);

	auto startR = arr.begin() + q + 1;
	auto endR = startR + nR;

	std::vector<T> R(startR, endR);

	int i = 0, j = 0, k = p;

	while (i < nL && j < nR) {

		if (L[i] > R[j]) {
			arr[k] = L[i];
			i++;
		}
		else {
			arr[k] = R[j];
			j++;
		}
		k++;
	}

	while (i < nL) {
		arr[k] = L[i];
		i++;
		k++;
	}

	while (j < nR) {
		arr[k] = R[j];
		j++;
		k++;
	}
}

template void merge_sort_desc(std::vector<int>&);
template void merge_sort_recursive_desc(std::vector<int>&, int, int);
template void merge_desc(std::vector<int>&, int, int, int);