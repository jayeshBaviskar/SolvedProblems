using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_using_CSharp
{
    public class Node
    {
        public int data;
        public Node right;
        public Node left;

        public Node(int d)
        {
            data = d;
            right = null;
            left = null;
        }
    }
    class BinaryTree
    {
        Node root;

        bool isBST()
        {
            return isBSTUntil(root, int.MinValue, int.MaxValue);
        }

        bool isBSTUntil(Node node, int min, int max)
        {
            // Empty Tree is a BST
            if(node == null)
            {
                return true;
            }

            
            if(node.data < min || node.data > max)
            {
                return false;
            }

            return ( isBSTUntil(node.left, min, node.data-1) &&
                     isBSTUntil(node.right, node.data+1, max));

        }

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(4);
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);
 
            if (tree.isBST())
                Console.WriteLine("IS BST");
            else
                Console.WriteLine("Not a BST");

            Console.Read();
        }
    }
}
