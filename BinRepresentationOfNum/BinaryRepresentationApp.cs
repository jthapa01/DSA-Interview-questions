using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinRepresentationOfNum
{
    //Find the number of 1s in the binary representation of a number
    class BinaryRepresentationApp
    {
        static void Main(string[] args)
        {
            BinaryRepresentationApp binRepNum = new BinaryRepresentationApp();
            int testDecimalNum = 15;
            int countOnes = binRepNum.FindOnesInBinary(testDecimalNum);
            Console.WriteLine($"The total number of ones in binary " +
                $"\nrepresentation of {testDecimalNum} is: {countOnes}");
            Console.ReadKey();
        }
        public int FindOnesInBinary(int num)
        {
            int totalOnes = 0;
            while (num > 0)
            {
                totalOnes += num & 1;
                num >>= 1;
            }
            return totalOnes;
        }

    }
}
