using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Arrays
{
    class Program
    {
        public static void MergeArrays(int[] arr1, int[] arr2)
        {
            int index = 0; // index for first Array
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                if (index != arr1.Length)
                {
                    if (arr1[index] < arr2[i])
                    {
                        int temp = arr2[i];
                        arr2[i] = arr1[index];

                        for (int j = arr2.Length - 2; j > i; j--)
                        {
                            arr2[j + 1] = arr2[j];
                        }
                        arr2[i + 1] = temp;
                        index++;
                    }
                }
            }

            for (int i = arr2.Length - (arr1.Length - index); i < arr2.Length; i++)
            {
                arr2[i] = arr1[index];
            }

            DisplayArray(arr2); // Display the Merged Array
        }




        static void Main(string[] args)
        {
            int[] arr1 = { 1 , 5 , 9 };
            int[] arr2 = { 2, 3, 6, 8, 11, 0 , 0 , 0};

            MergeArrays(arr1, arr2);

        }

       


        public static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.Read();
        }
    }
}
