using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class TwoDimention_ArrayContructor
    {
        public static int[,] ConstructInt2DArrayFromFile()
        {
            String file = @"D:\DS_Algo_Design\SolvedProblems\Scaler\Helper\2DArray.txt";
            String data = File.ReadAllText(file);
            data = data.Replace("[", "");
            data = data.Replace("\r", "");
            data = data.Replace("\n", "");
            string[] arrData = data.Split("]");
            string[] firstRow =  arrData[0].Split(',');
            int[,] result = new int[arrData.Length,firstRow.Length];
            int row = 0;
            foreach (var item in arrData)
            {
                if (!item.Contains(','))
                {
                    continue;
                }
                int col = 0;
                string[] allElements = item.Split(',');
                foreach (var element  in allElements)
                {
                    result[row,col] = Convert.ToInt32(element.Trim());
                    ++col;
                }
                ++row;
            }


            return result;

        }
    }
}
