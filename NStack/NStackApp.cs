using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NStack
{
    //Implement N>0 stacks using a single array to store all
    //stack data. No stack should be full unless the entire 
    //array is full.
    class NStackApp
    {
        static void Main(string[] args)
        {
            Stacks stack = new Stacks(2, 3);
            stack.Push(0,1);
            stack.Push(0, 2);
            stack.Push(0, 3);
            //stack.Push(0,4);
            stack.Pop(0);
            //stack.Push(1, 4);
            //stack.Push(1, 5);
            //stack.Push(1, 6);
            //stack.Push(1, 7);
            Console.ReadLine();
        }
    }

    public class Stacks
    {
        int[] topOfStack;
        int[] stackData;
        int[] nextIndex;
        int nextAvailable = 0;
        public Stacks(int numOfStack, int size)
        {
            topOfStack = new int[numOfStack];
            for (int i = 0; i < topOfStack.Length; i++)
            {
                topOfStack[i] = -1;
            }

            stackData = new int[size];
            nextIndex = new int[size];
            for(int i=0; i<nextIndex.Length-1; i++)
            {
                nextIndex[i] = i + 1;
            }
            //Last index does not have next index
            nextIndex[nextIndex.Length - 1] = -1;
        }
        public void Push(int stack, int value)
        {
            if(stack<0 || stack >= topOfStack.Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (nextAvailable < 0)
            {
                return;
            }
            int currentIndex = nextAvailable;
            nextAvailable = nextIndex[currentIndex];
            stackData[currentIndex] = value;
            nextIndex[currentIndex] = topOfStack[stack];
            topOfStack[stack] = currentIndex;
        }
        public int Pop(int stack)
        {
            if (stack < 0 || stack >= topOfStack.Length||
                topOfStack[stack]< 0)
            {
                throw new IndexOutOfRangeException();
            }
            int currentIndx = topOfStack[stack];
            int value = stackData[currentIndx];
            topOfStack[stack] = nextIndex[currentIndx];
            nextIndex[currentIndx] = nextAvailable;
            nextAvailable = currentIndx;
            return value;
        }
    }
}
