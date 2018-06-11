using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Given a binary tree, write a function to test if the
    //tree is a binary search tree
    /* Left node key is less than the parent node key
     * Right node key is greater than the parent node key
     * Each left and rigt subtree is also a binary search tree*/

    class BinarySearchTreeApp
    {
        static void Main(string[] args)
        {
            Tree binaryTree = new Tree();
            binaryTree.root = new Node(5);
            binaryTree.root.leftChild = new Node(2);
            binaryTree.root.leftChild.leftChild = new Node(1);
            binaryTree.root.leftChild.rightChild = new Node(3);
            binaryTree.root.rightChild = new Node(7);
            binaryTree.root.rightChild.leftChild = new Node(6);
            binaryTree.root.rightChild.rightChild = new Node(8);
            if (binaryTree.IsBST())
            {
                Console.WriteLine("IS BST");
            }
            else
            {
                Console.WriteLine("Not a BST");
            }
            Console.ReadLine();
        }
    }
    class Node
    {
        public int iData;
        public Node leftChild;  //this node's left child
        public Node rightChild; //this node's right child
        public Node(int value)
        {
            iData = value;
            leftChild = rightChild = null;
        }
    }

    class Tree
    {
        public Node root;       //Root of the Biary Tree
        //Return true if given search tree is BST
        public bool IsBST()
        {
            return IsBST(root, Int32.MinValue, Int32.MaxValue);
        }

        private bool IsBST(Node node, int minVal, int maxVal)
        {
            //An empty tree is BST
            if(node == null)
            {
                return true;
            }
            //false if this node violates the min/max constraints
            if(node.iData < minVal || node.iData > maxVal)
            {
                return false;
            }
            //otherwise check the subtrees recursivly
            //tightening the min/max constraints
            //Allow only distinct values
            return (IsBST(node.leftChild, minVal, node.iData - 1) &&
                IsBST(node.rightChild, node.iData + 1, maxVal));

        }
    }
}
