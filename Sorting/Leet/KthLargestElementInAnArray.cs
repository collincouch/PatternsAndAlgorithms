using System;
namespace IK.Sorting.Leet
{
    //Leet Code 215
    public class KthLargestElementInAnArray
    {
        public static int FindKthLargest(int[] nums, int k)
        {

            helperQuickSelect(nums,0,nums.Length-1,nums.Length-k);

            int kLargest = nums.Length - k;
            return nums[kLargest];
        }

        //1,2,2,3,3,4,5,5,6
         

        private static void helperQuickSelect(int[] ary,int start, int end, int index)
        {
            //base case
            if (start == end)
                return;

            //recursive
            int piviot = partion(ary, start, end);
            if (index == piviot)
                return;
            else if(index<piviot)//left 
                helperQuickSelect(ary, start, piviot - 1,index);
            else//right
                helperQuickSelect(ary, piviot + 1, end,index);

        }

      

        private static int partion(int[] ary, int leftIndx, int rightIndex)
        {
            //pick random pivot and move to index 0
            Random r = new Random();
            int randomPivot = r.Next(leftIndx, rightIndex);

            swap(ary, leftIndx, randomPivot);


            int i = leftIndx + 1;
            int j = leftIndx + 1;

            while(j<=rightIndex)
            {
                if (ary[j] < ary[leftIndx])
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

            //put pivot in proper spot and return index
            swap(ary, i - 1, leftIndx);

            return i - 1;
           
        }

        private static void swap(int[] ary, int index1, int index2)
        {
            var temp = ary[index1];
            ary[index1] = ary[index2];
            ary[index2] = temp;
        }
    }
}
