#:property TargetFramework=net10.0
#:property PublishAot=false

//Time complexity: O(n + m) *n time and O(1) space
// Insertion sort is used to merge the two arrays in place
void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int y = 0;

    for (int x = m; x < nums1.Length; x++)
    {
        int z = x - 1;
        nums1[z + 1] = nums2[y];
        while (z >= 0 && nums1[z] > nums1[z + 1])
        {
            int tmp = nums1[z];
            nums1[z] = nums1[z + 1];
            nums1[z + 1] = tmp;
            z--;
        }
        y++;
    }
}
Merge(new int[] { 10, 20, 20, 40, 0, 0 }, m: 4, new int[] { 1, 2 }, n: 2); //Output: [1, 2, 10, 20, 20, 40]