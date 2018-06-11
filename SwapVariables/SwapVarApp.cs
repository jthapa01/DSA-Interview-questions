using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapVariables
{
    //Given two integers, write a function that swaps them
    //without using any temporary variables
    class SwapVarApp
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 5;
            Console.WriteLine($"Before Swap method ({i }, {j})");
            Swap1(ref i, ref j);
            Console.WriteLine($"After Swap first logic ({i }, {j})");
            int a = 5;
            int b = 6;
            Console.WriteLine($"Before Swap method ({a }, {b})");
            Swap2( ref a,  ref b);
            Console.WriteLine($"After Swap second logic ({a }, {b})");
            Console.ReadKey();
        }

        public static void Swap1(ref int  a,ref  int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static void Swap2( ref int a,  ref int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }
    }
}
