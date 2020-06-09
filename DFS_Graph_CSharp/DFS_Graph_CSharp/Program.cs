using System;
using System.Collections.Generic;

namespace DefthFirst
{
    internal class Program
    {
        public class Employee
        {
            public Employee(string name)
            {
                this.name = name;
            }

            public string name { get; set; }

            public List<Employee> Employees
            {
                get
                {
                    return EmployeesList;
                }
            }

            public void isEmployeeOf(Employee e)
            {
                EmployeesList.Add(e);
            }

            private List<Employee> EmployeesList = new List<Employee>();

            public override string ToString()
            {
                return name;
            }
        }

        public class DepthFirstAlgorithm
        {
            public Employee BuildEmployeeGraph()
            {
                Employee A = new Employee("A");
                Employee B = new Employee("B");
                Employee C = new Employee("C");
                A.isEmployeeOf(B);
                A.isEmployeeOf(C);

                Employee D = new Employee("D");
                Employee E = new Employee("E");
                Employee F = new Employee("F");
                Employee G = new Employee("G");
                B.isEmployeeOf(D);
                B.isEmployeeOf(F);
                C.isEmployeeOf(E);
                C.isEmployeeOf(G);

                return A;
            }

            public Employee Search(Employee root, string nameToSearchFor)
            {
                if (nameToSearchFor == root.name)
                    return root;

                Employee personFound = null;
                for (int i = 0; i < root.Employees.Count; i++)
                {
                    personFound = Search(root.Employees[i], nameToSearchFor);
                    if (personFound != null)
                        break;
                }
                return personFound;
            }

            public void Traverse(Employee root)
            {
                Console.WriteLine(root.name);
                for (int i = 0; i < root.Employees.Count; i++)
                {
                    Traverse(root.Employees[i]);
                }
            }
        }

        private static void Main(string[] args)
        {
            DepthFirstAlgorithm b = new DepthFirstAlgorithm();
            Employee root = b.BuildEmployeeGraph();
            Console.WriteLine("Traverse Graph\n------");
            b.Traverse(root);

            Console.WriteLine("\nSearch in Graph\n------");
            Employee e = b.Search(root, "A");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
            e = b.Search(root, "B");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
            e = b.Search(root, "Z");
            Console.WriteLine(e == null ? "Employee not found" : e.name);

            Console.Read();
        }
    }
}