using System;
using System.Collections.Generic;
using System.Linq;

namespace DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();
            keyValuePairs.Add(1, new List<int>() { 4, 2 });
            keyValuePairs.Add(4, new List<int>() { 3, 1 });
            keyValuePairs.Add(2, new List<int>() { 3, 1, 5, 7, 8 });
            keyValuePairs.Add(3, new List<int>() { 2, 4, 9, 10 });
            keyValuePairs.Add(5, new List<int>() { 2, 6, 8, 7 });
            keyValuePairs.Add(8, new List<int>() { 2, 5, 7 });
            keyValuePairs.Add(7, new List<int>() { 2, 5, 8 });
            keyValuePairs.Add(6, new List<int>() { 5 });
            keyValuePairs.Add(9, new List<int>() { 3 });
            keyValuePairs.Add(10, new List<int>() { 3 });
            Program p = new Program();
            p.DFS(keyValuePairs);
            Console.WriteLine("Hello World!");
        }

        public void DFS(Dictionary<int, List<int>> keyValuePairs)
        {
            HashSet<int> visited = new HashSet<int>();
            Stack<int> s = new Stack<int>();

            int node = keyValuePairs.ElementAt(0).Key;
            s.Push(node);
            visited.Add(node);

            while(s.Count > 0)
            {
                int element = s.Pop();
                Console.WriteLine(element);

                List<int> childrens;
                keyValuePairs.TryGetValue(element, out childrens);

                foreach(int child in childrens)
                {
                    if (!visited.Contains(child))
                    {
                        visited.Add(child);
                        s.Push(child);
                    }
                }
            }
        }
    }
}
