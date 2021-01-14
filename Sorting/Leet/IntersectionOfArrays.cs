using System;
using System.Collections.Generic;

namespace IK.Sorting.Leet
{
    public static class IntersectionOfArrays
    {

        public static List<int> getIntersectionOfTwoSortedArrays(int[] arr1, int[] arr2)
        {
            //two pointer solution
            //Note if arrays are not sorted,
            //then I would sort using Quick Sort
            //or merge sort.

            int i = 0;
            int j = 0;

            List<int> result = new List<int>();

            while(i<arr1.Length && j<arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if(arr1[i]>arr2[j])
                {
                    j++;
                }
                else
                {
                    result.Add(arr1[i]);
                    i++;
                    j++;
                }
            }

            return result;
        }

       
    }
}
