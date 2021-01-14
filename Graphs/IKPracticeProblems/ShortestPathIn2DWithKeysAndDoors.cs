using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Graphs.IKPracticeProblems
{
    public static class ShortestPathIn2DWithKeysAndDoors
    {
        public static void find_shortest_path(string[] grid)
        {

            //Turn grid into multi deminsional array
            char[][] gridAry = new char[grid.Length][];
            char[][] result = new char[][] { };
            Tuple<int, int> start;
            Tuple<int, int> end;
            Dictionary<int, Tuple<int, int>> keyDoors = new Dictionary<int, Tuple<int, int>>();

            for(var s=0;s<grid.Length;s++)
            {
                char[] splitAry = grid[s].ToCharArray();
                for(var a=0;a<splitAry.Length;a++)
                {
                    gridAry[s][a] = splitAry[a];
                }
            }

            for(var x=0;x < gridAry.Length;x++)
            {
                for(var y = 0; y < gridAry[0].Length; y++)
                {
                    if (gridAry[x][y] != '0')
                    {
                        dfs(x, y, gridAry);
                    }
                }
            }
          
         
            //for(int i=0; i<grid.Length;i++)



                //get start index

                //get target index

                //traverse map from start to end using recursion to
                //while keeping track for shortest # of
                //steps.

                //return the value with the shortest amount
                //of steps
        }

      

        static List<Tuple<int,int>> getNeighbors(int x, int y, char[][] grid)
        {
            List<Tuple<int,int>> result = new List<Tuple<int,int>>();
            if (x + 1 <= grid.Length)
                result.Add(new Tuple<int, int>(x + 1, y));
            if (y + 1 <= grid[0].Length)
                result.Add(new Tuple<int, int>(x, y+1));
            if (x - 1 >=0)
                result.Add(new Tuple<int, int>(x -1, y));
            if (y- 1 >=0)
                result.Add(new Tuple<int, int>(x, y-1));

            return result;
        }

        static void bfs(int i, int j, Queue<Tuple<int, int>> queue, char[][] grid)
        {
            
            var q = queue.Dequeue();
            queue.Enqueue(q);
            grid[i][j] = '0';
            while (queue.Count != 0)
            {
                var pop = queue.Dequeue();
                var neighbors = getNeighbors(pop.Item1, pop.Item2, grid);
                foreach(var rcnc in neighbors)
                {
                    if(grid[rcnc.Item1][rcnc.Item2] != '#')
                    {
                        //if(Char.IsLower(grid[rcnc.Item1][rcnc.Item2]))
                        queue.Enqueue(rcnc);
                        grid[rcnc.Item1][rcnc.Item2] = '0';
                    }
                }

            }

        }


        static void dfs(int i, int j,char[][]grid)
        {
            grid[i][j] = '#';
            var neighbors = getNeighbors(i, j, grid);
            foreach (var rcnc in neighbors)
            {
                if (grid[rcnc.Item1][rcnc.Item2] != '#')
                {

                    dfs(rcnc.Item1, rcnc.Item2, grid);
                }
            }
        }
    }

}
