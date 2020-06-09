using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal_Using_C_Sharp
{
    public class Node
    {
        public Node right;
        public Node left;
        public int data;

        public Node(int d)
        {
            data = d;
            right = null;
            left = null;
        }
    }
    class BinaryTree
    {
        Node root = null;

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(4);
            tree.root.left = new Node(2);
            tree.root.right = new Node(15);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);  
      
            tree.InOrder(tree.root);

            Console.Read();
        }


        public void InOrder(Node node)
        {
            if(node!= null)
            {
                InOrder(node.left);
                Console.Write(" " + node.data);
                InOrder(node.right);
            }
        }
    }
}
