#:property TargetFramework=net10.0
#:property PublishAot=false

// Time Complexity: O(n log n) in all cases
// Space: O(1)
static int[] MergeSorting(int[] arr, int left, int right)
{
    // array, starting index of array, last index of array
    if (left < right)
    {
        // Find the middle point of arr
        int middle = (left + right) / 2;
        MergeSorting(arr, left, middle);   // sort left half
        MergeSorting(arr, middle + 1, right); // sort right half
        Merge(arr, left, middle, right);    // merge sorted halfs
    }
    return arr;
}

// Merges two subarrays of arr[].
// First subarray is arr[left..middle]
// Second subarray is arr[middle+1..right]
static void Merge(int[] arr, int left, int middle, int right)
{

    // Find lengths of two subarrays to be merged
    int leftLength = middle - left + 1;
    int rightLength = right - middle;

    // Create temp arrays 
    var tempLeft = new int[leftLength];
    var tempRight = new int[rightLength];

    // Copy the sorted left & right halfs to temp arrays
    for (int a = 0; a < leftLength; a++)
    {
        tempLeft[a] = arr[left + a];
    }

    for (int b = 0; b < rightLength; b++)
    {
        tempRight[b] = arr[middle + 1 + b];
    }

    // initial indexes of left and right sub-arrays
    int i = 0; // index for left
    int j = 0; // index for right
    int k = left; // Initial index of merged subarray array

    // Merge the two sorted halfs into the original array
    while (i < leftLength && j < rightLength)
    {
        if (tempLeft[i] <= tempRight[j])
        {
            arr[k] = tempLeft[i];
            i++;
        }
        else
        {
            arr[k] = tempRight[j];
            j++;
        }
        k++;
    }
    // One of the halfs will have elements remaining

    // Copy remaining elements of L[] if any 
    while (i < leftLength)
    {
        arr[k] = tempLeft[i];
        i++;
        k++;
    }

    // Copy remaining elements of R[] if any 
    while (j < rightLength)
    {
        arr[k] = tempRight[j];
        j++;
        k++;
    }
}

Console.WriteLine(string.Join(", ", MergeSorting([3, 2, 4, 2], 0, 3))); //Output: [2, 2, 3, 4]