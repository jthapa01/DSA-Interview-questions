using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    //Given a string, write a function to compress it by
    //shorteningevery sequence of the same character
    //to that charater followed by the number of repetitions.
    //if the compressed string i slonger than the original,
    //you should return the original string
    /*
     *          CompressString("a") = a
     *          CompressString("aaa") = a3
     *          CompressString("aaabbb") = a3b3
     *          CompressString("aaabccc") = a3b1c3
     */
    class Program
    {
        static void Main(string[] args)
        {
            string word = "aaabccc";
            string compressedString = CompressString(word);
            Console.WriteLine($"The compressed string of " +
                $"{word} is {compressedString}");
            Console.ReadLine();

        }

        public static string CompressString(string word)
        {
            int charCount = 1;
            string result = "";
            for(int i = 0; i<word.Length-1; i++)
            {
                if(word[i] == word[i + 1])
                {
                    charCount++;
                }
                else
                {
                    result = result + word[i]+ charCount;
                    charCount = 1;
                }
            }
            result = result + word[word.Length - 1] + charCount;
            return result.Length > word.Length ? word : result;
        }
    }
}
