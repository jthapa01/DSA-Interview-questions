using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromesTest
{
    //Given a Linked List, write a function to determine
    //whether the list is palindrome
    //1 -> 2 -> 2 -> 1
    //1 -> 2 -> 3 -> 2 -> 1
    class PalindromeApp
    {
        static void Main(string[] args)
        {
            Link node = new Link(1);
            node.next = new Link(2);
            node.next.next = new Link(3);
            node.next.next.next = new Link(3);
            node.next.next.next.next = new Link(2);
            node.next.next.next.next.next = new Link(1);
            bool result = IsPlaindrome(node);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        public static bool IsPlaindrome(Link n)
        {
            Link currentCursor = n;
            Link forwardCursor = n;
            Stack<int> stack = new Stack<int>();
            while (forwardCursor != null && forwardCursor.next != null)
            {
                stack.Push(currentCursor.value);
                currentCursor = currentCursor.next;
                forwardCursor = forwardCursor.next.next;

            }
            if (forwardCursor != null)
            {
                currentCursor = currentCursor.next;
            }
            while (currentCursor != null)
            {
                if (stack.Pop() != currentCursor.value)
                {
                    return false;
                }
                currentCursor = currentCursor.next;
            }
            return true;
        }

    }

    class Link
    {
        public Link next;
        public int value;
        public Link(int _value)
        {
            value = _value;
        }
    }
}
