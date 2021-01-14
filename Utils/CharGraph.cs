using System;
using System.Collections.Generic;

namespace IK.Utils
{
    public class CharGraph
    {
        public Dictionary<int, List<char>> AdjacencyList { get; set; }
        private int Verticies { get; set; }
        private int[] VisitedAry { get; set; }
        private List<int> VisitedList { get; set; }
        private List<int> ParentList { get; set; }

        // Constructor - creates an empty Adjacency List
        public CharGraph(int verticies)
        {
            AdjacencyList = new Dictionary<int, List<char>>();
            Verticies = verticies;
            VisitedAry = new int[verticies];
            VisitedList = new List<int>();
            ParentList = new List<int>();
        }

        // Appends a new Edge to the linked list
        public void addEdge(char startVertex, char endVertex, bool bidir = true)
        {
            if (!AdjacencyList.ContainsKey(startVertex))
            {
                AdjacencyList[startVertex] = new List<char>();
            }

            AdjacencyList[startVertex].Add(endVertex);

            if (bidir == true)
            {
                if (!AdjacencyList.ContainsKey(endVertex))
                {
                    AdjacencyList[endVertex] = new List<char>();

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


        public void buildAdjacencyList(char[][] edges)
        {
            //for(var adLs in graph.AdjacencyList)
            for (int i = 0; i < Verticies; i++)
            {
                AdjacencyList.Add(i, new List<char>());
            }

            for (int i = 0; i < edges.Length; i++)
            {

                addEdge(edges[i][0], edges[i][1]);
            }
        }
    }
}
