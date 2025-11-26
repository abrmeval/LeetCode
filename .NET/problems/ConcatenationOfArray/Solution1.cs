namespace ConcatenationOfArray
{
    public class Solution1
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = nums.Concat(nums).ToArray();
            return ans;
        }
    }
}