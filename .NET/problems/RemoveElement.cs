#:property TargetFramework=net10.0
#:property PublishAot=false

int RemoveElement1(int[] nums, int val)
{
    var uniqueNums = nums.Where(m => m != val).ToArray();
    Array.Copy(uniqueNums, nums, uniqueNums.Length);
    return uniqueNums.Length;
}

/// <summary>
/// This is a wrong approach as nums is a reference type.
/// Original array will not be modified outside this method.
/// I will point nums to a new array but the original array reference will remain unchanged.
/// </summary>
/// <param name="nums"></param>
/// <param name="val"></param>
/// <returns></returns>
int RemoveElement2(int[] nums, int val)
{
    //Wrong approach as nums is a reference type
    //Original array will not be modified outside this method
    //I will point nums to a new array but the original array reference will remain unchanged
    nums = nums.Where(m => m != val).ToArray();
    return nums.Length;
}

/// <summary>
/// This is a correct approach as I am modifying the original array by using the same reference
/// I am not creating a new array and pointing nums to it. I am using the same reference and modifying the original array.
/// </summary>
int[] RemoveElement3(int[] nums, int val)
{
    int k = 0;
    //Here uniqueElements is pointing to the same reference as nums
    //Arrays are reference types in C# like objects, Lists etc.
    int[] uniqueElements = new int[nums.Length];
    for (int x = 0; x < nums.Length; x++)
    {
        if (nums[x] != val)
        {
            uniqueElements[k] = nums[x];
            k++;
        }
    }
    nums = uniqueElements;
    return nums;
}

Console.WriteLine(RemoveElement1(new int[] { 3, 2, 2, 3 }, 3)); //Output: 2
Console.WriteLine(RemoveElement2(new int[] { 3, 2, 2, 3 }, 3)); //Output: 2 but original array will not be modified
Console.WriteLine(string.Join(", ", RemoveElement3(new int[] { 3, 2, 2, 3 }, 3))); //Output: 2 and original array will be modified to [2, 2, 2, 3] or [2, 2, 3, 3] depending on the order of elements in the original array.