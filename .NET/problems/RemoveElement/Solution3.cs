namespace RemoveElement
{
    public class Solution3
    {
       public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            //Here uniqueElements is pointing to the same reference as nums
            //Arrays are reference types in C# like objects, Lists etc.
            int[] uniqueElements = nums;
            for(int x = 0; x < nums.Length; x++)
            {
             if(nums[x] != val) 
             {
                uniqueElements[k] = nums[x];
                k++;
             }
            }
            nums = uniqueElements;
            return k;
        }
    }
}