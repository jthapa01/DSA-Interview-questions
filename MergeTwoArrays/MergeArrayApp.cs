using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoArrays
{
    //Given two sorted arrays, A and B, where A is long enough to hold
    //the contents of A and B, write a function to copy the contents of
    //B into A without using any buffer or additional memory
    //          A = {1,3,5,0,0,0}
    //                         ^----->mergeIndex pointer initially
    //                   ^----------->aIndex pointer Initially
    //          B = {2,4,6}
    //                   ^----------->bIndex pointer initially
    class MergeArrayApp
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[6];
            arrayA[0] = 1;
            arrayA[1] = 3;
            arrayA[2] = 5;
            int[] arrayB = new int[] { 2, 4, 6 };
            DisplayArray(arrayA);
            DisplayArray(arrayB);
            MergeArrays(arrayA, arrayB, arrayA.Length, arrayB.Length);
            foreach (int num in arrayA)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }

        public static void MergeArrays(int[]a, int[]b, int aLength, int bLength)
        {
            //a array must have enough room to put all elements
            int aIndex = (aLength -bLength)- 1;
            int bIndex = bLength - 1;
            int mergeIndex = aLength  - 1;

            while (aIndex >=0 && bIndex >=0)
            {
                if(a[aIndex] > b[bIndex])
                {
                    a[mergeIndex] = a[aIndex];
                    aIndex--;
                }
                else
                {
                    a[mergeIndex] = b[bIndex];
                    bIndex--;
                }
                mergeIndex--;
            }
            while(bIndex >= 0)
            {
                a[mergeIndex] = b[bIndex];
                bIndex--;
                mergeIndex--;
            }
        }

        public static void DisplayArray(int[] inputArr)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.Write(inputArr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
