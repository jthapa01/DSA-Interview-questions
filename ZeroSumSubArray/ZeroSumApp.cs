using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSumSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[] {1,2,-5,1,2,-1};
            //int[] result = new int[testArr.Length];
            int[] result = ZeroSum(testArr);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static int[] ZeroSum(int[] arr)
        {
            Dictionary<int, int> dictSum = new Dictionary<int, int>();
            int sum = 0;
            int? oldIndex = null;
            for (int i = 0; i<=arr.Length; i++)
            {
                if (dictSum.ContainsKey(sum))
                {
                     oldIndex= dictSum[sum];
                }

                if(oldIndex == null && i == arr.Length)
                {
                    return null;
                }else if (oldIndex == null)
                {
                    dictSum.Add(sum, i);
                    sum += arr[i];
                }
                else
                {
                    return arr.ToList().GetRange((int)oldIndex, i-1).ToArray(); 
                }
            }
            return null;
        }

    }
}
