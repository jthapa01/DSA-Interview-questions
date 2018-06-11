using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumOfOnes
{
    //Find the number of 1s in the binary representation of a number
    /*      CountOnes(2) = 1
     *      CountOnes(7) = 3
     *      CountOnes(5) = 2
     */      
    class CountOnesInBinApp
    {
        static void Main(string[] args)
        {
            CountOnesInBinApp countOnes = new CountOnesInBinApp();
            int testDecNum = 15;
            int totalOnes = countOnes.CountOnesInBinaryRep(testDecNum);
            Console.WriteLine($"The total number of 1s in the binary " +
                $"representation of {testDecNum} is: {totalOnes}");
            Console.ReadKey();
        }
        public int CountOnesInBinaryRep(int decNum)
        {
            int sum = 0;
            while (decNum > 0)
            {
                sum += decNum & 1;
                decNum = decNum >> 1;
            }
            return sum;
        }

    }
}
