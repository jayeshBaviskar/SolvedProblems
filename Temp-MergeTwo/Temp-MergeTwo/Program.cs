using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp_MergeTwo
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void merge(int[] A, int[] B, int size1, int size2)
        {
            int i = size2;
            int j = 0;
            int k = 0;

            while (i  < (size1 + size2) && j < size2)
            {
                if(A[i] <= B[j])
                {
                    A[k] = A[i];
                    k = k + 1;
                    i = i + 1;
                }
                else
                {
                    A[k] = B[j];
                    k = k + 1;
                    j = j + 1;
                }
            }
            int ptr = 0;
            if(i==(size1 + size2))
            {
                
                while (ptr < (size2-j+1))                
                {
                    A[k+ptr] = B[j+ptr];
                    ptr= ptr+1;
                }
            }
            else
            {
                if(A[i] <= B[j])
                {
                    A[k] = A[i];
                    k = k + 1;
                    i = i + 1;
                }
                else
                {
                    A[k] = B[j];
                    k = k + 1;
                    j = j + 1;
                }
            }

            if(i==(size1+size2))
            {
                ptr = 0;

            }
        }
    }
}
