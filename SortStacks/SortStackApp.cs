using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStacks
{
    //Given a stack, sort the elemetns in the stack using no
    //more than one additional stack
    class SortStackApp
    {
        static void Main(string[] args)
        {
            Stack<int> testStack = new Stack<int>();
            //testStack.Push(4);
            //testStack.Push(2);
            //testStack.Push(3);
            //testStack.Push(1);

            testStack.Push(1);
            testStack.Push(2);
            testStack.Push(3);
            testStack.Push(4);

            Stack<int> resultStack = new Stack<int>();
            resultStack = SortStack(testStack);
            foreach(int stackInt in resultStack)
            {
                Console.Write(stackInt+ " ");
            }
            Console.ReadKey();
        }

        public static Stack<int> SortStack(Stack<int> stack)
        {
            if(stack == null||stack.Count == 0)
            {
                return stack;
            }
            Stack<int> tempStack = new Stack<int>();
            tempStack.Push(stack.Pop());
            while(stack.Count != 0)
            {
                int temp = stack.Pop();
                while(tempStack.Count != 0 && temp > tempStack.Peek())
                {
                    stack.Push(tempStack.Pop());
                }
                tempStack.Push(temp);
            }
            return tempStack;
        }
    }
}
