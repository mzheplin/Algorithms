#include "countingSort.h"


std::vector<unsigned int> counting_sort(std::vector<unsigned int> arr)
{
	int max = *std::max_element(arr.begin(), arr.end());

	std::vector<unsigned int> count(max + 1, 0);
	std::vector<unsigned int> output(arr.size());

	for (int num : arr) {
		count[num]++;
	}

	for (int i = 1; i <= max; i++) {
		count[i] += count[i - 1]; 
	}

	for (int j = arr.size() - 1; j >= 0; j--) {
		output[count[arr[j]] - 1] = arr[j];
		count[arr[j]]--;
	}
	return output;
}

