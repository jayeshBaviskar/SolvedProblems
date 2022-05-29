using System;
using System.Collections.Generic;

namespace _05._First_Missing_Integer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> lst =  Helper.OneDimention_ListConstructor.ConstructIntListFromFile();
            Console.WriteLine("Result: " + firstMissingPositive(lst));
            Console.Read();
        }

        public static int firstMissingPositive(List<int> A)
        {
            A.Add(0);

            for (int i = 0; i < A.Count; i++)
            {
                int element = A[i];
                if ((element < 0) || (element >= A.Count))
                {
                    // do nothing
                }
                else
                {
                    bool canExit = false;
                    while (!canExit)
                    {
                        element = A[i];
                        if ((element < 0) || (element >= A.Count) || (A[element] == element) )
                        {
                            canExit = true;
                        }
                        else
                        {
                            //Swap
                            int temp = A[element];
                            A[element] = A[i];
                            A[i] = temp;
                        }
                    }
                }
            }

            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] != i)
                {
                    return i;
                }
            }

            return A.Count;
        }
    }
}