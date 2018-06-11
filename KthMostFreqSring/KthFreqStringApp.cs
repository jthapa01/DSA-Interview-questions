using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthMostFreqSring
{
    //Given a list of strings, write a function to find the
    //kth most frequently recurring string
    class KthFreqStringApp
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[] {"a","a","b"};
            int numFreq = 2;
            string result = KthMostFreqSearch(strArr, numFreq);
            Console.WriteLine($"The kth most frequently " +
                                 $"recurring string is: {result}");
            Console.ReadLine();
        }

        public static string KthMostFreqSearch(string[] strWords, int freq)
        {
            Dictionary<string, int> strDict = new Dictionary<string, int>();
            foreach (string itemKey in strWords)
            {
                int val=0;
                if (!strDict.ContainsKey(itemKey))
                {
                    strDict.Add(itemKey, (int)++val);
                }
                else
                {
                    ++strDict[itemKey];
                }
            }
            List<KeyValuePair<string, int>> listDict = 
                new List<KeyValuePair<string, int>>(strDict);
            listDict.Sort
                (
                    delegate (KeyValuePair<string, int> pair1,
                        KeyValuePair<string, int> pair2)
                    {
                        return pair1.Value.CompareTo(pair2.Value);
                    }
                );
            if(listDict.Count>= freq)
            {
                return(listDict.Where(c => strDict.Values
                                .Contains(freq)).FirstOrDefault()).Key;
            }
            return null;
        }
    }
}
