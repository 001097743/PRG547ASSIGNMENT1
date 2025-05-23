using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRG547ASSIGNMENT1
{
    class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; } = null;
        public Node<T> Right { get; set; } = null;
        public Node(T data) { Data = data; }
        public override string ToString() { return $"Data: {Data}, LeftNode: {Left}, Right Node: {Right};"; }
    }
    class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public bool Add(T data)
        {
            Node<T> before = null;
            Node<T> after = Root;

            while (!(after is null))
            {
                before = after;
                if (data.CompareTo(after.Data) < 0) after = after.Left;
                else if (data.CompareTo(after.Data) > 0) after = after.Right;
                else return false;
            }

            Node<T> temp = new Node<T>(data);

            if (Root is null) { Root = temp; }
            else
            {
                if (data.CompareTo(before.Data) < 0) before.Left = temp;
                else before.Right = temp;
            }

            return true;
        }

        public Node<T> Find(T data) { return Find(data, Root); }

        public Node<T> Find(T data, Node<T> parent)
        {
            if (parent != null)
            {
                if (data.Equals(parent.Data)) return parent;
                if (data.CompareTo(parent.Data) < 0) return Find(data, parent.Left);
                else return Find(data, parent.Right);
            }
            return null;
        }

        public int GetTreeDepth()
        {
            return GetTreeDepth(Root);
        }

        private int GetTreeDepth(Node<T> node)
        {
            return node == null ? 0 : Math.Max(GetTreeDepth(node.Left), GetTreeDepth(node.Right) + 1);
        }

        public void TraversePreOrder(Node<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Data + " ");
                TraversePreOrder(node.Left);
                TraversePreOrder(node.Right);
            }
        }

        public void TraverseInOrder(Node<T> node)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left);
                Console.WriteLine(node.Data + " ");
                TraverseInOrder(node.Right);
            }
        }

        public void TraversePostOrder(Node<T> node)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left);
                TraversePostOrder(node.Right);
                Console.WriteLine(node.Data + " ");
            }
        }

    }
}
