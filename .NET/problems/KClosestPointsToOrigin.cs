
//Time complexity: O(n^2)
int[][] KClosest(int[][] points, int k)
{
    double[] distances = new double[points.Length];

    //Calculating distances
    for (int i = 0; i < points.Length; i++)
    {
        int x = points[i][0];
        int y = points[i][1];
        distances[i] = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
    }

    QuickSort(distances, points, 0, distances.Length - 1);

    return points[0..k];

    //Merge distances
    void QuickSort(double[] distances, int[][] points, int s, int e)
    {
        //Verify the length of the array
        if (e - s + 1 <= 1)
        {
            return;
        }

        double pivot = distances[e]; // pivot, last index of the array
        int[] pivot2 = points[e];
        int left = s;       // pointer for left side

        //Partitioning
        for (int i = s; i < e; i++)
        {
            if (distances[i] < pivot)
            {
                double tmp = distances[left];
                distances[left] = distances[i];
                distances[i] = tmp;

                int[] tmp2 = points[left];
                points[left] = points[i];
                points[i] = tmp2;

                left++;
            }
        }

        // Move pivot in-between left & right sides
        distances[e] = distances[left];
        distances[left] = pivot;

        points[e] = points[left];
        points[left] = pivot2;

        // Quick sort left side
        QuickSort(distances, points, s, left - 1);

        // Quick sort right side
        QuickSort(distances, points, left + 1, e);

        return;
    }
}

//Time complexity: O(n^2)
int[][] KClosest2(int[][] points, int k)
{
    QuickSort(points, 0, points.Length - 1);

    return points[0..k];

    //Merge distances
    void QuickSort(int[][] points, int s, int e)
    {
        //Verify the length of the array
        if (e - s + 1 <= 1)
        {
            return;
        }

        int[] pivot = points[e];
        double pivotDistance = CalculateDistance(pivot[0], pivot[1]);
        int left = s; // pointer for left side

        //Partitioning
        for (int i = s; i < e; i++)
        {
            double distance = CalculateDistance(points[i][0], points[i][1]);

            if (distance < pivotDistance)
            {
                int[] tmp = points[left];
                points[left] = points[i];
                points[i] = tmp;

                left++;
            }
        }

        // Move pivot in-between left & right sides
        points[e] = points[left];
        points[left] = pivot;

        // Quick sort left side
        QuickSort(points, s, left - 1);

        // Quick sort right side
        QuickSort(points, left + 1, e);

        return;
    }

    double CalculateDistance(int x, int y)
    {
        return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
    }
}

//Time complexity: O(n log n)
int[][] KClosest3(int[][] points, int k)
{
    //Calculating distances
    return points.OrderBy(m => Math.Sqrt(Math.Pow(m[0], 2) + Math.Pow(m[1], 2))).Take(k).ToArray();
}