namespace RemoveElement
{
    [Obsolete("This is a wrong approach as nums is a reference type. Original array will not be modified outside this method.")]
    public class Solution2
    {
        /// <summary>
        /// This is a wrong approach as nums is a reference type.
        /// Original array will not be modified outside this method.
        /// I will point nums to a new array but the original array reference will remain unchanged.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            //Wrong approach as nums is a reference type
            //Original array will not be modified outside this method
            //I will point nums to a new array but the original array reference will remain unchanged
            nums = nums.Where(m => m != val).ToArray();
            return nums.Length;
        }
    }
}
