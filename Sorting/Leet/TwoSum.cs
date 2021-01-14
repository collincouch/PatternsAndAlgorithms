using System;
using System.Collections.Generic;
using System.Linq;

namespace IK.Sorting.Leet
{
    //#1
    public static class TwoSum
    {
        //Given an array of integers nums and an integer target,
        //return indices of the two numbers such that they add up to target.
        public static int[] GetTwoSumIndices(int[] nums, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> numsDic = new Dictionary<int, int>();
            //put numbers in dictionary
            for(int i=0;i<nums.Length;i++)
            {
                numsDic.Add(i, nums[i]);
            }

          for(int i =0;i<nums.Length;i++)
            {
                
                int complement = target - nums[i];
                if(numsDic.ContainsValue(complement))
                {
                    var complementIndex = numsDic.FirstOrDefault(x => x.Value.Equals(complement)).Key;
                    if(complementIndex!=i)
                        return new int[] { i, complementIndex };
                }
              
            }

            throw new Exception("no sum found");
        }

        public static int[] GetTwoSumNumbers(int[] nums, int target)
        {

            int[] result = new int[2];



            //Use quick sort to sort the nums array.
            SortArray(nums, 0, nums.Length - 1);

            int i=0;
            int j = nums.Length - 1;
            int sum;

            while (i < j)
            {
                sum = nums[i] + nums[j];
                if(sum<target)
                {
                    i++;
                }
                else if(sum>target)
                {
                    j--;
                }
                else
                {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }


            return result;
        }


        static void SortArray(int[] ary,int leftIndex, int rightIndex)
        {
            //use quick sort

            //1.  if leftIndex >= rightIndex  return
            if (leftIndex >= rightIndex)
                return;

            //2. Partition the array and get pivot
            int pivot = Partition(ary, leftIndex, rightIndex);


            //3.  Recursive left side of pivot 
            SortArray(ary, leftIndex, pivot - 1);

            //4. Recursive right side of pivot
            SortArray(ary, pivot+1, rightIndex);







        }


        static int Partition(int[] ary, int lIdx, int rIdx)
        {


            int i = lIdx + 1;
            int j = lIdx + 1;

            while (j <= rIdx)
            {
                if (ary[j] < ary[lIdx])
                {
                    SwapInts(ary, j, i);
                    i++;
                    j++;
                }
                else
                    j++;

            }

            SwapInts(ary, i - 1, lIdx);


            return i - 1;
        }


        static void SwapInts(int[] arr,int idx1, int idx2)
        {
            int temp = arr[idx1];

            arr[idx1] = arr[idx2];

            arr[idx2] = temp;
        }

    }
}
