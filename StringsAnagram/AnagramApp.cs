using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAnagram
{
    //Given two strings, write a function to determine
    //whether two strings are anagrams
    //"abb","bab"
    class AnagramApp
    {
        static void Main(string[] args)
        {
            string word1 = "cat";
            string word2 = "tac";
            bool result = IsAnagram(word1, word2);
            Console.WriteLine($"Is {word1} and {word2} anagram? : {result}");
            Console.ReadLine();
        }

        public static bool IsAnagram(string word1, string word2)
        {
            word1.ToLower();
            word2.ToLower();

            int[] charArr = new int [1 << 8];
            foreach (char letter in word1)
            {
                charArr[letter]++;
            }

            foreach(char letter in word2)
            {
                charArr[letter]--;
            }

            foreach(int num in charArr)
            {
                if(num != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
