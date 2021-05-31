using System;
using System.Collections.Generic;

namespace IK.Graphs.Leet
{

    //Leet 323
    public class NumberOfConnectedComponentsInAUndirectedGraph
    {
        int[] visited;
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();

        //Time: O(n)
        //Space: O(m+n)
        public int CountComponents(int n, int[][] edges)
        {

            //initialize visited array
            visited = new int[n];
            int count = 0;
            
            for(int i = 0; i < visited.Length; i++)
            {
                visited[i] = -1;
            }

            //1.  Build the Graph
            createAdjaceneyList(n,edges);

            //2.  BFS or DFS
            for(int v = 0;v<n-1;v++)
            {
                if (visited[v] == -1)
                {
                    count++;
                    bfs(v);
                }
                    
            }


            return count;
        }

        private void bfs(int source)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(source);
            visited[source] = 1;
            while (q.Count != 0)
            {
                var node = q.Dequeue();
                foreach(var neighbor in adjacencyList[node])
                {
                    if(visited[neighbor]==-1)
                    {
                        visited[neighbor] = 1;
                        q.Enqueue(neighbor);
                    }
                }
            }


        }

        private void createAdjaceneyList(int verticies,int[][] edges)
        {

            for(int i=0;i<verticies;i++)
            {
                adjacencyList.Add(i, new List<int>());
            }
            
            for(int i = 0;i<edges.Length;i++)
            {

                addEdge(edges[i][0],edges[i][1], true);
            }


           
        }

        private void addEdge(int startVertex, int endVertex, bool bidir = true)
        {
            if (!adjacencyList.ContainsKey(startVertex))
            {
                adjacencyList[startVertex] = new List<int>();
            }

            adjacencyList[startVertex].Add(endVertex);

            if (bidir == true)
            {
                if (!adjacencyList.ContainsKey(endVertex))
                {
                    adjacencyList[endVertex] = new List<int>();

                }

                adjacencyList[endVertex].Add(startVertex);
            }
        }
    }
}
