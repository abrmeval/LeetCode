#:property TargetFramework=net10.0
#:property PublishAot=false

// Time complexity: O(n + m) * n
// Space complexity: O(1)
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

//Time complexity: O(n + m)
// Space complexity: O(n + m) 
// Merge sort algorithm
static void Merge2(int[] nums1, int m, int[] nums2, int n)
{
    int i = 0, j = 0, k = 0, u = 0;
    int[] tmpArr = new int[m + n];

    // Compare front elements of each half, take the smaller one
    while (i < m && j < n)
    {
        if (nums1[i] >= nums2[j])
        {
            tmpArr[k++] = nums2[j++];
        }
        else
            tmpArr[k++] = nums1[i++];
    }

    while (i < m)
        tmpArr[k++] = nums1[i++];

    while (j < n)
        tmpArr[k++] = nums2[j++];

    for (int x = 0; x < tmpArr.Length; x++)
    {
        nums1[x] = tmpArr[x];
    }
}

//Time complexity: O(n * m)
// Space complexity: O(1)
void Merge3(int[] nums1, int m, int[] nums2, int n)
{
    //  i => index of last VALID element in nums1
    //  j => index of current element in nums2
    //  k => count of current element in nums1
    //  last => index of last element in nums1 (Not actually the last , but indicates the position next to the last valid element in nums1)
    int i = m - 1, j = 0, k = 1, last = m;

    while (j < n)
    {
        if (i >= 0 && nums2[j] < nums1[i])
        {
            nums1[last--] = nums1[i];
            nums1[i--] = nums2[j];
            k++;
        }
        else
        {
            if (k == 1)
                nums1[last] = nums2[j];

            j++;
            i = m + j - 1;
            last = m + j;
            k = 1;
        }
    }
}

// ***Better aproach***
// Time complexity: O(n + m)
// Space complexity: O(1)
void Merge4(int[] nums1, int m, int[] nums2, int n)
{
    int last = m + n - 1;
    int i = m - 1, j = n - 1;

    while (j >= 0)
    {
        if (i >= 0 && nums1[i] > nums2[j])
        {
            nums1[last--] = nums1[i--];
        }
        else
        {
            nums1[last--] = nums2[j--];
        }
    }
}


int[] nums1 = new int[] { 10, 20, 30, 40, 0, 0 };
int[] nums2 = new int[] { 1, 2 };
Merge3(nums1, m: 4, nums2, n: 2); //Output: [1, 2, 10, 20, 20, 40]
Console.WriteLine(string.Join(", ", nums1)); //Output: [1, 2, 10, 20, 20, 40]

// int[] nums1 = new int[] { 0,0};
// int[] nums2 = new int[] { 1, 2 };
// Merge3(nums1, m: 0, nums2, n: 2); //Output: [1, 2]

// int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
// int[] nums2 = new int[] { 2, 5, 6 };
// Merge3(nums1, m: 3, nums2, n: 3); //Output: [1, 2, 2, 3, 5, 6]