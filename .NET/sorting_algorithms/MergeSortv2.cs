#:property TargetFramework=net10.0
#:property PublishAot=false

// Time complexity: O(n log n)
// Space O(n log n) total allocations across all calls
static void Sort(int[] array)
{
    if (array.Length <= 1)
        return; // base case: already "sorted"

    int mid = array.Length / 2;
    int[] left = array[0..mid];
    int[] right = array[mid..array.Length];

    // Divide: recurse on each half
    Sort(left);
    Sort(right);

    // Conquer: merge the sorted halves back into array
    Merge(array, left, right);
}

static void Merge(int[] array, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    // Compare front elements of each half, take the smaller one
    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
            array[k++] = left[i++];
        else
            array[k++] = right[j++];
    }

    // Copy any leftovers (one side will already be exhausted)
    while (i < left.Length)
        array[k++] = left[i++];

    while (j < right.Length)
        array[k++] = right[j++];
}

int[] arr =  [6, 3, 8, 5 ];
Sort(arr);
Console.WriteLine(string.Join(", ", arr)); // 3, 5, 6, 8