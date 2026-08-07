#:property TargetFramework=net10.0
#:property PublishAot=false

//Time complexity: O(n log n), in the worst case it is O(n^2)
//<summary>
// QuickSort method
// </summary>
/// <param name="s">The first index of the array.</param>
/// <param name="e">The last index of the array.</param>
static int[] QuickSorting(int[] arr, int s, int e)
{
    //Verify the length of the array
    if (e - s + 1 <= 1)
    {
        return arr;
    }

    int pivot = arr[e]; // pivot, last index of the array
    int left = s;       // pointer for left side

    // Partition: elements smaller than pivot on left side
    for (int i = s; i < e; i++)
    {
        if (arr[i] < pivot)
        {
            int tmp = arr[left];
            arr[left] = arr[i];
            arr[i] = tmp;
            left++;
        }
    }

    // Move pivot in-between left & right sides
    arr[e] = arr[left];
    arr[left] = pivot;

    // Quick sort left side
    QuickSorting(arr, s, left - 1);

    // Quick sort right side
    QuickSorting(arr, left + 1, e);

    return arr;
}