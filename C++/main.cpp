#include <iostream>
#include <vector>
#include "SortingAlgorithms/SelectSort.h"

int main()
{
    std::vector<int>  arr = { 2,7,-1,9, -8 };

    select_sort(arr);

    for (int i = 0; i < 5; i++) {
        std::cout << arr[i] << "\n";
    }

}
