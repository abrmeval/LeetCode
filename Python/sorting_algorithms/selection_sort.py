def selection_sort(nums):
    """
    Sorts an array using the selection sort algorithm.
    Time complexity is O(n^2).
    """
    n = len(nums)
    for i in range(n - 1):
        min_idx = i
        for j in range(i + 1, n):
            if nums[j] < nums[min_idx]:
                min_idx = j
        nums[i], nums[min_idx] = nums[min_idx], nums[i]
    return nums


print("Sorted Array:", selection_sort([8, 34, 25, 95, 22, 11, 11, 90, 0]))