using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSearch
{
    class MatrixSearchApp
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                { 0, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 8, 9, 10, 11}
            };
            int lookFor = 8;
            bool found = Contains(matrix, lookFor);
            Console.WriteLine($"Looking for {lookFor}: Found? {found}");
            Console.ReadKey();

        }

        public static bool Contains(int[,] arr, int x)
        {
            if(arr.Length == 0|| arr.GetLength(0) == 0)
            {
                return false;
            }
            int row = 0;
            int col = arr.GetLength(1) - 1;
            while(row< arr.GetLength(0) && col >= 0)
            {
                if(arr[row,col] == x)
                {
                    return true;
                }
                if(arr[row,col] < x)
                {
                    row++;
                }
                else
                {
                    col--;
                }
            }
            return false;
        }
    }
}
