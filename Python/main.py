from DynamicProgramming import functions_on_array

arr = [-1,41, 7, -21, 111,-6,4]
print(arr)

subArr, maxSum = functions_on_array.sum_of_max_subarray(arr)

print(subArr)
print(maxSum)
