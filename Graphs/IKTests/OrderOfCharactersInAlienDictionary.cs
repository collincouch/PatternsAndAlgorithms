using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using IK.Utils;

namespace IK.Graphs.IKTests
{
    public static class OrderOfCharactersInAlienDictionary
    {
        public static string find_order(string[] words)
        {
          
            List<int> result = new List<int>();

            //1. Create a graph with the number of vertices
            //equal to the number of characters in the
            //dictionary

            //get distince characters in words array
            List<char> verticies = new List<char>();
            foreach(var s in words)
            {
                foreach(var c in s)
                {
                    if (!verticies.Contains(c))
                        verticies.Add(c);
                }
            }

            //2.  Do the following for every pair of adjancent
            //words in the dictionary
            // a.  one-by-one, compare characters of word1 to word2.
            //Find the first mistaching characters.
            // b.  create an edge in the graph from character of
            //word1 to that in word2.

            Graph graph = new Graph(verticies.Count);


            for (int i=0;i<words.Length-1;i++)
            {
                //build adjency list
                //Take the current two words and find
                //the first mismatching character
                string word1 = words[i];
                string word2 = words[i + 1];
                for(int j=0;j<Math.Min(word1.Length,word2.Length);j++)
                {
                    if (word1[i] != word2[j])
                    {
                        graph.addEdge(word1[i], word2[j], false);
                        break;
                    }
                    
                }
            }

      
            bool[] visited = new bool[verticies.Count];

            
            dfs(words[0][0], graph, visited, result);

            var test = result.Select(c => c.ToString()).ToString();

            return test;
        }

        static void dfs(int currentVertex, Graph graph, bool[] visited, List<int> result)
        {
            result.Add(currentVertex);
            visited[currentVertex] = true;
            foreach (var neighbor in graph.AdjacencyList[currentVertex])
            {
                if (!visited[neighbor])
                {
                    dfs(neighbor, graph, visited, result);

                }
            }
        }
    }

    
}
