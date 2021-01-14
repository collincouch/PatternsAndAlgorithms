using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Sorting.IKPracticeProblems
{
    public class ThreeSum
    {
        public static string[] findZeroSum(int[] arr)
        {
            // Write your code here.

            //Sort the array
            QuickSort.Sort_Recursive(arr, 0, arr.Length-1);
            List<string> result = new List<string>();
            string sSum;
           for(int i =0;i<arr.Length;i++)
            {
                if (arr[i] > 0)
                    break;

                
                    if (i!=0 && arr[i] == arr[i - 1])
                        continue;                
                    else
                    {
                        sSum = sumNumbers(i, arr,result);
                    if (sSum != "")
                        result.Add(sSum);
                    }
                        


            }

            return result.ToArray();
        }

        static string sumNumbers(int i, int[] arr,List<string> res)
        {
            int lo = i+1;
            int hi = arr.Length - 1;
            int sum;
            string zsum="";
            while(lo<hi)
            {
                sum = arr[i] + arr[lo] + arr[hi];

                if (sum < 0)
                    lo++;
                else if (sum > 0)
                    hi--;
                else
                {
                    res.Add(string.Format("{0},{1},{2}", arr[i], arr[lo], arr[hi]));
                    lo++;
                    hi--;
                    while(lo < hi && arr[lo]==arr[lo-1])
                    {
                        lo++;
                    }

                }
                    

            }

            return zsum;
        }

      
    }
}
