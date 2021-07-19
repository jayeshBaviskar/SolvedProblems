using System.Collections.Generic;
using System;

namespace TournamentWinner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
     
           

            List<List<string>> competitions = new List<List<string>>();
            List<string> competition1 = new List<string> {
            "HTML", "C#"
        };
            List<string> competition2 = new List<string> {
            "C#", "Python"
        };
            List<string> competition3 = new List<string> {
            "Python", "HTML"
        };
            competitions.Add(competition1);
            competitions.Add(competition2);
            competitions.Add(competition3);
            List<int> results = new List<int> {
            0, 0, 1
        };

            Console.WriteLine("Result " +  TournamentWinner(competitions, results));
        }

        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            string finalResult = "";
            int max = -1;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {
                List<string> lst = competitions[i];
                string winner = lst[results[i]];
                if (dict.ContainsKey(winner))
                {
                    dict[winner] += 1;
                    if (max < dict[winner])
                    {
                        max = dict[winner];
                        finalResult = winner;
                    }
                }
                else
                {
                    dict[winner] = 1;
                    if (max < 1)
                    {
                        finalResult = winner;
                        max = 1;
                    }
                }
            }
            return finalResult;
        }
    }
}