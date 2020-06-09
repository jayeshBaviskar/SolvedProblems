using System;

namespace Quick_Sort_Using_C_Sharp
{
    internal class QuickSort
    {
        private int[] arr = { 7, 6, 5, 4, 3, 2, 1, 0 };

        private int partition(int start, int end)
        {
            int pivot = arr[end];
            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    swap(arr[i], arr[start]);
                    start++;
                }
            }

            swap(arr[start], arr[end]);            
            return start;
        }

        private void swap(int ind1, int ind2)
        {
            int temp = arr[ind1];
            arr[ind1] = arr[ind2];
            arr[ind2] = temp;
        }

        private void QuickSortMethod(int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = partition(start, end);
                QuickSortMethod(start, partitionIndex - 1);
                QuickSortMethod(partitionIndex + 1, end);
            }
        }

        private static void Main(string[] args)
        {
            QuickSort quick = new QuickSort();

            quick.QuickSortMethod(0, 7);
            quick.showArray();

            Console.Read();
        }

        public void showArray()
        {
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
    }
}