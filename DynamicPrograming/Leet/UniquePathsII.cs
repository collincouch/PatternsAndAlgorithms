using System;
namespace IK.DynamicPrograming.Leet
{
    public class UniquePathsII
    {
        int[][] table;
        public UniquePathsII()
        {
        }

        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int rows = obstacleGrid.GetLength(0);//rows
            int columns = obstacleGrid.GetLength(1);//columns
            table = new int[rows][];
        }


        //T(m,n) = O(m*n)
        //S(m,n) = O(m*n)

        public int helper(int[][] grid)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            //base case
            //top left corner
            if (grid[0][0] == 1)
                return 0;
            else
                table[0][0] = 1;

            //recersive call
            //iterate rows
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                //iterate columns
                for (int col = 0; row < grid.GetLength(1); col++)
                {
                    //if there is an obstical in my cell
                    if (grid[row][col] == 1)
                        table[row][col] = 0;
                    else
                    table[row][col] = table[row - 1][col] + table[row][col - 1];
                }
            }

            return table[m - 1][n - 1];    
                    
        }
    }
}
