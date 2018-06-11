using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinTree
{
    //Given a binary tree, write a function to determine 
    //whether the tree is balanced
    //To be a balanced tree the difference in height should
    //no more than 1
    /*
     *                      1
     *                 2          3
     *            4           6       7   
    */
    class BalancedBinTreeApp
    {
        static void Main(string[] args)
        {
            Node rootNode = new Node(1);
            rootNode.left = new Node(2);
            rootNode.left.left = new Node(4);
            rootNode.right = new Node(4);
            rootNode.right.right = new Node(4);
            bool result = IsBalanced(rootNode);
            Console.WriteLine($"Is the binary tree balanced? {result}");
            Console.ReadKey();
        }

        public static bool IsBalanced(Node root)
        {
            if(BalancedHeight(root) > -1)
            {
                return true;
            }
            return false;
        }
        public static int BalancedHeight(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            int h1 = BalancedHeight(root.left);
            int h2 = BalancedHeight(root.right);
            if(h1 == -1|| h2 == -1)
            {
                return -1;
            }
            if (Math.Abs(h1 - h2) > 1)
            {
                return -1;
            }
            if (h1 > h2)
            {
                return h1 + 1;
            }
            return h2 + 1;

        }
    }
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int _value)
        {
            this.value = _value;
        }
    }
}
