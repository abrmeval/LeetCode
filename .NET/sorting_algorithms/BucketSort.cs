
//Time complexity: O(n)
// We use it in specific scenarios, not all cases apply
//Use cases: 
// - Uniformly distributed data over a known range 
// - You know the range of values in advance
// - Large volumes of data that can be distributed roughly evenly
static int[] Sort(int[] arr)
{

    // Assuming arr only contains 0, 1 or 2
    int[] counts = { 0, 0, 0 };

    // Count the quantity of each val in arr
    foreach (int num in arr)
    {
        counts[num] += 1;
    }

    // Fill each bucket in the original array
    int i = 0;
    for (int n = 0; n < counts.Length; n++)
    {
        for (int j = 0; j < counts[n]; j++)
        {
            arr[i] = n;
            i++;
        }
    }
    return arr;
}
