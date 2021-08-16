using System;

namespace BST_Operations
{
    internal class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int value, Node left, Node right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }

    internal class BST
    {
        private Node rootNode = null;

        public Node GetRoot()
        {
            return rootNode;
        }

        public void SetRoot(Node node)
        {
            rootNode = node;
            Console.WriteLine("Root Value: " + node.value);
        }

        public Node CreateBST()
        {
            //              10
            //           /     \
            //          /       \
            //         /         \
            //        8            12
            //       / \           / \
            //      /   \         /   \
            //     /     \       /     \
            //     5      9     11     15
            //    /                     \
            //    3                      20

 
            Node node_20 = new Node(20, null, null);
            Node node_3 = new Node(3, null, null);
            Node node15 = new Node(15, null, node_20);
            Node node_11 = new Node(11, null, null);
            Node node_12 = new Node(12, node_11, node15);
            Node node_5 = new Node(5, node_3, null);
            Node node_9 = new Node(9, null, null);
            Node node_8 = new Node(8, node_5, node_9);
            Node node_10 = new Node(10, node_8, node_12);

            

            Console.WriteLine("Binary Search Tree Created with 9 Nodes!");

            SetRoot(node_10);

            return rootNode;
        }

        public void InOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            InOrderTraversal(node.left);
            Console.Write(node.value + " ");
            InOrderTraversal(node.right);
        }

        public void PostOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            PostOrderTraversal(node.left);
            PostOrderTraversal(node.right);
            Console.Write(node.value + " ");
        }

        public void PreOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.value + " ");
            PreOrderTraversal(node.left);
            PreOrderTraversal(node.right);
        }

        public int TreeSum(Node node)
        {
            if(node == null)
            {
                return 0;
            }

            int left = TreeSum(node.left);
            int right = TreeSum(node.right);

            return node.value + left + right;

        }

        public int TreeMax(Node node)
        {
            if(node == null)
            {
                return Int32.MinValue;
            }

            int left = TreeMax(node.left);
            int right = TreeMax(node.right);
            return Max(node.value, left, right);
        }

        public int TreeMin(Node node)
        {
            if(node == null)
            {
                return Int32.MaxValue;
            }

            int left = TreeMin(node.left);
            int right = TreeMin(node.right);
            return Min(node.value, left, right);
        }

        public int TreeHeight(Node node)
        {
            if(node == null)
            {
                return 0;
            }

            int left = TreeHeight(node.left);
            int right = TreeHeight(node.right);

            return 1 + Max(0, left, right);
        }


        public bool result = true;

        public int IsHeightbalanced(Node node)
        {
            if(node == null)
            {
                return 0;
            }

            int left = IsHeightbalanced(node.left);
            int right = IsHeightbalanced(node.right);

            if( Math.Abs(left - right) > 1)
            {
                result = result && false; 
            }

            return 1 + Max(0, left, right);

        }


        public bool Contains(Node node, int value)
        {
            if(node == null)
            {
                return false;
            }

            return node.value == value || Contains(node.left, value) || Contains(node.right, value); 
        }

        public void ReverseBST(Node node)
        {
            if(node == null)
            {
                return;
            }

            ReverseBST(node.left);
            ReverseBST(node.right);

            Node temp = node.left;
            node.left = node.right;
            node.right = temp;
        }

        private int Max(int value, int left, int right)
        {
            if ((value > left) && (value > right))
            {
                return value;
            }
            else if ((left > value) && ( left > right))
            {
                return left;
            }
            else
            {
                return right;
            }
        }


        private int Min(int value, int left, int right)
        {
            if ((value < left) && (value < right))
            {
                return value;
            }
            else if ((left < value) && (left < right))
            {
                return left;
            }
            else
            {
                return right;
            }
        }

    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("BST Operations");
            BST bst = new BST();
            bst.CreateBST();

            Console.WriteLine("In Order Traversal: ");
            bst.InOrderTraversal(bst.GetRoot());
            
            Console.WriteLine();
            bst.PreOrderTraversal(bst.GetRoot());
            Console.WriteLine();
            bst.PostOrderTraversal(bst.GetRoot());
            Console.WriteLine();
            Console.WriteLine("Tree Sum " + bst.TreeSum(bst.GetRoot()));
            Console.WriteLine("Tree MAX " + bst.TreeMax(bst.GetRoot()));
            Console.WriteLine("Tree Min " + bst.TreeMin(bst.GetRoot()));
            Console.WriteLine("Tree Height " + bst.TreeHeight(bst.GetRoot()));
            Console.WriteLine("10 Contains: " + bst.Contains(bst.GetRoot(), 10));
            Console.WriteLine("25 Contains: " + bst.Contains(bst.GetRoot(), 25));
            Console.WriteLine("20 Contains: " + bst.Contains(bst.GetRoot(), 20));

            bst.ReverseBST(bst.GetRoot());

            Console.WriteLine("In Order Traversal: ");
            bst.InOrderTraversal(bst.GetRoot());

            bst.IsHeightbalanced(bst.GetRoot());
            Console.WriteLine("Is Tree Height Balanced: " +  bst.result);
            
        }
    }
}