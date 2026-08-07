#:property TargetFramework=net10.0
#:property PublishAot=false



using System.ComponentModel;

/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */
 // Time complexity: O(logn)
static int GuessNumber(int n)
{
    int low = 1;
    int high = n;
    int mid;

    while (low <= high)
    {
        // A different way to calculate the mid number, instead of
        // adding the two numbers and dividing the result by two
        // we substract high - low divided by two and the result added the low.
        mid = low + (high - low) / 2;

        if (guess(mid) < 0)
        {
            high = mid - 1;
        }
        else if (guess(mid) > 0)
        {
            low = mid + 1;
        }
        else
            return mid;
    }
    return -1;
}

static int guess(int n)
{
    if (n > 13)
    {
        return -1;
    }
    else if (n < 13)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine(GuessNumber(700));