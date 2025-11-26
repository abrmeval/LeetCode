namespace ConcatenationOfArray
{
    public class Solution3
    {
        public int[] GetConcatenation(int[] nums)
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
    }
}