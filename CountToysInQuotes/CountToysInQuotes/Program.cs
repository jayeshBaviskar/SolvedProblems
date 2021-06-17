using System;
using System.Collections.Generic;
using System.Linq;

namespace CountToysInQuotes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numOfToys = 5;
            String[] toys = { "bicycle", "doll", "teddy bear", "kite", "airplane" };

            int numOfQuotes = 8;
            String[] quotes = { "This is a doll and teddy bear in the airplane" , "Teddy bear is in my house",
                "my daughter is playing with the doll", "airplane is fying in the sky", "This is something else", "good bicycle",
            "my daughter is playing with the doll", "fying in the sky",
            };

            List<String> result = func(numOfToys, 2, toys, numOfQuotes, quotes);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static List<String> func(int numOfToys, int topToys, String[] toys, int numQuotes, String[] quotes)
        {
            Dictionary<String, int> dict = new Dictionary<string, int>();

            List<String> results = new List<string>();
            for (int i = 0; i < numOfToys; i++)
            {
                for (int j = 0; j < numQuotes; j++)
                {
                    if (quotes[j].ToLower().Contains(toys[i].ToLower()))
                    {
                        if (dict.ContainsKey(toys[i]))
                        {
                            int value = dict[toys[i]];
                            ++value;
                            dict[toys[i]] = value;
                        }
                        else
                        {
                            dict[toys[i]] = 1;
                        }
                    }
                }
            }

            foreach (var item in dict.OrderByDescending(k => k.Value))
            {
                if (results.Count < topToys)
                {
                    results.Add(item.Key + ":" + item.Value);
                }
            }

            return results;
        }
    }
}