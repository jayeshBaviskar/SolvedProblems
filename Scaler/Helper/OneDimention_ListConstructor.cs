using System;
using System.Collections.Generic;
using System.IO;

namespace Helper
{
    public class OneDimention_ListConstructor
    {
        public static List<int> ConstructIntListFromFile()
        {
            String file = @"D:\DS_Algo_Design\SolvedProblems\Scaler\Helper\1DArray.txt";
            String data = File.ReadAllText(file);
            data = data.Replace("[", "");
            data = data.Replace("\r", "");
            data = data.Replace("\n", "");
            string[] arrData = data.Split("]");

            List<int> result = new List<int>();

            foreach (var item in arrData)
            {
                if (!item.Contains(','))
                {
                    continue;
                }

                string[] allElements = item.Split(',');
                foreach (var element in allElements)
                {
                    result.Add(Convert.ToInt32(element.Trim()));
                }
            }

            return result;
        }
    }
}