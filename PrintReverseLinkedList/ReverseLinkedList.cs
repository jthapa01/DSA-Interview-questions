using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintReverseLinkedList
{
    //Given a linked list, write a function that prints the nodes
    //of the list in reverse order
    class ReverseLinkedList
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            node.next = new Node(2);
            node.next.next = new Node(3);
            node.next.next.next = new Node(4);
            PrintReverseLinkedList(node);
            Console.ReadKey();
        }
        public static void PrintReverseLinkedList(Node n)
        {
            if(n == null)
            {
                return;
            }
            PrintReverseLinkedList(n.next);
            Console.Write(n.value + " ");
        }
    }
    public class Node
    {
        public Node next;
        public int value;
        public Node(int _value)
        {
            this.value = _value;
        }
    }
}
