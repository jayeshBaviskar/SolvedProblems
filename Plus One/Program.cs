using System;

namespace Plus_One
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 9,9 }; 
            Console.WriteLine(PlusOne(arr));
        }

        public static int[] PlusOne(int[] digits)
        {
            String result = "";
            int carry = 0;
            int i = 0;

            for (i = digits.Length - 1; i >= 0; i--)
            {
                int sum = 0;

                if (i == digits.Length - 1)
                {
                    sum = digits[i] + 1;
                }
                else
                {
                    sum = digits[i] + carry;
                    carry = 0;
                }

                if (sum < 9)
                {
                    result = sum + result;
                    break;
                }
                else
                {
                    result = (sum % 10) + result;
                    carry = sum / 10;
                }
            }

            if (carry != 0)
            {
                result = (digits[0] + carry).ToString();
            }

            if (i > 0)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    result = digits[j] + result;
                }
            }

            int[] output = new int[result.Length];
            for (int k = 0; k < result.Length; k++)
            {
                output[k] = result[k] - '0';
            }

            return output;
        }
    }
}