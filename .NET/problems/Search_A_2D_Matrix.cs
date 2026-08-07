#:property TargetFramework=net10.0
#:property PublishAot=false

// Time complexity: O(log(m * n))
// Space complexity: O(1)
// Solved by using Binary Search 2 times in depth, meaning binary search in the first array (array of arrays) and the second in the array inside the first array;
bool SearchMatrix(int[][] matrix, int target)
{
    int left = 0;
    int right = matrix.Length - 1;
    int mid;

    while (left <= right)
    {
        mid = (left + right) / 2;

        if (target > matrix[mid][0])
        {
            int e = matrix[mid].Length - 1;
            if (target <= matrix[mid][e])
            {
                int l = 0;
                int r = e;
                int m;
                int[] arr = matrix[mid];

                while (l <= r)
                {
                    m = (l + r) / 2;
                    if (target > arr[m])
                    {
                        l = m + 1;
                    }
                    else if (target < arr[m])
                    {
                        r = m - 1;
                    }
                    else
                    {
                        // return m;
                        return true;
                    }
                }
                return false;
            }
            left = mid + 1;
        }
        else if (target < matrix[mid][0])
        {
            right = mid - 1;
        }
        else
        {
            // return matrix[mid][0];
            return true;
        }
    }
    return false;
}

// Time complexity: O(log(m * n))
// Space complexity: O(1)
// Solved by using Binary Search 2 times in depth, meaning binary search in the first array (array of arrays) and the second in the array inside the first array;
bool SearchMatrix2(int[][] matrix, int target)
{
    int left = 0;
    int right = matrix.Length - 1;
    int mid;

    //First binary search
    while (left <= right)
    {
        mid = (left + right) / 2;

        if (target > matrix[mid][0])
        {
            int e = matrix[mid].Length - 1;

            if (target <= matrix[mid][e])
                return BinarySearch(matrix[mid], target); //Second binary search

            left = mid + 1;
        }
        else if (target < matrix[mid][0])
            right = mid - 1;
        else
            return true;
    }
    return false;
}

bool BinarySearch(int[] arr, int target)
{
    int e = arr.Length - 1;
    int l = 0;
    int r = e;
    int m;

    while (l <= r)
    {
        m = (l + r) / 2;

        if (target > arr[m])
            l = m + 1;
        else if (target < arr[m])
            r = m - 1;
        else
            return true;
    }
    return false;
}

bool exists = SearchMatrix2(matrix: [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], target: 3);
Console.WriteLine("The number" + (exists ? "exists" : "does not exists"));