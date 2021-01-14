using System;
using System.Collections.Generic;
using System.Linq;
using IK.Utils;

namespace IK.Sorting.IKPracticeProblems
{
    public static class NearestNeighbor
    {
        public static List<List<int>> nearest_neighbours(int p_x, int p_y, int k, List<List<int>> n_points)
        {
            //int len = n_points.Count;
            List<Point> points = new List<Point>();

            List<List<int>> result = new List<List<int>>();
         

            int i = 0;
            foreach(var n_coords in n_points)
            {
                var x = n_coords[0];
                var y = n_coords[1];
                points.Add(new Point(i, Math.Sqrt((p_x - x) * 1L * (p_x - x) + (p_y - y) * 1L * (p_y - y))));

                i++;
            }

            //sort list by distance
            //points.Sort((x,y) => x.distance.CompareTo(y.distance));
            var closestPoints = maxHeapSort(k, points);

          

            //query n_points list by index to get the coordinates
            foreach(var p in closestPoints)
            {
                result.Add(n_points.ElementAt(p.index));
            }

            return result;
        }

        //Sort using max heap
        private static List<Point> maxHeapSort(int size, List<Point> points)
        {
            HeapDouble maxHeap = new HeapDouble(MaxOrMin.Max);

            foreach (var p in points)
            {
                maxHeap.Add(p);

                if (maxHeap.Size > size)
                    maxHeap.Pop();
            }

            return maxHeap.Elements;

        }
    }

   


    public class Point
    {
        public int index { get; set; }
        public double distance { get; set; }

        public Point(int index, double distance)
        {
            this.index = index;
            this.distance = distance;
        }
    }
}
