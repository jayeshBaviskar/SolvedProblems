using System;

namespace Find_Frequency_in_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 3, 6, 9, 12, 14, 19, 20, 23, 25, 27 };

            Console.WriteLine("Element Available at : " + getIndex(14, arr));

        }

        private static int getIndex(int element, int[] arr)
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
                    ans = mid;
                    low = mid - 1;
                }
                else if (element > arr[mid])
                {
                    low = mid - 1;
                }
                else if (element < arr[mid])
                {
                    low = mid + 1;
                }
            }


            return -1;
        }

    }
}
