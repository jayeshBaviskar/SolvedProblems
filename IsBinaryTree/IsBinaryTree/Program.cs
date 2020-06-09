using System;
using System.Collections.Generic;

namespace IsBinaryTree
{
    public class Node
    {
        public int data = 0;
        public Node left = null;
        public Node right = null;

        public Node(int data)
        {
            this.data = data;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Refer URL https://static.javatpoint.com/ds/images/binary-search-tree.png

            #region init Tree

            Node root = new Node(30);
            Node n1 = new Node(15);
            Node n2 = new Node(60);
            Node n3 = new Node(7);
            Node n4 = new Node(22);
            Node n5 = new Node(17);
            Node n6 = new Node(27);
            Node n7 = new Node(45);
            Node n8 = new Node(75);

            root.left = n1;
            root.right = n2;

            n1.left = n3;
            n1.right = n4;

            n4.left = n5;
            n4.right = n6;

            n2.left = n7;
            n2.right = n8;

            #endregion init Tree

            bool result = isBST(root, int.MinValue, int.MaxValue);

            Console.WriteLine("IS BST: " + result.ToString());

            if (rootToLeafSum(root, 135))
            {
                Console.WriteLine("Root to Leaf Sum Exist\n");
                foreach (var item in resultList)
                {
                    Console.Write(" " + item);
                }
            }
            else
            {
                Console.WriteLine("Root to Leaf Sum does not Exist");
            }

            Console.WriteLine("");

            Console.WriteLine("Comman Accestor in BST : " + leastCommonAccestor(root, n1, n7));

         //   Console.WriteLine("Comman Accestor in BT: " + lcaInBinaryTree(root, n1, n7).data);

            //Console.Read();
        }

        public static bool isBST(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }
            if (root.data < min || root.data > max)
            {
                return false;
            }

            return isBST(root.left, min, root.data) && isBST(root.right, root.data, max);
        }


        private static int leastCommonAccestor(Node root, Node n1, Node n2)
        {
            if (root.data > max(n1, n2))
            {
                return leastCommonAccestor(root.left, n1, n2);
            }
            else if (root.data < min(n1,n2))
            {
                return leastCommonAccestor(root.right, n1, n2);
            }
            else
            {
                return root.data;
            }        
        }

        private static int max(Node n1, Node n2)
        {
            return n1.data > n2.data ? n1.data : n2.data;
        }

        private static int min(Node n1, Node n2)
        {
            return n1.data > n2.data ? n2.data : n1.data;
        }

        private static List<int> resultList = new List<int>();

        public static bool rootToLeafSum(Node root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            // Leaf Node
            if (root.left == null && root.right == null)
            {
                if (root.data == sum)
                {
                    resultList.Add(root.data);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (rootToLeafSum(root.left, sum - root.data))
            {
                resultList.Add(root.data);
                return true;
            }

            if (rootToLeafSum(root.right, sum - root.data))
            {
                resultList.Add(root.data);
                return true;
            }

            return false;
        }



        private static Node lcaInBinaryTree(Node root, Node n1, Node n2)
        {
            if(root == null)
            {
                return null ; 
            }

            if(root == n1 || root == n2)
            {
                return root;
            }

            Node left = lcaInBinaryTree(root.left, n1, n2);
            Node right = lcaInBinaryTree(root.right, n1, n2);

            if (left != null && right != null)
            {
                return root;
            }
            else if(left == null)
            {
                return right;
            }
            else if (right == null)
            {
                return left;
            }
            else
            {
                return null;
            }
        }
    }
}