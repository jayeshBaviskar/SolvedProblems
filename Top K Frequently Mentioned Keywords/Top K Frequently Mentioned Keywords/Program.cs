using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_K_Frequently_Mentioned_Keywords
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String[] keywords = { "anacell", "cetracular", "betacellular" };
            Array.Sort(keywords);

            String[] reviews = {
                  "Anacell provides the best services in the city",
                  "betacellular has awesome services cetracular",
                  "Best services provided by anacell, everyone should use anacell"
                };

            int k = 2;

            String[] result = Solve(keywords, reviews);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }

        private static String[] Solve(String[] keyWords, String[] reviews)
        {
            Dictionary<String, int> dict = new Dictionary<string, int>();

            foreach (var review in reviews)
            {
                foreach (var keyWord in keyWords)
                {
                    if (review.ToLower().Contains(keyWord))
                    {
                        if (dict.ContainsKey(keyWord))
                        {
                            dict[keyWord] += 1;
                        }
                        else
                        {
                            dict[keyWord] = 1;
                        }
                    }
                }
            }

            return dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(2).ToArray();
        }
    }
}