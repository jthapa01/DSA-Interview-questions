using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDeletion
{
    /* 
     * Given a string and a dictionary HashSet, write a functon 
     * to determine the minimum number of characters to delete
     * to make a word
    */
    class StringDeletionApp
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("a");
            set.Add("aa");
            set.Add("aaa");
            string searchString = "abc";
            int result = Delete(searchString, set);
            Console.WriteLine($"The minimum number of string to delete" +
                $" to make a word: {result} ");
            Console.ReadKey();

        }

        public static int Delete(string query, HashSet<string> dictionary)
        {
            Queue<string> queue = new Queue<string>();
            HashSet<string> set = new HashSet<string>();
            queue.Enqueue(query);
            set.Add(query);
            while(queue.Count != 0)
            {
                string s = queue.Dequeue();
                set.Remove(s);
                if (dictionary.Contains(s))
                {
                    return query.Length - s.Length;
                }

                for(int i = 0; i<s.Length; i++)
                {
                    string sub = s.Substring(0, i) + s.Substring(i + 1, s.Length-1-i);
                    if(!set.Contains(sub) && sub.Length > 0)
                    {
                        queue.Enqueue(sub);
                        set.Add(sub);
                    }
                }
            }
            return -1;
        }
    }
}
