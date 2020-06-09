using System;
using System.Collections.Generic;

// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Solution
{
    public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
    {
        public int Compare(TKey x, TKey y)
        {
            int result = x.CompareTo(y);

            if (result == 0)
                return 1; 
            else
                return result;
        }
    }

    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public List<string> popularNToys(int numToys,
                                     int topToys,
                                     List<string> toys,
                                     int numQuotes, List<string> quotes)
    {
        
        SortedList<int, string> sortedToyList = new SortedList<int, string>(new DuplicateKeyComparer<int>());
        StringComparison comparetor = new StringComparison();
        String toyName = "";
        int toyCount = 0;
        foreach (string st in quotes)
        {
            toyName = "";
            toyCount = 0;

            foreach (string ty in toys)
            {
                toyName = ty;
                if (InsensitiveContains(st, ty, comparetor))
                {
                    //System.Console.WriteLine(ty);
                    ++toyCount;
                }
                sortedToyList.Add(toyCount, toyName);

             
            }
        }

        List<string> result = new List<string>();
        System.Console.WriteLine(sortedToyList.Count);

        for (int i = 0; i < topToys; i++)
        {
            try
            {
                result.Add(sortedToyList.Values[(sortedToyList.Count - 1 - i)]);
            }
            catch
            {   
            }
            
        }
        return result;
    }

    public static bool InsensitiveContains(string source, string value, StringComparison comparisonType)
    {
        return source?.IndexOf(value, comparisonType) >= 0;
    }

    // METHOD SIGNATURE ENDS
}