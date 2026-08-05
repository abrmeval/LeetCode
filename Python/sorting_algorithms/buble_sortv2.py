def bubble_sort(nums):
    """
    Sorts an array using the bubble sort algorithm.
    Time complexity is O(n^2).
    We swap elements based on a condition, if greater than or less than.
    """
    n = len(nums)
    for i in range(n - 1):
        for j in range(n - i - 1):
            if nums[j] > nums[j + 1]:
                nums[j], nums[j + 1] = nums[j + 1], nums[j]
    return nums

print("Sorted Array:", bubble_sort([8, 34, 25, 95, 22, 11, 11, 90, 0]))