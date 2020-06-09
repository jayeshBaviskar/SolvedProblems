using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create graphs given in above diagrams 
            System.out.println("Bridges in first graph ");
            Graph g1 = new Graph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(2, 1);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);
            g1.bridge();
            System.out.println();

            System.out.println("Bridges in Second graph");
            Graph g2 = new Graph(4);
            g2.addEdge(0, 1);
            g2.addEdge(1, 2);
            g2.addEdge(2, 3);
            g2.bridge();
            System.out.println();

            System.out.println("Bridges in Third graph ");
            Graph g3 = new Graph(7);
            g3.addEdge(0, 1);
            g3.addEdge(1, 2);
            g3.addEdge(2, 0);
            g3.addEdge(1, 3);
            g3.addEdge(1, 4);
            g3.addEdge(1, 6);
            g3.addEdge(3, 5);
            g3.addEdge(4, 5);
            g3.bridge();
        }
    }
}
