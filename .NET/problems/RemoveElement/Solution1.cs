namespace RemoveElement
{
    public class Solution1
    {
        public int RemoveElement(int[] nums, int val)
        {
         var uniqueNums = nums.Where(m => m != val).ToArray();
           Array.Copy(uniqueNums, nums, uniqueNums.Length);
           return uniqueNums.Length;
        }
    }
}
