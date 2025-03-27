#include <iostream>
#include <vector>
#include "SortingAlgorithms/MergeSortDescending.h"
#include "Divide&Conquer/HIndex.h"

int main()
{
    std::vector<int>  arr = { 2,7,1,9,4, 8 };

    int hIdx = hIndex(arr);

    std::cout << hIdx << "\n";
}
