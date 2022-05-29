using System;
using System.Collections.Generic;

namespace Next_Permutation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            NextPermutation(arr);
            Console.WriteLine("");
        }

        public static void NextPermutation(int[] nums)
        {
            int ind1 = -1;
            int ind2 = -1;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] < nums[i + 1])
                {
                    ind1 = i;
                    break;
                }
            }

            if (ind1 == -1)
            {
                Array.Reverse(nums);
                return;
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] > nums[ind1])
                {
                    ind2 = i;
                    break;
                }
            }


            int temp = nums[ind1];
            nums[ind1] = nums[ind2];
            nums[ind2] = temp;

            Stack<int> stack = new Stack<int>();

            for (int i = ind1 + 1; i < nums.Length; i++)
            {
                stack.Push(nums[i]);
            }

            for (int i = ind1 + 1; i < nums.Length; i++)
            {
                nums[i] = stack.Pop();
            }
        }
    }
}