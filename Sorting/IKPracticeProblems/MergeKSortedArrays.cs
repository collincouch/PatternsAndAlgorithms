using System;
using IK.Utils;

namespace IK.Sorting.IKPracticeProblems
{
    public static class MergeKSortedArrays
    {
        public static int[] mergeArrays(int[][] arr)
        {
            /*
             * Write your code here.
             */
            Heap heap;
            int K = arr.Length;
            int N = arr[0].Length;
            int[] result = new int[K * N];

            if (K == 0)
                return new int[0];
            if (N == 1)
                return new int[1] { arr[0][0] };

            MaxOrMin maxOrMin = MaxOrMin.NoFound;
           

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    if (arr[0][0] > arr[0][1])
                    {
                        maxOrMin = MaxOrMin.Max;
                        break;
                    }
                    else if(arr[0][0] < arr[0][1])
                    { 
                        maxOrMin = MaxOrMin.Min;
                        break;
                    }

                }
                if (maxOrMin != MaxOrMin.NoFound)
                    break;

            }
            heap = new Heap(N*K, maxOrMin);



            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    heap.Add(arr[i][j]);
                }
            }




            int pointer = 0;
            while(pointer <= (N*K)-1)
            {
                result[pointer] = heap.Pop();
                pointer++;
            }



            return result;

        }

    }
}
