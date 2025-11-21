namespace RemoveDuplicatesFromSortedArray;
public class Solution1 {

    public int RemoveDuplicates(int[] nums) {
        int[] uniqueElements = new int[nums.Length];
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
          Array.Copy(uniqueElements.Take(k).ToArray(), nums, k);
        }
        return k;
    }
}