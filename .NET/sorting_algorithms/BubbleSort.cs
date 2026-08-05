#:property TargetFramework=net10.0
#:property PublishAot=false

// Time complexity is O(n^2)
static int[] BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                // A tuple
                (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
            }
        }
    }
    return arr;
}
Console.WriteLine(string.Join(", ", BubbleSort([3, 2, 4, 2]))); //Output: [2, 2, 3, 4]