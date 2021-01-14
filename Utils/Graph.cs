using System;
using System.Collections.Generic;

namespace IK.Utils
{
    public class Graph
    {
        public Dictionary<int, List<int>> AdjacencyList { get; set; }
        private int Verticies { get; set; }
        private int[] VisitedAry { get; set; }
        private List<int> VisitedList { get; set; }
        private List<int> ParentList { get; set; }

        // Constructor - creates an empty Adjacency List
        public Graph(int verticies)
        {
            AdjacencyList = new Dictionary<int, List<int>>();
            Verticies = verticies;
            VisitedAry = new int[verticies];
            VisitedList = new List<int>();
            ParentList = new List<int>();
        }

        // Appends a new Edge to the linked list
        public void addEdge(int startVertex, int endVertex, bool bidir = true)
        {
            if (!AdjacencyList.ContainsKey(startVertex))
            {
                AdjacencyList[startVertex] = new List<int>();
            }

            AdjacencyList[startVertex].Add(endVertex);

            if (bidir == true)
            {
                if (!AdjacencyList.ContainsKey(endVertex))
                {
                    AdjacencyList[endVertex] = new List<int>();

                }

                AdjacencyList[endVertex].Add(startVertex);
            }
        }

        public bool HasEulerianCycle()
        {
            int odd = 0;//no. of verticies with odd degree
            foreach (var vertex in AdjacencyList)
            {
                if (AdjacencyList.Values.Count / 2 == 1)
                    odd++;

            }
            if (odd == 0)
                return true;
            else
                return false;
        }

        public bool HasEulerianPath()
        {
            int odd = 0;//no. of verticies with odd degree
            foreach (var vertex in AdjacencyList)
            {
                if (AdjacencyList.Values.Count / 2 == 1)
                    odd++;

            }
            if (odd == 0 || odd == 2)
                return true;
            else
                return false;
        }


        public void buildAdjacencyList(int[][] edges)
        {
            //for(var adLs in graph.AdjacencyList)
            for (int i = 0; i < Verticies; i++)
            {
                AdjacencyList.Add(i, new List<int>());
            }

            for (int i = 0; i < edges.Length; i++)
            {

                addEdge(edges[i][0], edges[i][1]);
            }
        }
        /// <summary>
        /// This DFS uses the c parameter to
        /// keep track of the number of connected components
        /// </summary>
        /// <param name="source">The verticies</param>
        /// <param name="c">the connected component tag</param>
        public void DFS(int source, int c)
        {
            VisitedAry[source] = c;
            foreach (int w in AdjacencyList[source])
            {
                if (VisitedAry[w] == 0)
                    DFS(w, c);
            }

        }

        public int findComponents()
        {
            int component = 0;
            for (int i = 1; i <= Verticies; i++)
            {
                if (VisitedAry[i] == 0)
                {
                    component++;
                    DFS(i, component);
                }
            }

            return component;
        }

        public void BFS(int node)
        {

            var queue = new Queue<int>();
            queue.Enqueue(node);
            VisitedList.Add(node);
            while (queue.Peek() > 0)
            {
                var pop = queue.Dequeue();
                foreach (var neighbor in AdjacencyList[node])
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        public bool DFS(int node)
        {
            VisitedAry[node] = 1;
            foreach (var neighbor in AdjacencyList[node])
            {
                if (VisitedAry[neighbor] == 0)
                {
                    ParentList[neighbor] = node;
                    DFS(neighbor);
                }
                else//neighbor 
                {

                }
            }

            return false;
        }

    }
}
