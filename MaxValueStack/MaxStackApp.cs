using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueStack
{
    class MaxStackApp
    {
        //Design a stack with a push, pop, and max function which returns
        //the max value in the stack, all of which are run in O(1) time.
        static void Main(string[] args)
        {
            LinkList stack = new LinkList();
            stack.InsertFirst(20);
            stack.InsertFirst(70);
            stack.InsertFirst(30);
            stack.InsertFirst(50);
            stack.InsertFirst(60);
            stack.DeleteFirst();
            stack.DeleteFirst();
            stack.InsertFirst(55);
            stack.InsertFirst(44);
            stack.DisplayList();

            int maxVal = stack.MaxValue();
            Console.WriteLine($"The max value in a stack is: {maxVal}");
            Console.ReadKey();
        }

    }
    public class Link
    {
        public int iData;
        public Link next;
        public Link oldMax;

        public Link(int value)
        {
            iData = value;
        }
        public void DisplayLink()
        {
            Console.Write("{" + iData + "}");
        }
    }
    public class LinkList
    {
        private Link first;
        private Link max;
        public LinkList()
        {
            first = null;
        }
        public void InsertFirst(int value)
        {
            Link newLink = new Link(value);
            if (first == null)
            {
                first = newLink;
            }
            else
            {
                newLink.next = first;
                first = newLink;
            }
            if(max == null || newLink.iData > max.iData)
            {
                newLink.oldMax = max;
                max = newLink;
            }
        }

        public int DeleteFirst()
        {
            if (first == null)
            {
                throw new NullReferenceException();
            }
            Link temp = first;
            first = first.next;
            if(temp.oldMax != null)
            {
                max = temp.oldMax;
            }
            return temp.iData;
        }

        public int MaxValue()
        {
            if (max == null)
            {
                throw new NullReferenceException();
            }
            return max.iData;
        }

        public void DisplayList()
        {
            Console.Write("List(first --> last): ");
            Link current = first;
            while (current != null)
            {
                current.DisplayLink();
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
