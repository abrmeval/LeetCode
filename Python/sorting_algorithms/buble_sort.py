
def bubble_sort(arr):
    """
    Sorts an array using the bubble sort algorithm.
    
    The algorithm repeatedly steps through the list, compares adjacent elements,
    and swaps them if they're in the wrong order. This process continues until
    no more swaps are needed, indicating the list is sorted.
    
    Time Complexity: O(n²) in worst and average case, O(n) in best case
    Space Complexity: O(1) - sorts in place
    
    Args:
        arr: List of comparable elements to sort
    
    Returns:
        The sorted list (modifies in place, but also returns for convenience)
    """
    n = len(arr)
    
    # We need at most n-1 passes to sort n elements
    for i in range(n):
        # Flag to detect if any swap happened in this pass
        swapped = False
        
        # In each pass, the largest unsorted element bubbles to the end
        # So we can reduce the range we check by i each time
        for j in range(0, n - i - 1):
            # Compare adjacent elements
            if arr[j] > arr[j + 1]:
                # Swap if they're in the wrong order
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
                swapped = True
        
        # Optimization: if no swaps occurred, the array is already sorted
        if not swapped:
            break
    
    return arr


print("Bubble Sort Algorithm Implementation")
sorted_array = bubble_sort([64, 34, 25, 12, 22, 11, 90])
print("Sorted Array:", sorted_array)