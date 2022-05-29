using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class TwoDimention_ListContructor
    {
        public static List<List<int>> ConstructInt2DListFromFile()
        {
            String file = @"D:\DS_Algo_Design\SolvedProblems\Scaler\Helper\2DArray.txt";
            String data = File.ReadAllText(file);
            data = data.Replace("[", "");
            data = data.Replace("\r", "");
            data = data.Replace("\n", "");
            string[] arrData = data.Split("]");

            List<List<int>> result = new List<List<int>>();

            
            
            foreach (var item in arrData)
            {
                if (!item.Contains(','))
                {
                    continue;
                }

                List<int> col = new List<int>();
                string[] allElements = item.Split(',');
                foreach (var element in allElements)
                {
                    col.Add(Convert.ToInt32(element.Trim()));
                    
                }
                result.Add(col);
            }


            return result;

        }
    }
}
