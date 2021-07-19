using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar_Cipher_Encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            String op = Program.CaesarCypherEncryptor("xyz", 2);
            Console.WriteLine(op.ToString());

        }


        public static string CaesarCypherEncryptor(string str, int key)
        {

            //abc
            //97 98 99
            // 99 100 101
            //0 1 2
            String result = "";
            for (int i = 0; i < str.Length; i++)
            {
                int val = (((int)str[i]) + key) - 97;
                result += (char)((val % 26) + 97);
            }

            return result;
        }
    }
}
