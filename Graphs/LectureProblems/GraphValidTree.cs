using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Graphs.LectureProblems
{
    //Leet Code #261
    public static class GraphValidTree
    {
        
        public static bool validTree(int n, int[][] edges)
        {
            //traverse graph and look for cycle or subgroups.
            //trees cannot contain either.
            List<int> visited = new List<int>();
            
            //bild adjList
            var graph = buildGraph(n, edges);


            //detect cyxcel, if yes, return false
            if (hasCycle(0, graph, visited, 0))
                return false;

            //visted nodes size is teh same as n, means all nodes are visted,
            //therefore no multiple components
            if (visited.Count == n)
                return true;
            else
                return false;//the graphic has multiple groups
        }

        static bool hasCycle(int node, Graph  graph, List<int> visted, int parent)
        {
            visted.Add(node);

            foreach(var neighbor in graph.AdjacencyList[node])
            {
                if (!visted.Contains(neighbor))
                {
                    //pass in node as the parent to the neighbor
                    if (hasCycle(neighbor, graph, visted, node))
                    {
                        return true;
                    }
                    
                      
                }
                else
                {
                    if (neighbor != parent)
                    {
                        //cycle is deted
                        return true;
                    }
                }
            }

            return false;
        }

     

        static Graph buildGraph(int verticies, int[][] edges)
        {
            Graph graph = new Graph(verticies);

            for (int i = 0; i < verticies; i++)
            {
                graph.AdjacencyList.Add(i, new List<int>());
            }

            for (int i = 0; i < edges.Length; i++)
            {
                
                graph.addEdge(edges[i][0], edges[i][1]);
            }


            return graph;
        }
    }

  


    
}
