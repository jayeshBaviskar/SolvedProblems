using System;

namespace RunLengthEncoding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = "........______=========AAAA   AAABBBB   BBB";
          
            var actual = new Program().RunLengthEncoding(input);
            Console.WriteLine(actual);
        }

        public string RunLengthEncoding(string str)
        {
            char lastChar = 'a';
            int count = 0;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    lastChar = str[i];
                    count = 1;
                }
                else
                {
                    if (str[i] == lastChar)
                    {
                        ++count;
                        if (count == 9)
                        {
                            result += ((count + "") + lastChar + "");
                            count = 0;
                        }
                    }
                    else
                    {
                        if (count > 0)
                        {
                            result += ((count + "") + lastChar + "");
                        }
                        lastChar = str[i];
                        count = 1;
                    }
                }
            }
            if (count > 0)
            {
                result += ((count + "") + lastChar + "");
            }
            return result;
        }
    }
}