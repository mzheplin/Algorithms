#include <iostream>
#include <utility>
#include <vector>
#include "SortingAlgorithms/MergeSortDescending.h"
#include "Divide&Conquer/HIndex.h"
#include "DynamicProgramming/ArrayFunctions.h"

int main()
{
    std::vector<int>  arr = { 2,-7,1,9,4, 8 };

    auto res = sumOfMaxSubarray(arr);

    std::cout << res.second << "\n";
}
