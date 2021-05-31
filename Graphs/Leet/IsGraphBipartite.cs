using System;
using System.Collections.Generic;

namespace IK.Graphs.Leet
{
    public class IsGraphBipartite
    {
        //785
        public IsGraphBipartite()
        {
        }

        //a graph is bipartite if we can split its
        //set of nodes into two independent subsets
        //A and B such that every edge in the graph
        //has one node in A and another node in
        //B


        //every tree is bipartie
        //except if there is a cycle
        //and
        //Cycle of odd length
        //not bipartite

        //cycle of even length
        //is bipartite

        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        int[] visited;
        int[] parents;//used to keep track of parents of neighbors.  This is how I'll look for cross edges and back edges.
        int[] distance;//used for distance from source to any node
        public bool CheckIsBipartite(int[][] graph)
        {
            //1. Build graph
            //buildGraph(n, edges);
            //the graph is already give
            int n = graph.Length;

            visited = new int[n];
            parents = new int[n];
            distance = new int[n];

            distance[0] = 0;

            int connectedComponents = 0;

            //3.  outer loop
            for (int v = 0; v < n; v++)
            {
                if (visited[v] == 0)
                {
                    connectedComponents++;
                    if (connectedComponents > 1)//return false if there is more than one connected component
                        return false;

                    if (bfs(v))
                        return false;  //cross edge
                }

            }

            return true;
        }



        private bool bfs(int source)
        {
            //setup our queue for bfs
            Queue<int> queue = new Queue<int>();

            //mark as visted
            visited[source] = 1;

            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                int vertex = queue.Dequeue();
                //look at the neighbors in the adjacency list
                foreach (var neighbor in adjacencyList[vertex])
                {
                    if (visited[neighbor] == 0)
                    {
                        visited[neighbor] = 1;
                        distance[neighbor]= 1 + distance[vertex];
                        parents[neighbor] = vertex;
                        queue.Enqueue(neighbor);
                    }
                    else  //this has been visited
                    {
                        if (neighbor != parents[vertex])
                            if (distance[neighbor] == distance[vertex])
                                return false; //even legth cycle
                            //return true; //cross edge
                    }
                }
            }

            return false;

        }
    }
}
