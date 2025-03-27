#ifndef MERGE_SORT_DESC_H
#define MERGE_SORT_DESC_H

#include <vector>

template <typename T>
void merge_sort_desc(std::vector<T>& arr);

template <typename T>
void merge_sort_recursive_desc(std::vector<T>& arr, int p, int r);

template <typename T>
void merge_desc(std::vector<T>& arr, int p, int q, int r);

#endif
