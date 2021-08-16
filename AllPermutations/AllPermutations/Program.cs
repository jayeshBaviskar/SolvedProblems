using System;
using System.Collections.Generic;

namespace AllPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> array = new List<int>() { 1,2,3};
            List<List<int>> results = new List<List<int>>();
            GetPermutations(0, array, results);
            foreach (var item in results)
            {
                foreach (var v in item)
                {
                    Console.Write(v + " ");
                }
                Console.WriteLine("");
            }

        }

        public static void GetPermutations(int i, List<int> array, List<List<int>> permutations )
        {
            if (i == array.Count - 1)
            {
                permutations.Add(new List<int>(array));
            }
            else
            {
                for(int j=i; j<array.Count; j++)
                {
                    Swap(array, i, j);
                    GetPermutations( i + 1, array, permutations);
                    Swap(array, i, j);

                }
            }

        }

        public static void Swap(List<int> array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }



    }
}
