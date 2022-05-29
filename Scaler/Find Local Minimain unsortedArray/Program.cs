using System;

namespace Find_Local_Minimain_unsortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int getLocalMinima(int[] arr)
        {
            if (arr.Length == 1) return 0;
            if (arr[0] < arr[1]) return 0;
            if ((arr[arr.Length - 1] < arr[arr.Length- 2])) return arr.Length - 1;
            

            int low = 1;
            int high = arr.Length-2;
            int mid = 0;

            while (low <= high)
            {
                mid = (high + low) / 2;
                if( (arr[mid-1] > arr[mid]) && (arr[mid+1]>arr[mid]))
                {
                    return mid;
                }
                else if ( (arr[mid-1]) > arr[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
                
            }
            return -1;
        }


        public void getInformation()
        {
        }
    }
}
