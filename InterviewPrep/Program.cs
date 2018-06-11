using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        //FizzBuzz: Output memebrs from 1 to x. if the number is divisible by 3, replace it with "Fizz".
        //IF it is divisible by 5, replace it with "Buzz". If it is divisible by 3 and 5 replace it with 
        //Fizzbuzz
        static void Main(string[] args)
        {
            Program pgm = new Program();
            pgm.FizzBuzz(15);
            Console.ReadLine();
        }

        public void FizzBuzz(int x)
        {   for(int i = 1; i<=x; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
