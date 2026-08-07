#:property TargetFramework=net10.0
#:property PublishAot=false

//Time complexity: O(n log m)
//Solved by using Binary search algorithm
int MinEatingSpeed(int[] piles, int h)
{
    if (piles.Length <= 1)
    {
        double r = (double)piles[0] / h;
        return (int)Math.Ceiling(r);
    }

    int low = 1;
    int high = piles[0];
    int k = 0;
    int mid;

    for (int i = 1; i < piles.Length; i++)
    {
        if (piles[i] > high)
            high = piles[i];
    }

    while (low <= high)
    {
        mid = low + (high - low) / 2;
        int result = MinimumRate(mid, h, piles);

        if (result > 0)
            low = mid + 1;

        else
        {
            high = mid - 1;
            k = mid;
        }
    }
    return k;
}

int MinimumRate(int k, int h, int[] piles)
{
    int hours = 0;

    for (int i = 0; i < piles.Length; i++)
    {
        // Casting one element of the division to float too get a float result instead of always an int
        double r = (double)piles[i] / k;
        //We always round up to get the hours would take to eat all the bananas in every pile 
        hours += (int)Math.Ceiling(r);
        // If the total hours exceeded the maximum
        if (hours > h)
            return 1;
    }
    return -1;
}

// 6.25 -> 7 per hour
// 2.5 -> 3 per hour
// 5.75 -> 6 per hour
// 1 per hour

// Console.Write(MinEatingSpeed(piles: [25, 10, 23, 4], h: 4));
// Console.Write(MinEatingSpeed(piles: [312884470], h: 312884469));
Console.Write(MinEatingSpeed(piles: [332484035, 524908576, 855865114, 632922376, 222257295, 690155293, 112677673, 679580077, 337406589, 290818316, 877337160, 901728858, 679284947, 688210097, 692137887, 718203285, 629455728, 941802184], h: 823855818));