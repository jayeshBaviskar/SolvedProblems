using System.Collections.Generic;
using System;
namespace Depth_First_Search
{
    internal class Program
    {
        public class Node
        {
            public string name;
            public List<Node> children = new List<Node>();

            public Node(string name)
            {
                this.name = name;
            }

            public Node AddChild(string name)
            {
                Node child = new Node(name);
                children.Add(child);
                return this;
            }

            public List<string> DepthFirstSearch(List<string> array)
            {
                array = RecursiveDeapthSearch( array);
                return array;
                
            }

            public List<string> RecursiveDeapthSearch(List<string> array)
            {
                array.Add(name);
                foreach (Node node in children)
                {
                    node.RecursiveDeapthSearch(array);
                }
                return array;
            }

            private static void Main(string[] args)
            {
                Program.Node graph = new Program.Node("A");
                graph.AddChild("B").AddChild("C").AddChild("D");
                graph.children[0].AddChild("E").AddChild("F");
                graph.children[2].AddChild("G").AddChild("H");
                graph.children[0].children[1].AddChild("I").AddChild("J");
                graph.children[2].children[0].AddChild("K");
                string[] expected = { "A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H" };
                List<string> inputArray = new List<string>();
                List<string> result =  graph.DepthFirstSearch(inputArray);
                Console.WriteLine(result.ToString());

            }
        }
    }
}