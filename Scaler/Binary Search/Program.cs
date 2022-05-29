using System;

namespace Binary_Search
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 3, 6, 9, 12, 14, 19, 20, 23, 25, 27 };

            Console.WriteLine("Element Available at : " + getIndex(14, arr));
            Console.Read();
        }

        private static int getIndex(int element, int[] arr)
        {
            int low = 0;
            int high = arr.Length;
            int mid = 0;

            while (low <= high)
            {
                mid = (high + low) / 2;
                if (element == arr[mid])
                {
                    return mid;
                }
                else
                {
                    if (arr[mid] < element)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}