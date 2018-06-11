using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeKSortedArrays
{
    class MergeKSortedArraysApp
    {
        static void Main(string[] args)
        {

        }
    }

    public class QueNode : IComparable<QueNode>
    {
        int array, index, value;
        public QueNode(int array, int index, int value)
        {
            this.array = array;
            this.index = index;
            this.value = value;
        }
        public int CompareTo(QueNode n)
        {
            if(value > n.value)
            {
                return 1;
            }
            if (value < n.value)
            {
                return -1;
            }
            return 0;
        }

        public int[] Merge(int[,] arrays)
        {
            Queue<QueNode> pq = new Queue<QueNode>();
            int size = 0;
            for(int i = 0; i< arrays.Length; i++)
            {
                size += arrays.GetLength(i);
                if (arrays.GetLength(i) > 0)
                {
                    pq.Enqueue(new QueNode(i,0,arrays[i,0]));
                }
            }
            int[] result = new int[size];
            for(int i = 0; pq.Count != 0; i++)
            {
                QueNode n = pq.Dequeue();
                result[i] = n.value;
                int newIndex = n.index + 1;
                if(newIndex < arrays.GetLength(n.array))
                {
                    pq.Enqueue(new QueNode(n.array, newIndex,
                        arrays[n.array, newIndex]));
                }
            }
            return result;
        }
    }
}
