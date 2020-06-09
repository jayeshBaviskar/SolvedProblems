using System;
namespace Bit_Wise_And_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;            
            if( (num & 1) == 1)
            {
                Console.WriteLine("Odd Number");
            }
            else
            {
                Console.WriteLine("Even Number");
            }

            Console.Read();
        }
    }
}
