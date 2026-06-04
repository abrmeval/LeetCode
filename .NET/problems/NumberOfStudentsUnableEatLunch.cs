#:property TargetFramework=net10.0
#:property PublishAot=false


//Complexity: O(n^2) time and O(n) space
int CountStudents(int[] students, int[] sandwiches)
{
    int n = 0;
    int[] n_students = new int[students.Length];
    int currentLength = 0;

    while (true)
    {
        bool nextLap = false;
        int y = 0;

        for (int x = 0; x < students.Length - currentLength; x++)
        {
            if (students[x] != sandwiches[n])
            {
                n_students[y] = students[x];
                y++;
            }
            else
            {
                nextLap = true;
                n++;
            }
        }
        students = n_students;
        currentLength = n;

        if (!nextLap || n == students.Length)
            break;
    }
    return students.Length - currentLength;
}
CountStudents(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }); //Output: 0
//[1, 1, 0, 0] and [0, 1, 0, 1]    1
//-> [1, 1, 0] and [1, 0, 1]       2
// -> [1] and [1]                  3
// -> [] and [] -> Output: 0

//Complexity: O(n) time and O(1) space
int CountStudents2(int[] students, int[] sandwiches)
{
    int n_students_1 = 0;
    int n_students_0 = 0;

    for (int x = 0; x < students.Length; x++)
    {
        if (students[x] == 1)
        {
            n_students_1++;
            continue;
        }
        n_students_0++;
    }

    for (int x = 0; x < sandwiches.Length; x++)
    {
        if (sandwiches[x] == 1)
        {
            if (n_students_1 > 0)
            {
                n_students_1--;
                continue;
            }
            break;
        }

        if (n_students_0 > 0)
            n_students_0--;
        else
            break;
    }

    return n_students_1 + n_students_0;
}

Console.WriteLine(CountStudents2(new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 })); //Output: 3
                                                                                                   //[1,1,1,0,0,1] and [1,0,0,0,1,1]    
                                                                                                   //-> [1,1,0,0,1] and [0,0,0,1,1]
                                                                                                   // -> [0,1,1,1] and [0,0,1,1]
                                                                                                   // -> [1,1,1] and [0,1,1]
