using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLevelOrder
{
    //Given a tree, write a function that prints out the nodes
    //of the tree in level order
    //                         1
    //                   2           3
    //                4    5       6   7
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.leftChild = new Node(2);
            root.rightChild = new Node(3);
            root.leftChild.leftChild = new Node(4);
            root.leftChild.rightChild = new Node(5);
            root.rightChild.leftChild = new Node(6);
            root.rightChild.rightChild = new Node(7);
            TraverseBFS(root);
            Console.ReadKey();
        }
        public static void TraverseBFS(Node tree)
        {
            if(tree == null)
            {
                return;
            }
            Queue<Node> treeQueue = new Queue<Node>();
            treeQueue.Enqueue(tree);
            while (treeQueue.Count > 0)
            {
                Node currentNode = treeQueue.Dequeue();
                Console.WriteLine(currentNode.value);
                if(currentNode.leftChild != null)
                {
                    treeQueue.Enqueue(currentNode.leftChild);
                }
                if(currentNode.rightChild != null)
                {
                    treeQueue.Enqueue(currentNode.rightChild);
                }
            }
        }
    }
    class Node
    {
        public int value;
        public Node leftChild;
        public Node rightChild;
        public Node(int _value)
        {
            this.value = _value;
            leftChild = rightChild = null;
        }
    }
}
