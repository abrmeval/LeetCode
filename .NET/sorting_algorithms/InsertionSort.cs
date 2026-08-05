#:property TargetFramework=net10.0
#:property PublishAot=false

// Time Complexity: O(n^2)
// Space Complexity: O(1) 
// Sorts in ascending order
static int[] InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int j = i - 1;
        while (j >= 0 && arr[j + 1] < arr[j])
        {
            int tmp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = tmp;
            j--;
        }
    }
    return arr;
}