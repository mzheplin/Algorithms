#ifndef MERGE_SORT_H
#define MERGE_SORT_H

#include <vector>

template <typename T>
void merge_sort(std::vector<T>& arr);

template <typename T>
void merge_sort_recursive(std::vector<T>& arr, int p, int r);

template <typename T>
void merge(std::vector<T>& arr, int p, int q, int r);

#endif
