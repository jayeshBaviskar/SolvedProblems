using System;

namespace Heap
{
    internal class Program
    {
        private static int[] Heap = new int[0]; // Heap of Size 10

        private static void Insert(int element, int atIndex)
        {
            Array.Resize(ref Heap, Heap.Length + 1);
            if (atIndex == 0) // If this is the First Element
            {
                Heap[0] = element;
                return;
            }

            Heap[atIndex] = element; // Element Inserted at last Position

            int index = atIndex;
            while (index > 0 && Heap[index] > Heap[(index - 1) / 2])
            {
                Swap(index, (index - 1) / 2);
                index = (index - 1) / 2;
            }
        }

        private static void Delete()
        {
            if (Heap.Length == 0)
            {
                Console.WriteLine("Heap is Empty, Cannot Delete");
                return;
            }

            int deletedValue = Heap[0];
            Heap[0] = Heap[Heap.Length - 1];
            Array.Resize(ref Heap, Heap.Length - 1);
            int index = 0;
            int left = (index * 2) + 1;
            int right = (index * 2) + 2;

            while (left < Heap.Length - 1)
            {
                if (right <= Heap.Length - 1)
                {
                    if (Heap[left] > Heap[right]) // is Left or right Child is Greater?
                    {
                        Swap(index, left);
                        index = left;
                    }
                    else // Right Child is Greater
                    {
                        Swap(index, right);
                        index = right;
                    }
                }
                else
                {
                    Swap(index, left);
                    index = left;
                }

                left = (index * 2) + 1;
                right = (index * 2) + 2;
            }

            Console.WriteLine("\n Deleted Item: " + deletedValue);
        }

        private static void Swap(int index1, int index2)
        {
            int temp = Heap[index1];
            Heap[index1] = Heap[index2];
            Heap[index2] = temp;
        }

        private static void Main(string[] args)
        {
            Insert(40, Heap.Length);
            Insert(50, Heap.Length);
            Insert(30, Heap.Length);
            Insert(60, Heap.Length);

            for (int i = 0; i < Heap.Length; i++)
            {
                Console.Write(Heap[i] + " ");
            }

            Delete();
            Display();

            Console.Read();
        }

        private static void Display()
        {
            for (int i = 0; i < Heap.Length; i++)
            {
                Console.Write(Heap[i] + " ");
            }
        }
    }
}