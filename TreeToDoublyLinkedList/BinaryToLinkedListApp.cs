using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeToDoublyLinkedList
{
    //Given a tree, write a function to convert it into a
    //circular doubly linked list from left to right by
    //only modifying the existing pointers.
    class BinaryToLinkedListApp
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Insert(4);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(7);
            Node resultNode = tree.TreeToList(tree.root);
            do
            {
                Console.Write(resultNode.value);
                resultNode = resultNode.right;
            } while (resultNode != tree.root);
            Console.ReadKey();
        }
    }
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        //public Node(int iData)
        //{
        //    value = iData;
        //    left = null;
        //    right = null;
        //}

        public Node Concatenate(Node a, Node b)
        {
            if (a == null)
            {
                return b;
            }
            if (b == null)
            {
                return a;
            }
            Node aEnd = a.left;
            Node bEnd = b.left;
            a.left = bEnd;
            bEnd.right = a;
            aEnd.right = b;
            b.left = aEnd;
            return a;
        }


    }
    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.value = id;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.value)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }

        }
        public Node TreeToList(Node n)
        {
            if (n == null)
            {
                return n;
            }
            Node leftList = TreeToList(n.left);
            Node rightList = TreeToList(n.right);
            n.left = n;
            n.right = n;
            n.Concatenate(leftList, n);
            n.Concatenate(n, rightList);
            return n;
        }
    }
}
