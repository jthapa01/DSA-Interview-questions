using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    //Given a list of integers, write a function that returns all
    //sets of 3 numbers in the list a,b,c so that a+b+c == 0
    //ThreeSum({-1,0,1,2,-1,4})
    class ThreeSumApp
    {
        static void Main(string[] args)
        {
            int[] testArr = {-1,0,1,2,-1,-4 };
            List<int[]> result = new List<int[]>();
            result = ThreeSum(testArr);
            foreach (int[] item in result)
            {
                foreach (int elems in item)
                {
                    Console.Write("{0} ", elems);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

        public static List<int[]> ThreeSum(int[] arr)
        {
            List<int[]> results = new List<int[]>();
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 3; i++)
            {
                if (i == 0 || arr[i] > arr[i - 1])
                {
                    int start = i + 1;
                    int end = arr.Length - 1;

                    while (start < end)
                    {
                        if (arr[i] + arr[start] + arr[end] == 0)
                        {
                            results.Add(new int[] { arr[i],
                                arr[start], arr[end] });
                        }
                        if (arr[i] + arr[start] + arr[end] < 0)
                        {
                            int currentStart = start;
                            while (arr[start] == arr[currentStart] && start < end)
                            {
                                start++;
                            }
                        }
                        else
                        {
                            int currentEnd = end;
                            while (arr[end] == arr[currentEnd] && start < end)
                            {
                                end--;
                            }
                        }
                    }
                }
            }
            return results;
        }
    }
}
