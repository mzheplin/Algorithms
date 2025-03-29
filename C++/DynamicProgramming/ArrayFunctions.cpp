#include "ArrayFunctions.h"


template <typename T>
std::pair<std::vector<T>, T> sumOfMaxSubarray(std::vector<T> arr) {
	int startIdx = 0;
	int endIdx = 0;
	int currStart = 0;
	T maxSum = arr[0];
	T currSum = arr[0];

	for (int i = 1; i < arr.size(); i++) {
		if (arr[i] > (arr[i] + currSum)) {
			currStart = i;
			currSum = arr[i];
		}
		else {
			currSum += arr[i];
		}

		if (maxSum < currSum) {
			maxSum = currSum;
			startIdx = currStart;
			endIdx = i;
		}
	}

	auto start = arr.begin() + startIdx;
	auto end = arr.begin() + endIdx + 1;

	std::vector<T> res(start, end);

	return std::make_pair(res, maxSum);
}

template std::pair<std::vector<int>, int> sumOfMaxSubarray(std::vector<int> arr);