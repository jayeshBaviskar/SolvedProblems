using System;

namespace HamiltonianAlgorithm_using_C_Sharp
{
    internal class Hamiltonian
    {
        /*
            (0) ---------- (1)
             |              |
             |              |
             |              |
            (3)------------(2)

         */

        private static void Main(string[] args)
        {
            int[,] adjacencyMatrix = new int[4, 4] {
                                                {0,1,0,1},
                                                {1,0,1,0},
                                                {0,1,0,1},
                                                {1,0,1,0}};

            Hamiltonian obj = new Hamiltonian();
            obj.HamiltonianCycle(adjacencyMatrix);
        }

        private int numOfVertexes;
        private int[] hamiltonianPath;
        private int[,] adjancencyMatrix;

        private void HamiltonianCycle(int[,] adjancencyMatrix)
        {
            this.adjancencyMatrix = adjancencyMatrix;
            numOfVertexes = adjancencyMatrix.GetLength(0);
            hamiltonianPath = new int[numOfVertexes];

            hamiltonianPath[0] = 0;

            if (!FindFeasibleSolution(1))
            {
                Console.WriteLine("No Feasible Solution Found!");
            }
            else
            {
                DisplayPath();
            }
        }

        private bool FindFeasibleSolution(int position)
        {
            if (position == numOfVertexes)
            {
                if (adjancencyMatrix[hamiltonianPath[position - 1], hamiltonianPath[0]] == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int vertextIndex = 0; vertextIndex < numOfVertexes; vertextIndex++)
            {
                if (isFeasible(vertextIndex, position + 1))
                {
                    hamiltonianPath[position] = vertextIndex;
                    if (FindFeasibleSolution(position + 1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool isFeasible(int vertexIndex, int position)
        {
            // Whether Two Nodes are Connected
            if (adjancencyMatrix[hamiltonianPath[(position - 1)], vertexIndex] == 0)
            {
                return false;
            }

            for (int i = 0; i < position; i++)
            {
                if (hamiltonianPath[i] == vertexIndex)
                {
                    return false;
                }
            }

            return true;
        }

        private void DisplayPath()
        {
            for (int i = 0; i < hamiltonianPath.Length; i++)
            {
                Console.Write(" " + hamiltonianPath[i]);
            }

            Console.Read();
        }
    }
}