
#:property TargetFramework=net10.0
#:property PublishAot=false
using System.Linq;
using System.Collections.Generic;


// Solution 1 with LINQ
int[] GetConcatenation(int[] nums)
{
    int[] ans = nums.Concat(nums).ToArray();
    return ans;
}

// Solution 2 without LINQ
int[] GetConcatenation2(int[] nums)
{
    int[] ans = new int[nums.Length * 2];

    for (int x = 0; x < ans.Length; x++)
    {
        ans[x] = nums[x % nums.Length];
    }
    return ans;
}

// Solution 3 without LINQ and with less iterations
int[] GetConcatenation3(int[] nums)
{
    int n = nums.Length;
    int[] ans = new int[2 * n];
    for (int i = 0; i < n; i++)
    {
        //Assigning both the first half and second half values in one go
        ans[i] = ans[i + n] = nums[i];
    }
    return ans;
}
Console.WriteLine(string.Join(", ", GetConcatenation(new int[] { 1, 2, 3 })));
Console.WriteLine(string.Join(", ", GetConcatenation2(new int[] { 1, 2, 3 })));
Console.WriteLine(string.Join(", ", GetConcatenation3(new int[] { 1, 2, 3 })));