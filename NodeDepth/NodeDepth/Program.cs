using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NodeDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Program.BinaryTree(1);
            root.left = new Program.BinaryTree(2);
            root.left.left = new Program.BinaryTree(4);
            root.left.left.left = new Program.BinaryTree(8);
            root.left.left.right = new Program.BinaryTree(9);
            root.left.right = new Program.BinaryTree(5);
            root.right = new Program.BinaryTree(3);
            root.right.left = new Program.BinaryTree(6);
            root.right.right = new Program.BinaryTree(7);
            int actual = Program.NodeDepths(root);
            Console.WriteLine(actual);

        }


        public static int NodeDepths(BinaryTree root)
        {
           
            return checkDepth(root, 0);
        }

        public static int checkDepth(BinaryTree node, int depth)
        {
            if(node==null)
            {
                return depth;
            }

            depth = checkDepth(node.left, depth + 1);
            depth = checkDepth(node.right, depth + 1);

            return depth;
        }
        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }
    }
}
