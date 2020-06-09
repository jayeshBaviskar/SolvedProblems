using System;

namespace Contruct_Tree_using_Inorder_and_Preorder
{
    internal class Node
    {
        public char data;
        public Node right;
        public Node left;

        public Node(char data)
        {
            this.data = data;
            right = null;
            left = null;
        }
    }

    internal class TreeTest
    {
        private static char[] IN = { 'D', 'B', 'E', 'A', 'F', 'C' };
        private static char[] PRE = { 'A', 'B', 'D', 'E', 'C', 'F' };
        private static int preIndex = 0;

        public void PreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(" " + node.data);
            PreOrder(node.left);
            PreOrder(node.right);
        }

        public Node BuildTree(int instart, int inend)
        {
            if (instart > inend)
            {
                return null;
            }

            Node node = new Node(PRE[preIndex]);
            preIndex++;
            if (instart == inend)
            {
                return node;
            }

            int InIndex = GetIndexFromInorder(node.data);
            node.left = BuildTree(instart, InIndex - 1);
            node.right = BuildTree(InIndex + 1, inend);

            return node;
        }

        public int GetIndexFromInorder(char c)
        {
            int result = -1;
            for (int i = 0; i < IN.Length; i++)
            {
                if (IN[i] == c)
                {
                    result = i;
                }
            }

            return result;
        }

        private static void Main(string[] args)
        {
            TreeTest tree = new TreeTest();
            Node node = tree.BuildTree(0, IN.Length - 1);
            tree.PreOrder(node);

            Console.Read();
        }
    }
}