using System;

namespace Height_of_BinaryTree
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    internal class BinaryTree
    {

        Node root;

        int maxDepth(Node node)
        {
            if(node==null)
            {
                return 0;
            }
            else
            {
                int lheight = maxDepth(node.left);
                int rheight = maxDepth(node.right);

                if(lheight>rheight)
                {
                    return lheight + 1;
                }
                else
                {
                    return rheight + 1;
                }
            }
        }
        private static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Height of tree is : " +
                                        tree.maxDepth(tree.root));
        }
    }
}