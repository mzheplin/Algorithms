#include <iostream>
#include <utility>
#include <vector>
#include "SortingAlgorithms/CountingSort.h"


int main()
{
    std::vector<unsigned int>  arr = { 2,0,1,4,4, 2 };

    auto res = counting_sort(arr);

    for (int num : res) {

        std::cout << num << "\n";
    }
}
