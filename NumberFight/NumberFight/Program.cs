using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberFight
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 122333;
            String number_str = number.ToString();
            int result = 0;
            for(int i=0; i<number_str.Length; i=i+2)
            {
                int num1 = Convert.ToInt32(number_str[i]+"");
                int num2 = Int32.MinValue;
                if( (i+1) < number_str.Length)
                {
                    num2 = Convert.ToInt32(number_str[i + 1]+"");
                }

                if(num1 == num2)
                {
                    //DO nothing
                }
                else
                {
                      result = (result * 10) +  (num1 > num2 ? num1 : num2);
                }

            }
            Console.WriteLine("Result:" + result);
        }
    }
}
