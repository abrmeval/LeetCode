#:property TargetFramework=net10.0
#:property PublishAot=false

// Time complexity is O(n^2)
static int[] SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int minIdx = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minIdx])
            {
                minIdx = j;
            }
        }
        // A tuple
        int tmp = arr[i];
        arr[i] =arr[minIdx];
        arr[minIdx]= tmp;
    }
    return arr;
}
Console.WriteLine(string.Join(", ", SelectionSort([3, 2, 4, 2]))); //Output: [2, 2, 3, 4]