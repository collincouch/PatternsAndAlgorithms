using System;
namespace IK.LeetCodeChallenges.Dec
{
    public class Week3
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        //Given a non-negative integer represented as a linked list of digits, plus one to the integer.

        //The digits are stored such that the most significant digit is at the head of the list.


        public ListNode PlusOne(ListNode head)
        {



            ListNode sentinel = new ListNode(0, head);
            ListNode notNine = sentinel;



            while (head != null)
            {
                //is this the last node?
                if (head.val !=9)
                {
                    notNine = head;

                }
                head = head.next;
            }

            //increse the rightmost non-nine digit by 1
            notNine.val++;
            notNine = notNine.next;

            //set all the following nines to zeros
            while(notNine!=null)
            {
                notNine.val = 0;
                notNine = notNine.next;
            }

            return sentinel.val != 0 ? sentinel : sentinel.next;
        }

        //Given an integer array nums sorted in non-decreasing order,
        //return an array of the squares of each number sorted in non-decreasing order.
        public int[] SortedSquares(int[] nums)
        {

            //loop though array and update each value with it's sq root.
            for(int i=0;i<nums.Length;i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            //Quick sort the array
            quickSort(nums, 0, nums.Length - 1);

            return nums;
        }




        void quickSort(int[] ary, int leftIdx, int rgtIdx)
        {

            if (leftIdx >= rgtIdx)
                return;

            //partition
            int piviot = partition(ary, leftIdx, rgtIdx);

            //sort left
            quickSort(ary, leftIdx, piviot - 1);

            //sort right
            quickSort(ary, piviot + 1, rgtIdx);


        }

        private int partition(int[] ary, int leftIdx, int rgtIdx)
        {

            //generate random pivot
            Random random = new Random();
            int pivotIdx = random.Next(leftIdx, rgtIdx);

            //swap piviot with left indx
            swap(ary, leftIdx, pivotIdx);

            int i = leftIdx + 1;
            int j = leftIdx + 1;

            while(j<=rgtIdx)
            {
                if (ary[j] < ary[leftIdx])
                {
                    swap(ary, j, i);
                    i++;
                    j++;
                }
                else
                    j++;
                   
            }

            //swap piviot back into correct spot
            swap(ary, i - 1, leftIdx);

            return i - 1;

        }

        private void swap(int[] ary, int index1, int index2)
        {
            var temp = ary[index1];
            ary[index1] = ary[index2];
            ary[index2] = temp;
        }
    }
}
