using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShift
{
    //Given a number, write a function to rotate the bits(ie circular shift)
    //eg. Rotate(0xFFFF0000,8)= 0xFFFF0000>>N
    class RotateBitsApp
    {
        static void Main(string[] args)
        {
            int result = Rotate(0xFABCABA, 8);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        private static int BITS_IN_INTEGER = 32;
        public static int Rotate(int x, int N)
        {
            return (x >> N | x << (BITS_IN_INTEGER - N));
        }

    }
}
