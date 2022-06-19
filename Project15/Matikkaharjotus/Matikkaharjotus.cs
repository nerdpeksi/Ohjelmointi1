using System;

public class Square_roots
{

    static void FindIntegerRootsAndPrint(int UpperLimit)
    {

        for (int n = 1; n <= UpperLimit; n++)
        {
            if (Math.Sqrt(n) % 1 == 0)
            {
                System.Console.WriteLine(n);

            }
        }
    }

    public static void Main()
    {
        FindIntegerRootsAndPrint(1000);
    }
}