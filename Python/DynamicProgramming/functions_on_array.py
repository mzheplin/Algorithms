from typing import TypeVar, List
T = TypeVar("T")

def sum_of_max_subarray(list: List[T]):
    startIdx, endIdx, currStart = 0, 0, 0
    currSum, maxSum = list[0], list[0]

    for i in range(1,len(list)):
        if list[i] > (list[i] + currSum):
            currStart, currSum = i, list[i]
        else:
            currSum += list[i]

        if maxSum < currSum:
            maxSum, startIdx, endIdx = currSum, currStart, i
        
    res = list[startIdx:endIdx + 1]
    return res, maxSum