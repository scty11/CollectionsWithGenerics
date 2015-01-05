using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee[] employees = new Employee[] { new Employee() { Name = "Scott" } };
            ////can resize the array if you need it bigger to add items.
            ////not very efficient.
            //Array.Resize(ref employees, 2);

            ////puts an intil capicity, but it grows as nessecary.
            //List<Employee> lisEmploy = new List<Employee>(10) { new Employee() { Name = "Scott" } };

            //fifo
            Queue<Employee> queue = new Queue<Employee>();
            queue.Enqueue(new Employee() { Name = "Scott" });
            queue.Enqueue(new Employee() { Name = "Lee" });

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue().Name);
            }

            Console.WriteLine("--");
            //lifo
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee() { Name = "Scott" });
            stack.Push(new Employee() { Name = "Lee" });

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop().Name);
            }


            HashSet<int> set = new HashSet<int>() { 1, 2 };
            //returns a boolean if it was added.
            set.Add(2);

            foreach (var item in set)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("--");
            LinkedList<int> link = new LinkedList<int>();
            //returns a boolean if it was added.
            link.AddFirst(1);
            link.AddBefore(link.Find(1), 2);

            foreach (var item in link)
            {
                Console.WriteLine(item.ToString());
            }

            var node = link.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }




            var employeesByName = new SortedList<string, List<Employee>>();

            //employeesByName.Add("Sales", new List<Employee> { new Employee(), new Employee(), new Employee() });
            //employeesByName.Add("Engineering", new List<Employee> { new Employee(), new Employee() });

            //foreach (var item in employeesByName)
            //{
            //    Console.WriteLine("The count of employees for {0} is {1}", 
            //                item.Key, item.Value.Count
            //            );
            //}
            Console.ReadKey();
        }
    }
}
