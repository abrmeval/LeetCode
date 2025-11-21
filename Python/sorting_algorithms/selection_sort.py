## Selection Sort Algorithm Implementation in Python

def selection_sort(arr):
    print("Selection Sort Algorithm Implementation")

    arr_len: int = len(arr)

    for i in range(arr_len):
        min_index:int = i

        for m in range(i + 1, arr_len):
            if arr[min_index] > arr[m]:
              min_index = m

        arr[i], arr[min_index] = arr[min_index], arr[i]
    return arr


print("Sorted Array:", selection_sort([8, 34, 25, 95, 22, 11, 11, 90, 0]))