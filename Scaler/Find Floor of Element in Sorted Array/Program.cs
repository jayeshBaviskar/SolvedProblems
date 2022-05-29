using System;

namespace Find_Floor_of_Element_in_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = {-5, 2, 3, 6, 9, 10, 11, 14, 18 };

            getIndex(10, arr);

        }

        private static  int getIndex(int element, int[] arr)
        {
            int low = 0;
            int high = arr.Length;
            int mid = 0;
            int ans = -1;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (element == arr[mid])
                {
                    ans = arr[mid];
                } else if (element > arr[mid])
                {

                }
                else if (element < arr[mid])
                {

                }
            }

            return -1; 
        }
    }
}
