using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace verify_bst
{
    // verifies a binary tree is bst
    // bst => a tree whose left subtree <= root, right subtree > root.
    // if we do in-order traversal, it will be sorted list
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            //tree.Insert(10);
            //tree.Insert(5);
            //tree.Insert(2);
            //tree.Insert(7);
            //tree.Insert(3);

            //tree.Insert(20);
            //tree.Insert(15);
            //tree.Insert(18);

            //tree.Inorder();

            tree.Insert(1);
            tree.Insert(5);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(3);

            tree.Insert(20);
            tree.Insert(15);
            tree.Insert(18);

            tree.Inorder();

            Console.WriteLine("Is Binary Search tree => {0}", tree.IsBST());
        }
    }

    public class BinaryTree
    {
        public BinaryTree()
        {
            m_root = null;
        }

        class Node
        {
            public Node(int val)
            {
                Value = val;
                LeftNode = RightNode = null;
            }

            internal int Value;
            internal Node LeftNode;
            internal Node RightNode;
        }

        private void TryInsert(ref Node node, int val)
        {
            if (node == null)
            {
                node = new Node(val); return;
            }
            
            else if (val <= node.Value) TryInsert(ref node.LeftNode, val);
            
            else TryInsert(ref node.RightNode, val);
        }

        public void Insert(int val)
        {
            TryInsert(ref m_root, val);
        }

        private void TryInorder(Node node)
        {
            if (node == null) return;
            TryInorder(node.LeftNode);
            Console.WriteLine("{0}", node.Value);
            TryInorder(node.RightNode);
        }

        public void Inorder()
        {
            TryInorder(m_root);
        }

        private bool TryIsBST(Node node, int minVal, int maxVal)
        {
            if (node == null) return true;

            if (node.Value < minVal) return false;

            else if (node.Value > maxVal) return false;

            return TryIsBST(node.LeftNode, minVal, node.Value) && TryIsBST(node.RightNode, node.Value, maxVal);
        }

        public bool IsBST()
        {
            return TryIsBST(m_root, int.MinValue, int.MaxValue); 
        }

        private Node m_root;
    }
}
