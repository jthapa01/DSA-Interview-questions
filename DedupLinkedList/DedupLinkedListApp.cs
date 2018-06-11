using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedupLinkedList
{
    //Given the linked list, write a functin to remove all the duplicates
    class DedupLinkedListApp
    {
        static void Main(string[] args)
        {
            Node linkList = new Node(1);
            linkList.next = new Node(2);
            linkList.next.next = new Node(3);
            linkList.next.next.next = new Node(2);
            linkList.next.next.next.next = new Node(1);
            //Dedup(linkList);
            Dedup2(linkList);
            while(linkList != null)
            {
                Console.WriteLine(linkList.value + " ");
                linkList = linkList.next;
            }
            Console.ReadKey();
        }

        public static void Dedup(Node n)
        {
            if(n== null)
            {
                return;
            }
            HashSet<int> set = new HashSet<int>();
            Node previous = null;
            while (n != null)
            {
                if (set.Contains(n.value))
                {
                    previous.next = n.next;
                }
                else
                {
                    set.Add(n.value);
                    previous = n;
                }
                n = n.next;
            }
        }
        //without using any extra storage
        public static void Dedup2(Node n)
        {
            while(n!= null)
            {
                Node current = n;
                while(current.next != null)
                {
                    if(current.next.value == n.value)
                    {
                        current.next = current.next.next;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
                n = n.next;

            }
        }
    }
    class Node
    {
        public int value;
        public Node next;
        public Node(int _value)
        {
            value = _value;
            next = null;
        }
    }
}
