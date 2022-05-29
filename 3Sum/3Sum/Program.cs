using System;
using System.Collections.Generic;

namespace _3Sum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { -1, 0, 1, 2, -1, -4 };
            ThreeSum(arr);
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if ((i != 0) && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;

                int sum = 0;
                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        List<int> r = new List<int>();
                        r.Add(nums[i]);
                        r.Add(nums[left]);
                        r.Add(nums[right]);

                        result.Add(r);
                        Console.Write("Added --> ");
                        //left = right;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }
}