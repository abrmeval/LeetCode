namespace RemoveDuplicatesFromSortedArray;
public class Solution2 {

    public int RemoveDuplicates(int[] nums) {
        int[] uniqueElements = nums;
        int k = 0;

        for (int x = 0;  x < nums.Length; x++)
        {
            if(k == 0)
            {  uniqueElements[k] = nums[x];
                 k++;
                 continue;
            }

          if(nums[x] != uniqueElements[k - 1]) 
          {  uniqueElements[k] = nums[x];
             k++;
          }
        }
        nums = uniqueElements;
        return k;
    }
}