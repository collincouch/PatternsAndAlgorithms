using System;
namespace IK.Amazon.Sorting
{
    public class KLargestElementInAnArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int kLargest = nums.Length - k;

            quickSelect(nums, 0, nums.Length - 1, kLargest);
            
            return nums[kLargest];

        }

        private void quickSelect(int[] nums, int leftIndx, int rightIndx, int indx)
        {

            //base case
            if (leftIndx == rightIndx)
                return;

            int piviot = partition(nums, leftIndx, rightIndx);
            if (indx == piviot)
                return;
            else if (indx < piviot)//go left
                quickSelect(nums, leftIndx, piviot - 1, indx);
            else//go right
                quickSelect(nums, piviot + 1, rightIndx, indx);

        }

        private int partition(int[] nums, int leftIndx, int rightIndx)
        {
            //Get random piviot
            Random random = new Random();
            int piviotIdx = random.Next(leftIndx, rightIndx);

            //swap with left index in array
            swap(nums, leftIndx, piviotIdx);

            int i = leftIndx + 1;
            int j = leftIndx + 1;

            while(j<=rightIndx)
            {
                if(nums[j]<nums[leftIndx])
                {
                    swap(nums, j, i);
                    j++;
                    i++;
                }
                else
                {
                    j++;
                }
            }

            //put piviot back in place
            swap(nums, i - 1, leftIndx);

            //return piviot

            return i - 1;
        }

        private void swap(int[] nums, int index1, int index2)
        {
            var temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }
    }
}
