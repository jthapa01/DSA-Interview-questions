using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitLinkedList
{
    //Given a linked list, write a function that divides it into 
    //two halves. This function should modify the original list
    //and then return a pointer to the second half of the list.
    class SplitLinkedListApp
    {
        static void Main(string[] args)
        {
            LinkList theList = new LinkList();
            theList.InsertFirst(5);
            theList.InsertFirst(4);
            theList.InsertFirst(3);
            theList.InsertFirst(2);
            theList.InsertFirst(1);
            theList.DisplayList();

            Link node = new Link(1);
            node.next = new Link(2);
            node.next.next = new Link(3);
            node.next.next.next = new Link(4);
            node.next.next.next.next = new Link(5);
            int result = theList.LikedListDivider(node);
            Console.WriteLine($"result: {result}");




            Console.ReadKey();
        }
    }

    class Link
    {
        public Link next;
        public int iData;
        public Link(int value)
        {
            iData = value;
            next = null;
        }
        public void DisplayLink()
        {
            Console.Write("{" + iData + "}");
        }

    }
    class LinkList
    {
        public Link first;
        public LinkList()
        {
            first = null;
        }
        public void InsertFirst(int value)
        {
            Link newLink = new Link(value);
            newLink.next = first;
            first = newLink;
        }
        public Link DeleteFirst()
        {
            Link temp = first;
            first = temp.next;
            return temp;
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
        public int LikedListDivider(Link link)
        {
            if (link == null)
            {
                return 0;
            }
            Link runner = link.next;
            while (runner != null)
            {
                runner = runner.next;
                if (runner == null)
                {
                    break;
                }
                runner = runner.next;
                link = link.next;
            }
            Link newLink = link.next;
            link.next = null;
            return newLink.iData;
        }
    }
}
