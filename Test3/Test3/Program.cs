using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write((i * 10) + j + " ");
                    if(j == 5)
                    {
                        break;
                    }
                }
            }
            Console.Read();

        }

    }
}
