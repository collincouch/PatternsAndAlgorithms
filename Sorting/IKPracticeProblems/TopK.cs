using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Sorting.IKPracticeProblems
{
    public class TopK
    {
        public static int[] topK(int[] arr, int k)
        {

            //You are given an array of integers, arr, of size n, which is analogous to a continuous
            //stream of integers input. Your task is to find K largest elements from a given stream
            //of numbers.

            //By definition, we don't know the size of the input stream. Hence, produce K largest
            //elements seen so far, at any given time. For repeated numbers, return them only once.

            //If there are less than K distinct elements in arr, return all of them.

            //Don't rely on size of input array arr.
            //Feel free to use built -in functions if you need a specific data-structure.

            //Example One

            //Input: arr = [1, 5, 4, 4, 2]; K = 2

            //Output:[4, 5]

            //Example Two

            //Input: arr = [1, 5, 1, 5, 1]; K = 3

            //Output:[5, 1]



            Array.Sort(arr);
            List<int> topKLst = new List<int>();
            for(int i = arr.Length-1;i>0&&k>0;i--)
            {
                if (i == arr.Length - 1 || arr[i] != arr[i + 1])
                {
                    topKLst.Add(arr[i]);
                    k--;
                }
            }


            return topKLst.ToArray();
          
        }
    }
}
