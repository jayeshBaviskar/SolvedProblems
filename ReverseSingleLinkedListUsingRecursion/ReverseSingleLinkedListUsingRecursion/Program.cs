using System;

namespace ReverseSingleLinkedListUsingRecursion
{
    internal class Program
    {
        public static Node newHead = null;
        public static Node current = null;

        public static void printInReverse(Node head)
        {
            if (head == null)
                return;

            printInReverse(head.next);
            if (newHead == null)
            {
                newHead = current = head;
            }
            else
            {
                current.next = head;
                current = current.next;
            }
        }

        private static void Main(string[] args)
        {
            Node head = FillLinkedList();
            PrintList(head);

            Console.WriteLine("----------------");

            printInReverse(head);
            current.next = null;

            PrintList(newHead);

            Console.Read();
        }

        public class Node
        {
            public int data;
            public Node next;

            public Node(int data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }

        public static Node FillLinkedList()
        {
            Node n1 = new Node(50, null);
            Node n2 = new Node(40, n1);
            Node n3 = new Node(30, n2);
            Node n4 = new Node(20, n3);
            Node n5 = new Node(10, n4);
            return n5;
        }

        public static void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
    }
}