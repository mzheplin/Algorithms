from typing import List

def find_h_index(list: List[int]) -> int:
    list.sort(reverse = True)
    left, right = 0, len(list) - 1
    return find_h_index_rec(list, left, right)



def find_h_index_rec(list: List[int], left: int, right: int) -> int:
    if left >= right: return right + 1

    middle = left + (right - left)//2 + 1

    if middle + 1 == list[middle]:
        return middle + 1
    elif middle + 1 < list[middle]:
        return find_h_index_rec(list, middle, right)
    else:
        return find_h_index_rec(list, left, middle - 1)