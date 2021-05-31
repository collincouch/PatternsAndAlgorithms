using System;
using System.Collections.Generic;

namespace IK.Graphs.Leet
{
    public class GraphValidTree
    {
        //A valid tree is a connected graph with no cycles and is unrooted.
        //Cycles mean no cross edges for bfs or back edge for dfs
        
        //261
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        int[] visited;
        int[] parents;//used to keep track of parents of neighbors.  This is how I'll look for cross edges and back edges.
        public bool ValidTree(int n, int[][] edges)
        {
            //1. Build graph
            buildGraph(n, edges);

            visited = new int[n];

            
            parents = new int[n];

            int connectedComponents = 0;

            //2. bfs or dfs
            //bfs();

            //3.  outer loop
            for(int v=0;v<n;v++)
            {
                if(visited[v]==0)
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

            while(queue.Count!=0)
            {
                int vertex = queue.Dequeue();
                //look at the neighbors in the adjacency list
                foreach(var neighbor in adjacencyList[vertex])
                {
                    if(visited[neighbor]==0)
                    {
                        visited[neighbor] = 1;

                        parents[neighbor] = vertex;
                        queue.Enqueue(neighbor);
                    }
                    else  //this has been visited
                    {
                        if (neighbor != parents[vertex])
                            return true; //cross edge
                    }
                }
            }

            return false;

        }

        private void buildGraph(int n, int[][] edges)
        {
            //create the vertices
            for(int i=0;i<n;i++)
            {
                adjacencyList.Add(i, new List<int>());
            }

            //populate the edges
            for(int i=0;i<edges.Length;i++)
            {
                addEdge(edges[i][0], edges[i][1], true);
            }
        }

        private void addEdge(int startVertex, int endVertex, bool isUndirected=true)
        {

            if (!adjacencyList.ContainsKey(startVertex))
                adjacencyList.Add(startVertex, new List<int>());

            adjacencyList[startVertex].Add(endVertex);

            if(isUndirected==true)
            {
                if(!adjacencyList.ContainsKey(endVertex))
                {
                    adjacencyList.Add(endVertex, new List<int>());
                }

                adjacencyList[endVertex].Add(startVertex);
            }
        }
    }
}
