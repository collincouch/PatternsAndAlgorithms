using System;
using System.Collections.Generic;
using System.Linq;

namespace IK.Sorting.IKPracticeProblems
{
    public class ImpementMergeSort
    {
        public static List<int> merge_sort(List<int> arr)
        {

			var array = arr.ToArray();
			
			int left=0, right = array.Length-1;

			
			var sortedArray = mergeSort(array, left,right);

			return sortedArray.ToList();
        }

		static int[] mergeSort(int[]arr, int lIdx, int rIdx)
		{
			//the exit plan :)
			if (lIdx == rIdx)
				return new int[1] { arr[lIdx] };

			//get middle pointer
			int mIdx = lIdx + (rIdx - lIdx) / 2;
			//get random index

			//divide left
			int[]leftSort = mergeSort(arr, lIdx, mIdx);

			//divide right
			int[]rightSort = mergeSort(arr, mIdx + 1, rIdx);

			int[]ans = merge(leftSort,rightSort);

			return ans;
		}




		static int[] merge(int[] arr1, int[]arr2)
		{
			int i = 0, j = 0, k = 0;
			int[] ans = new int[arr1.Length + arr2.Length];


			while (i < arr1.Length && j < arr2.Length)
			{

                if (arr1[i] <= arr2[j])
                {
                    ans[k] = arr1[i];
                    i++;

                }
                else
                {
                    ans[k] = arr2[j];
                    j++;

                }

                k++;
            }



			while (i < arr1.Length)
			{
				
				ans[k] = arr1[i];
				i++;
				k++;
			}

			while (j < arr2.Length)
			{
				
				ans[k] = arr2[j];
				j++;
				k++;

			}
			

			return ans;
		}
	}
}
