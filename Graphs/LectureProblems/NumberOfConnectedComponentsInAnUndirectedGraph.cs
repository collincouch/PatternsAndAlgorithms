using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Graphs.LectureProblems
{
    //Leet Code #323
    //Time: V+E
    public static class NumberOfConnectedComponentsInAnUndirectedGraph
    {

        public static  int countComponents(int n, int[][] edges)
        {
            //global count as result
            int res = 0;
            //visited node set
            var visted = new List<int>();
            //build adjList to represetn the graph
            var graph  = buildGraph(n,edges);

            //for(int i=0;i<n;i++)
            //{
            //    //if node is visted, skip and continue
            //    if (visted.Contains(i)) continue;

            //    //traverse from node i with all connected nodes
            //    dfs(i, graph, visted);

            //    //visted all nodes connected to i, increase global count
            //    res++;

            //}

            return graph.findComponents();
            //return res;
        }

       

        static Graph buildGraph(int verticies, int[][] edges)
        {
            Graph graph = new Graph(verticies);
            //for(var adLs in graph.AdjacencyList)
            for(int i=0;i<verticies;i++)
            {
                graph.AdjacencyList.Add(i, new List<int>());
            }

            for (int i = 0; i < edges.Length; i++)
            {
                //int[] innerArray = edges[i][1;
                graph.addEdge(edges[i][0], edges[i][1]);
            }


            return graph;
        }

        static void dfs(int node, Graph graph, List<int> visted)
        {
            //visted current node, add to visted set
            visted.Add(node);
            foreach(var neignbor in graph.AdjacencyList[node])
            {
                if (!visted.Contains(neignbor))
                {
                    dfs(neignbor, graph, visted);
                }
            }
        }

       

        static void bfs(int node, Dictionary<int, int[]> adjList, List<int> visted)
        {

            var queue = new Queue<int>();
            queue.Enqueue(node);
            visted.Add(node);
            while (queue.Peek()>0){
                var pop = queue.Dequeue();
                foreach(var neighbor in adjList[node])
                {
                    queue.Enqueue(neighbor);
                }
            }
        }
    }


}
