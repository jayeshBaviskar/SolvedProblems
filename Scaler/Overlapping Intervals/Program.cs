using System;
using System.Collections.Generic;

namespace Overlapping_Intervals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> lst1 = new List<int>();
            lst1.Add(1);
            lst1.Add(2);

            List<int> lst2 = new List<int>();
            lst2.Add(3);
            lst2.Add(4);

            List<List<int>> finalList = new List<List<int>>();
            finalList.Add(lst1);
            finalList.Add(lst2);

            List<List<int>>  result = solve(finalList, 8, 10);
        }

        public static List<List<int>> solve(List<List<int>> A, int B, int C)
        {
            List<List<int>> result = new List<List<int>>();
            bool remaining = false;
        


            for (int i = 0; i < A.Count; i++)
            {
                int start = A[i][0];
                int end = A[i][1];

                //Before
                if (C < start)
                {
                    result.Add(new List<int> { B, C });
                    remaining = false;
                }

                // Mid / Intersecting
                if ((B >= start) && (B <= end))
                {
                 
                    B = B < start ? B : start;
                    C = C > end ? C : end;
                    remaining = true;

                }

                // after
                if (B > end)
                {
                    result.Add(new List<int> { start, end });
                    remaining = false;
                }
            }


            if (remaining)
            {
                result.Add(new List<int> { B, C });
            }

            if(A[A.Count-1][1] < B)
            {
                result.Add(new List<int> { B, C });
            }
            return result;
        }
    }
}