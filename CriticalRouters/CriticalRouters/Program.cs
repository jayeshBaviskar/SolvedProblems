using System;
using System.Collections.Generic;

namespace CriticalRouters
{
    public class FindingCriticalConnections
    {
        private List<List<int>> connections;

        public List<List<int>> init()
        {
            connections = createDummyData();
            DisplayDummyData(connections);
            return connections;
        }

        private static void Main(String[] args)
        {
            CriticalConnectionClass o = new CriticalConnectionClass(); // Critical Edge
            FindingCriticalConnections con = new FindingCriticalConnections();


            //List<List<int>> roads =  con.init();
            //for (int i = 0; i < roads.Count; i++)
            //{
            //    --roads[i][0];
            //    --roads[i][1];
            //    Console.Write(" " + roads[i][0] + "-" + roads[i][1]);


            //}

            //Console.Write("-----------");


            List<List<int>> result = o.CriticalConnections(5, con.init());

            Console.WriteLine("--------CRITICAL CONNECTIONS -------");
            foreach (List<int> item in result)
            {
                foreach (int value in item)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
                Console.WriteLine("---------------");
            }


            CriticalPointsClass.GetCriticalPoints();

            Console.Read();
        }

        public class Graph
        {
            private int v;
            /**
             * This set will be working as adjacency list.
             */
            public HashSet<int>[] connections;

            /**
             * Create a graph data structure
             */
        }

        private void DisplayDummyData(List<List<int>> lst)
        {
            Console.WriteLine("------------DATA--------------");

            foreach (var lst1 in lst)
            {
                foreach (var lst2 in lst1)
                {
                    Console.Write(lst2 + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------");
        }

        private List<List<int>> createDummyData()
        {
            List<List<int>> connections = new List<List<int>>();
            List<int> con1 = new List<int>();
            con1.Add(1);
            con1.Add(2);
            connections.Add(con1);

            List<int> con2 = new List<int>();
            con2.Add(1);
            con2.Add(3);
            connections.Add(con2);

            List<int> con3 = new List<int>();
            con3.Add(3);
            con3.Add(4);
            connections.Add(con3);
            

            return connections;
        }
    }
}