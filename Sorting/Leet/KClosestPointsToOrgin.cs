using System;
using System.Linq;

namespace IK.Sorting.Leet
{
    //#973
    public class KClosestPointsToOrgin
    {
        public int[][] KClosest(int[][] points, int K)
        {

            int[][] result = new int[K][];
         
            quickSelectHelper(points, 0, points.Length - 1,K-1);

          
            for(int i=0;i<K;i++)
            {
                result[i] = new int[] { points[i][0], points[i][1] };
            }
            //var result = points.Take(K);

            return result;


        }


        private void quickSelectHelper(int[][] allPoints, int left, int right, int index)
        {

            //base case
            if (left == right)
                return;

            int pivot = partition(allPoints, left, right);

            if (index == pivot)
                return;
            else if (index < pivot)///recursive call on left
                quickSelectHelper(allPoints, left, pivot - 1, index);
            else//recursive call on right
                quickSelectHelper(allPoints, pivot + 1, right, index);


        }

        private int partition(int[][] allPoints, int left, int right)
        {
            //get random pivot between left and right
            Random r = new Random();
            int piviotIndx = r.Next(left, right);

            //put pivot at index 0
            swap(allPoints, piviotIndx, left);

            int i = left + 1;
            int j = left + 1;


            while(j<=right)
            {
                //calculate distance
                double distaceJ = calculateDistance(allPoints[j]);
                double distacePiviot = calculateDistance(allPoints[left]);

                if (distaceJ < distacePiviot)
                {
                    swap(allPoints, j, i);
                    j++;
                    i++;
                }
                else
                {
                    j++;
                }
            }

            //put piviot back in proper spot
            swap(allPoints, i - 1, left);

            //return piviot index
            return i - 1;
        }

        private double calculateDistance(int[] vs)
        {
            //(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2))
            double result = Math.Pow(vs[0] - 0, 2) + Math.Pow(vs[1] - 0, 2);

            return result;
        }

        private void swap(int[][] allPoints, int indexOne, int indexTwo)
        {
            var temp = allPoints[indexOne];

            allPoints[indexOne] = allPoints[indexTwo];

            allPoints[indexTwo] = temp; 

        }
    }
}
