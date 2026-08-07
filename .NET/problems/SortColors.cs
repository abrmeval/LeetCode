// Time complexity: O(n)
// Space complexity: O(1)
// Solved by using BucketSort
void SortColors(int[] nums)
{
    int[] counts = { 0, 0, 0 };

    foreach (int num in nums)
    {
        counts[num] += 1;
    }

    int i = 0;
    for (int n = 0; n < counts.Length; n++)
    {
        for (int j = 0; j < counts[n]; j++)
        {
            nums[i] = n;
            i++;
        }
    }
}