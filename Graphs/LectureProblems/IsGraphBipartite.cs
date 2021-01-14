using System;
using System.Collections.Generic;

namespace IK.Graphs.LectureProblems
{
    //Leet Cde #785
    public static class IsGraphBipartite
    {
       
        public static bool IsBipartite(int [][] graph)
        {
            Dictionary<int,int> visited = new Dictionary<int, int>();
            for(int i=0;i<graph.Length;i++)
            {
                //if visited, skip
                if (visited.ContainsKey(i)) continue;
                         
                //given connected nodes with i is an invalid bipartie, return false
                if(!dfs(graph,i, visited, 0))
                {
                    return false;
                }
            }

            return true;
        }

        static bool dfs(int[][]graph, int node, Dictionary<int,int> visited, int color)
        {
            //add node and color into visted dictionary
            visited.Add(node, color);

            foreach(var neighbor in graph[node])
            {
                //if (visited.ContainsValue(neighbor))
                //{
                visited.TryGetValue(neighbor, out int val);
                if (val==color)
                {
                    //my neighbor has the same color of myself,
                    //therefor it is not a valid bipartite
                    return false;
                }
                //{

                
                    //}
                    //continue;
                //}

                //continue traverse, assign different color to the
                //the neighbor
                if(!dfs(graph,neighbor, visited, 1 - color))
                {
                    //if the neighbor is not a valid bipartite, return false here
                    return false;
                }
            }

            //no invalid case, return true;
            return true;
        }
    }


   
}
