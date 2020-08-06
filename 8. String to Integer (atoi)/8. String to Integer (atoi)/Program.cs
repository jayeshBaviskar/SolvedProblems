using System;
using System.Collections.Generic;

namespace _8.String_to_Integer__atoi_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("-91283472332"));
            Console.Read();
        }      

        public static int MyAtoi(string str)
        {
            int lastResult = 0;
            bool isNegative = false;
            str = str.Trim();
            int result;

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && str[0].ToString() == "-")
                {
                    isNegative = true;
                }
                else if (i == 0 && str[0].ToString() == "+")
                { }
                else
                {
                    if (Int32.TryParse(str[i].ToString(), out result))
                    {
                        Console.WriteLine("Val : " + result);
                        int prev = lastResult;

                        long test = ((long)lastResult * 10) + result;
                        lastResult = (lastResult * 10) + result;

                        Console.WriteLine("Test {0}, Last Result {1} ", test, lastResult);
                        if (test != lastResult)
                        {
                            Console.WriteLine("LastResult was : " + lastResult.ToString());
                            Console.WriteLine("Prev Result was : " + prev.ToString());

                            if (isNegative)
                            {
                                return Int32.MinValue;
                            }
                            else
                            {
                                return Int32.MaxValue;
                            }
                        }

                        Console.WriteLine("LastResult : " + lastResult);
                    }
                    else
                    {
                        i = str.Length + 1;
                    }
                }
            }

            if (isNegative)
            {
                lastResult = -1 * lastResult;
            }
            return lastResult;
        }
    }
}