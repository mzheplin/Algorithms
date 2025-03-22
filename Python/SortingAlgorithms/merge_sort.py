from typing import TypeVar, List

T = TypeVar("T")

def merge_sort(arr: List[T]) -> None:
    merge_sort_recursive(arr, 0, len(arr) - 1)
    

def merge_sort_recursive(arr: List[T], p: int, r: int) -> None:
    if p >= r: return
    q = p + (r - p) // 2
    merge_sort_recursive(arr, p, q)
    merge_sort_recursive(arr, q + 1, r)
    merge(arr, p, q, r)



def merge(arr: List[T], p: int, q: int, r: int) -> None:
    if arr[q] < arr[q+1]: return

    nL = q - p + 1
    nR = r - q

    L = arr[p : p + nL]
    R = arr[q + 1 : q + 1 + nR]

    i, j, k = 0, 0, p

    while i < nL and j < nR:
        if L[i] < R[j]:
            arr[k] = L[i]
            i = i + 1
        else:
            arr[k] = R[j]
            j += 1
        k += 1
       
    while i < nL:
        arr[k] = L[i]
        i += 1
        k += 1

    while j < nR:
        arr[k] =R[j]
        j += 1
        k += 1

