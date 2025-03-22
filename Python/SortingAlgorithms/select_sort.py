from typing import TypeVar, List

T = TypeVar("T")

def select_sort(arr: List[T]) -> None:
    n = len(arr)
    for i in range(n - 1):
        minEl, minIdx = arr[i], i
        for j in range(i + 1, n):
            if arr[i] > arr[j]:
                minEl, minIdx = arr[j], j
        arr[minIdx],  arr[i] = arr[i], minEl