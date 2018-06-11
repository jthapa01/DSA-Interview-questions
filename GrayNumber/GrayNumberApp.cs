using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrayNumber
{
    //Given two integers, determine whether or not they differ by a single bit
    //          Gray(0,1) = true
    //          Gray(1,2) = false
    class GrayNumberApp
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 15;
            bool result = GrayCode(x,y);
            bool result2 = GrayCode2(x, y);
            Console.WriteLine($"Are {x} and {y} gray Numbers ? : {result}");
            Console.WriteLine($"Are {x} and {y} gray Numbers ? : {result2}");
            Console.ReadKey();

        }

        public static bool GrayCode(int x, int y)
        {
            int z= x ^ y;
            while (z > 0)
            {
                if(z % 2 == 1 && z >> 1 > 0)
                {
                    return false;
                }
                z = z >> 1;
            }
            return true;
        }
        //another efficient method
        public static bool GrayCode2(int x, int y)
        {
            int z = x ^ y;
            return (z & (z - 1)) == 0;
        }
    }
}
