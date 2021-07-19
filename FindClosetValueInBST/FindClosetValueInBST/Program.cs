using System;

namespace FindClosetValueInBST
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var root = new Program.BST(10);
            root.left = new Program.BST(5);
            root.left.left = new Program.BST(2);
            root.left.left.left = new Program.BST(1);
            root.left.right = new Program.BST(5);
            root.right = new Program.BST(15);
            root.right.left = new Program.BST(13);
            root.right.left.right = new Program.BST(14);
            root.right.right = new Program.BST(22);

            Console.WriteLine (FindClosestValueInBst(root, 12));
        }

        public static int FindClosestValueInBst(BST tree, int target)
        {
            // Write your code here.
            if (tree == null)
            {
                return -1;
            }

            int diff = getDifference(tree.value, target);
            int diffValue = tree.value;

            while (tree != null)
            {
                int left = Int32.MaxValue;
                int right = Int32.MaxValue;
                if (tree.left != null)
                {
                    left = getDifference(tree.left.value, target);
                }

                if (tree.right != null)
                {
                    right = getDifference(tree.right.value, target);

                }

                if (left < right)
                {
                    if (diff < left)
                    {
                        return diffValue;
                    }
                    tree = tree.left;
                    diff = left;
                    diffValue = tree.value;
                }
                else
                {
                    if (diff < right)
                    {
                        return diffValue;
                    }
                    tree = tree.right;
                    diff = right;
                    diffValue = tree.value;
                }
            }

            return diffValue;
        }

        public static int getDifference(int num1, int num2)
        {
            return (num1 - num2) > 0 ? (num1 - num2) : ((num1 - num2) * -1);
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }
    }
}