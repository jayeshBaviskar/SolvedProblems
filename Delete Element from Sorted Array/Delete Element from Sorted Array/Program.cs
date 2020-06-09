using System;

namespace BinarySearch
{
    internal class Program
    {
        private int[] A = { 3, 7, 20, 32, 45, 52, 55, 60, 70 };

        private int getIndex(int element)
        {
            int start = 0;
            int end = A.Length - 1;
            int mid = (start + end) / 2;
            while ((mid >= start) && (mid <= end))
            {
                if (A[mid] == element)
                {
                    return mid;
                }
                else if (A[mid] > element)
                {
                    end = mid - 1;
                    mid = (start + end) / 2;
                }
                else if (A[mid] < element)
                {
                    start = mid + 1;
                    mid = (start + end) / 2;
                }
            }

            return -1;
        }

        private static void Main(string[] args)
        {
            int element = 20;

            Program program = new Program();
            int result = program.getIndex(element);
            Console.WriteLine("Index = " + result);
            Console.Read();
        }
    }
}