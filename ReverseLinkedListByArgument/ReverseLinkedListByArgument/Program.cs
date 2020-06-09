using System;
using System.Collections.Generic;

internal class LList
{
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

    public Node reverseByCount(Node head, int k)
    {
        Node node = head;
        head = null;
        Node current = null;

        Stack<Node> s = new Stack<Node>();
        while (node != null)
        {
            for (int i = 0; i < k && node != null; i++)
            {
                s.Push(node);
                node = node.next;
            }

            while (s.Count != 0)
            {
                if (head == null)
                {
                    current = head = s.Pop();
                }
                else
                {
                    current.next = s.Pop();
                    current = current.next;
                }
            }
        }

        current.next = null;
        return head;
    }

    private static void Main(string[] args)
    {
        LList obj = new LList();
        Node head = obj.FillLinkedList();
        obj.PrintList(head);

        Console.WriteLine("-------------------");
        head = obj.reverseByCount(head, 3);
        obj.PrintList(head);

        Console.Read();
    }

    public Node FillLinkedList()
    {
        Node n1 = new Node(50, null);
        Node n2 = new Node(40, n1);
        Node n3 = new Node(30, n2);
        Node n4 = new Node(20, n3);
        Node n5 = new Node(10, n4);
        return n5;
    }

    public void PrintList(Node head)
    {
        while (head != null)
        {
            Console.Write(head.data + " ");
            head = head.next;
        }
    }
}