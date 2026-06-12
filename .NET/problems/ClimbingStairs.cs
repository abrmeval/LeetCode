#:property TargetFramework=net10.0
#:property PublishAot=false

// Complexity: O(2^n) time and O(n) space
int ClimbStairs(int n)
{
    if (n <= 2)
        return n;
    return ClimbStairs(n - 1) + ClimbStairs(n - 2);
}

//Complexity: O(n) time and O(n) space
Dictionary<int, int> cache = [];
int ClimbStairs2(int n)
{
    if (n <= 0)
    {
        cache[n] = n;
        return n;
    }

    if (n <= 2)
    {
        cache[n] = n;
        ClimbStairs(n - 1);
        return cache[n];
    }

    ClimbStairs(n - 1);
    cache[n] = cache[n - 1] + cache[n - 2];
    return cache[n];
}

Console.WriteLine(ClimbStairs(2)); //Output: 2