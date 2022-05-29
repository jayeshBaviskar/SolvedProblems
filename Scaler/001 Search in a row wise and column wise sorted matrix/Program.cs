using System;
using System.Collections.Generic;

namespace _001_Search_in_a_row_wise_and_column_wise_sorted_matrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program p = new Program();

            List<List<int>> lst = new List<List<int>>();
            Console.WriteLine(p.solve(Helper.TwoDimention_ListContructor.ConstructInt2DListFromFile(), 91));
        }

        public int solve(List<List<int>> A, int B)
        {
            int r = A.Count;
            int c = A[0].Count;

            int curr_r = 0;
            int curr_c = c - 1;
            int res = int.MaxValue;
            bool found = false;
            while (!isOutOfBound(curr_r, curr_c, r, c))
            {
                if (A[curr_r][curr_c] == B)
                {
                    if (res > ((curr_r + 1) * 1009 + (curr_c + 1)))
                    {
                        res = ((curr_r + 1) * 1009 + (curr_c + 1));
                    }

                    found = true;
                    --curr_c;
                }
                else
                {
                    if (B < A[curr_r][curr_c])
                    {
                        --curr_c;
                    }
                    else if (B > A[curr_r][curr_c])
                    {
                        ++curr_r;
                    }
                }
            }

            return found ? res : -1;
        }

        public bool isOutOfBound(int curr_r, int curr_c, int r, int c)
        {
            if (curr_r < 0)
            {
                return true;
            }
            else if (curr_c < 0)
            {
                return true;
            }
            else if (curr_r >= r)
            {
                return true;
            }
            else if (curr_c >= c)
            {
                return true;
            }
            return false;
        }
    }
}