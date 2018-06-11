using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImpleFrmQ
{
    //Implement a stack with basic functionality (push and pop) 
    //using queues to store the data
    class StackFrmQApp
    {
        static void Main(string[] args)
        {
            StackCls stack = new StackCls();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Display();
            stack.Pop();
            stack.Display();
            Console.ReadKey();
        }
    }
    public class StackCls
    {
        private Queue<int> primary = new Queue<int>();
        private Queue<int> secondary = new Queue<int>();
        public StackCls()
        {

        }

        public void Push(int x)
        {
            secondary.Enqueue(x);
            while (primary.Count != 0)
            {
                secondary.Enqueue(primary.Dequeue());
            }

            Queue<int> temp = primary;
            primary = secondary;
            secondary = temp;
        }

        public int Pop()
        {
            if (primary.Count == 0 )
            {
                throw new IndexOutOfRangeException();
            }
            return primary.Dequeue();
        }

        public void Display()
        {
            foreach(int i in primary)
            {
                Console.Write("=> ");
                Console.Write( i + " ");
            }
            Console.WriteLine();
        }
    }
}
