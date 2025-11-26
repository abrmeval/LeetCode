namespace ConcatenationOfArray
{
    public class Solution2
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];

            for (int x = 0; x < ans.Length; x++)
            {
                ans[x] = nums[x % nums.Length];
            }
            return ans;
        }
    }
}