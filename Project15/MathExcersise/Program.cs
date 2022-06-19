using System;
using System.Collections.Generic;

namespace MathDemo
{

    public class Square_roots
    {

        public static List<int> FindIntegerRoots(int UpperLimit)
        {
            List<int> results = new List<int>(); 
            for (int n = 1; n <= UpperLimit; n++)
            {
                if (Math.Sqrt(n) % 1 == 0)
                {
               
                    results.Add(n);

                }
            }
            return results;
        }

        private static void PrintToConsole(List<int> ints)
        {
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main()
        {
            List<int> ints = FindIntegerRoots(1000);
          PrintToConsole(ints);
        }
    }
}