using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStack
{
    //Given a stack, reverse the items in the stack without using 
    //any additional data structures.
    class ReverseStackApp
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Stack<int> reversedStack = Reverse(stack);
            foreach (int item in reversedStack)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        public static Stack<int> Reverse(Stack<int> stack)
        {
            if(stack.Count == 0)
            {
                return stack;
            }
            int temp = stack.Pop();
            Reverse(stack);
            InsertAtBottom(stack, temp);
            return stack;
        }

        private static void InsertAtBottom(Stack<int> stack, int x)
        {
            if(stack.Count == 0)
            {
                stack.Push(x);
                return;
            }
            int temp = stack.Pop();
            InsertAtBottom(stack, x);
            stack.Push(temp);
        }
    }
}
