using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    //Write a function that returns all permutation of a given list
    /*
     * Permutations({1,2.3})
     *              {1,2,3}
     *              {2,1,3}
     *              {2,3,1}
     *              {3,1,2}
     *              {3,2,1}        
     */
    class PermutationApp
    {
        static void Main(string[] args)
        {
            //string word = "cat";
            //List<string> resultList = new List<string>();
            
            //resultList = Permutations(word);
            //foreach(string str in resultList)
            //{
            //    Console.WriteLine(str);
            //}

            int[] arr = new int[]{1,2};
            List<int[]> resultPermutation = new List<int[]>();

            resultPermutation = DoPermutation(arr); 
            foreach (int[] intArr in resultPermutation)
            {
                foreach (int num in intArr)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        public static List<string> Permutations(string word)
        {
            List<string> results = new List<string>();
            Permutations("", word, results);
            return results;
        }

        private static void Permutations(string prefix, string suffix, List<string> results)
        {
            if(suffix.Length == 0)
            {
                results.Add(prefix);
            }
            else
            {
                for(int i = 0; i<suffix.Length; i++)
                {
                    Permutations(prefix + suffix[i], suffix.Substring(0, i) 
                        + suffix.Substring(i + 1), results);
                }
            }
        }

        public static List<int[]> DoPermutation(int[] a)
        {
            List<int[]> results = new List<int[]>();
            DoPermutation(a, 0, results);
            return results;
        }

        private static void DoPermutation(int[] a, int start, List<int[]> result)
        {
            if(start >= a.Length)
            {
                result.Add((int[])a.Clone());
            }
            else
            {
                for(int i= start; i<a.Length; i++)
                {
                    Swap(a, start, i);
                    DoPermutation(a, start + 1, result);
                    Swap(a, start, i);
                }
            }
        }

        private static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}