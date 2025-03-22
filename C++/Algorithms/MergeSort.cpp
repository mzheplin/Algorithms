#include "MergeSort.h"


template<typename T>
void merge_sort(std::vector<T>& arr)
{
	merge_sort_recursive(arr, 0, arr.size() - 1);
}

template<typename T>
void merge_sort_recursive(std::vector<T>& arr, int p, int r)
{
	if (p >= r) return;

	int q = p + (r - p) / 2;

	merge_sort_recursive(arr, p, q);
	merge_sort_recursive(arr, q + 1, r);

	merge(arr, p, q, r);
}

template<typename T>
void merge(std::vector<T>& arr, int p, int q, int r)
{
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

		if (L[i] < R[j]) {
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

template void merge_sort(std::vector<int>&);
template void merge_sort_recursive(std::vector<int>&, int, int);
template void merge(std::vector<int>&, int, int, int);