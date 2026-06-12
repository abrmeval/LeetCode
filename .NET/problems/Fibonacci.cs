#:property TargetFramework=net10.0
#:property PublishAot=false

// Complexity: O(n) time and O(n) space
int[] Fibbonacci(int n)
{
    int[] r = new int[n];

    for (int x = 0; x < n; x++)
    {
        if (x <= 1)
        {
            r[x] = x;
            continue;
        }

        r[x] = r[x - 1] + r[x - 2];
    }
    return r;
}


// Complexity: O(2^n) time and O(n) space
int Fibbonacc2(int n)
{
    if (n <= 0)
        return n;
    
    return Fibbonacc2(n - 1) + Fibbonacc2(n - 2);
}

Console.WriteLine(string.Join(", ", Fibbonacci(9))); //Output: 3