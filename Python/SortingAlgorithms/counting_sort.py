def counting_sort(arr):
    if not arr:
        return []

    max_val = max(arr)

    count = [0] * (max_val + 1)

    for n in arr:
        count[n]+=1

    for i in range(1, len(count)):
        count[i]+= count[i-1]

    output = [0]*len(arr)

    for num in reversed(arr):
        output[count[num] - 1] =num
        count[num] -=1

    return output







