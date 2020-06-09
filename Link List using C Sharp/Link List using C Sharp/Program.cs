using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_List_using_C_Sharp
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class LinkListTest
    {
        Node head = null;

        static void Main(string[] args)
        {
            LinkListTest list = new LinkListTest();

            list.insertList(1);
            list.insertList(2);
            list.insertList(3);            
            list.insertList(2);
            list.insertList(1);
            list.printList();


            Console.WriteLine("");
            if(list.isPalidrome())
            {
                Console.Write("Palidrome");
            }
            else
            {
                Console.Write("Not a Palidrome");
            }

            Console.Read();
        }



        public bool isPalidrome()
        {
            if(head==null)
            {
                return true;
            }

            Node FastPtr = head;
            Node SlowPtr = head;

            while (FastPtr.next != null )
            {
                if (FastPtr.next.next == null)
                {
                    break;
                }
                SlowPtr = SlowPtr.next;
                FastPtr = FastPtr.next.next;
            }

            if(FastPtr.next == null)
            {
                FastPtr = SlowPtr.next;
                SlowPtr.next = null;
            }
            else if (FastPtr.next.next == null)
            {
                SlowPtr.next.next = null;
                Node temp = SlowPtr.next;
                SlowPtr.next = null;

                SlowPtr = temp;
            }

            
            while (FastPtr.next != null)
            {
                Node temp = SlowPtr;
                SlowPtr = FastPtr;
                FastPtr = FastPtr.next;
                SlowPtr.next = temp;
            }
            FastPtr.next = SlowPtr;

            SlowPtr = head;

            while (SlowPtr != null || FastPtr != null)
            {
                if(SlowPtr.data != FastPtr.data)
                {
                    return false;
                }

                SlowPtr = SlowPtr.next;
                FastPtr = FastPtr.next;
            }

            if(SlowPtr == null && FastPtr == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void insertList(int data)
        {
            Node temp = new Node(data);
            if(head == null)
            {
                
                head = temp;
                Console.WriteLine(" Data added into the Head " + data);
            }
            else
            {
                Node tempHead = head;
                while (tempHead.next != null)
                {
                    tempHead = tempHead.next;
                }

                tempHead.next = temp;
                Console.WriteLine(" Data added at the End " + data);
            }
        }


        public void printList()
        {
            Node tempHead = head;
            if(tempHead == null)
            {
                Console.Write(" List is Empty");
            }
            else
            {
                Console.Write(" " + tempHead.data);
                while (tempHead.next != null)
                {
                    tempHead = tempHead.next;
                    Console.Write(" " + tempHead.data);
                }
            }
           

            
        }

        

    }
}
