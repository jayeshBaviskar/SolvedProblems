using System;

namespace _01_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // IsPrimeForRange(); // Log(n * Sqrt (n))
            //isPrimeForRangeOptimized(50);

            //smallestPrimeforRange(50);

            //Console.WriteLine("NumberOfDivisors of 12 " + (NumberOfDivisors(12)-1));
            NumberOfDivisorsOpmised(600);

            Console.Read();
        }

        // Incomplete
        private static void NumberOfDivisorsOpmised(int num)
        {
            int[] count = new int[num + 1];
            //for (int i = 2; i <= num; i++)
            //{
            //    count[i] = 2;
            //}
            for (int i = 2; i <= num; i++)
            {
                count[i] = 2;
                for (int j = (i*2); j <=num; j++)
                {
                    count[j] ++;
                }
            }

            for(int i=2; i<=num; i++)
            {
                Console.WriteLine(i + " Number of Divisiors are " + count[i]);
            }
        }
        private static int NumberOfDivisors(int num)
        {
            int[] spf = new int[num + 1];
            for (int i = 2; i < spf.Length; i++)
            {
                spf[i] = i;
            }

            //for (int i = 2; i < isPrimeBool.Length; i++)            
            for (int i = 2; (i * i) < spf.Length; i++) // More Optimised
            {
                if (spf[i] == i)
                {
                    //for (int j = i * 2; j <= num; j += i)
                    for (int j = (i * i); j <= num; j += i) // More Optimised
                    {
                        if (spf[j] == j)
                        {
                            spf[j] = i;
                        }
                    }
                }
            }

            int ans = 1;
            while (num > 1)
            {
                int x = spf[num];
                int count = 0;
                while( (num%x) == 0)
                {
                    num = num / x;
                    count++;
                }
                ans = ans * count + 1;
            }

            return ans;
        }
        public static void smallestPrimeforRange(int num)
        {
            // Time Complexity to create SPF Array ::  N Log (N)
            int[] spf = new int[num + 1];
            for (int i = 2; i < spf.Length; i++)
            {
                spf[i] = i;
            }

            //for (int i = 2; i < isPrimeBool.Length; i++)            
            for (int i = 2; (i * i) < spf.Length; i++) // More Optimised
            {
                if (spf[i] == i)
                {
                    //for (int j = i * 2; j <= num; j += i)
                    for (int j = (i * i); j <= num; j += i) // More Optimised
                    {
                        if(spf[j] == j)
                        {
                            spf[j] = i;
                        }
                    }
                }
            }

            for (int i = 2; i <= num; i++)
            {
                if(i == spf[i])
                {
                    Console.WriteLine(i + " smallest Prime : " + spf[i] + " Number is Prime");
                }
                else
                {
                    Console.WriteLine(i + " smallest Prime : " + spf[i]);
                }
                
            }
        }

        // Sieve of Eratosthenes
        // Time Complexity = N * Log ( Log N )  ~~ O(N)
        // This algorithm will not work where N is greater than 10^6
        // Because we cannot declare array with such large Number,
        // it will give segmenatation Fault
        public static void isPrimeForRangeOptimized(int num)
        {
            bool[] isPrimeBool = new bool[num + 1];
            for(int i=2; i < isPrimeBool.Length; i++)
            {
                isPrimeBool[i] = true;
            }

            //for (int i = 2; i < isPrimeBool.Length; i++)            
            for (int i = 2; (i*i) < isPrimeBool.Length; i++) // More Optimised
            {
                if (isPrimeBool[i]==true)
                {
                    //for (int j = i * 2; j <= num; j += i)
                    for (int j = (i * i); j <= num; j += i) // More Optimised
                    {
                        isPrimeBool[j] = false;
                    }
                }
            }


            for(int i=2; i<=num; i++)
            {
                Console.WriteLine(i + " Is Prime : " + isPrimeBool[i]);
            }





        }

        public static void IsPrimeForRange()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Is " + i.ToString() + " Prime: " + isPrime(i));
            }

        }
        private static bool isPrime(int num)
        {
            int count = 0;
            for (int i = 1; (i * i) <= num; i++ ) // Log(Sqrt(n)
            {
                if( (num%i) == 0)
                {
                    count++;
                    if(num != i)
                    {
                        count++;
                    }
                }
            }

            if(count == 2)
            {
                return true;
            }

            return false;   
        }
    }
}
