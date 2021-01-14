using System;
using System.Collections.Generic;
using System.Linq;

namespace IK.Sorting.Leet
{
    public class ThreeSum
    {
        public static IList<IList<int>> GetThreeSum(int[] nums)
        {

            IList<IList<int>> result = new List<IList<int>>();

            sortArray(nums,0,nums.Length-1);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    break;
                if (i != 0 && nums[i] == nums[i - 1])
                    continue;
                else
                    getThreeSum(result, nums, i);
            }

            return result;

        }


        //get 3 sum    
        static void getThreeSum(IList<IList<int>> soFar, int[] nums, int startIdx)
        {
            int i = startIdx + 1;
            int j = nums.Length - 1;

            while (i < j)
            {
                int sum = nums[startIdx] + nums[i] + nums[j];
                if (sum > 0)
                {
                    j--;
                }
                else if (sum < 0)
                {
                    i++;
                }
                else
                {
                    soFar.Add(new List<int> { nums[startIdx], nums[i], nums[j] });
                    i++;
                    j--;
                    while (i < j && nums[i] == nums[i - 1])
                    {
                        i++;
                    }

                }
            }

            //return soFar;

        }


        //quick sort
        static void sortArray(int[] ary, int leftIdx, int rightIdx)
        {

            if (leftIdx >= rightIdx)
                return;
            //partition and get pivot
            int pivotIdx = partition(ary, leftIdx, rightIdx);

            //sort left side
            sortArray(ary, leftIdx, pivotIdx - 1);

            //sort right side
            sortArray(ary, pivotIdx + 1, rightIdx);
        }


        static int partition(int[] ary, int leftIdx, int rightIdx)
        {
            int i = leftIdx + 1;
            int j = leftIdx + 1;

            while (j <= rightIdx)
            {
                if (ary[j] < ary[leftIdx])
                {
                    swap(ary, j, i);
                    j++;
                    i++;
                }
                else
                {
                    j++;
                }
            }

            //put pivot in proper spot
            swap(ary, i - 1, leftIdx);

            return i - 1;
        }

        static void swap(int[] ary, int index1, int index2)
        {
            int temp = ary[index1];
            ary[index1] = ary[index2];
            ary[index2] = temp;
        }
    }
}
