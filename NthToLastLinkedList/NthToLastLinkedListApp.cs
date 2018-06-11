using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthToLastLinkedList
{
    //Given a singly linked list, write a function to find the nth-to-last 
    //element of the list. Eg: list = 1 -> 2 -> 3 -> 4 -> 5
    /*                         n = 1, output = 4
     *                         n = 2, output = 3             
     *                         n = 3, output = 2                
     */
    
    class NthToLastLinkedListApp
    {
        static void Main(string[] args)
        {
            NthToLastLinkedListApp tesLinkedList = new NthToLastLinkedListApp();
            Link link1 = new Link(1);
            link1.next = new Link(2);
            link1.next.next = new Link(3);
            link1.next.next.next = new Link(4);
            link1.next.next.next.next = new Link(5);
            Link result = tesLinkedList.NthToLastElement(link1, 2);
            Console.WriteLine($"The Nth to last element of the list is: {result.iData}");
            Console.ReadKey();
        }

        public Link NthToLastElement(Link link, int n)
        {
            Link current = link;
            Link follower = link;
            for(int i = 1; i<=n; i++)
            {
                if (current == null)
                {
                    return null;
                }
                current = current.next;
            }
            while (current.next != null)
            {
                current = current.next;
                follower = follower.next;
            }
            return follower;
        }

    }

    public class Link
    {
        public int iData;
        public Link next;
        public Link(int value)
        {
            iData = value;
            next = null;
        }
    }
}
