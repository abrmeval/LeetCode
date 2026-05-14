#:property TargetFramework=net10.0
#:property PublishAot=false

int RemoveDuplicates(int[] nums)
{
    int[] uniqueElements = new int[nums.Length];
    int k = 0;

    for (int x = 0; x < nums.Length; x++)
    {
        if (k == 0)
        {
            uniqueElements[k] = nums[x];
            k++;
            continue;
        }

        if (nums[x] != uniqueElements[k - 1])
        {
            uniqueElements[k] = nums[x];
            k++;
        }
        Array.Copy(uniqueElements.Take(k).ToArray(), nums, k);
    }
    return k;
}

int RemoveDuplicates2(int[] nums)
{
    int[] uniqueElements = nums;
    int k = 0;

    for (int x = 0; x < nums.Length; x++)
    {
        if (k == 0)
        {
            uniqueElements[k] = nums[x];
            k++;
            continue;
        }

        if (nums[x] != uniqueElements[k - 1])
        {
            uniqueElements[k] = nums[x];
            k++;
        }
    }
    nums = uniqueElements;
    return k;
}

//Output: [1, 2] and k = 2
Console.WriteLine(RemoveDuplicates([ 1, 1, 2 ]));
Console.WriteLine(RemoveDuplicates2([ 1, 1, 2 ]));