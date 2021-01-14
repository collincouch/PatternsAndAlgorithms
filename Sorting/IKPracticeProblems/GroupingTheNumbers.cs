using System;
namespace IK.Sorting.IKPracticeProblems
{
    public static class GroupingTheNumbers
    {
        public static int[] solve(int[] arr)
        {
            //two differnet pointers.
            //left will start on left, right will be on right

            int left = 0;
            int right = arr.Length - 1;

            //once they cross, I have the solution


            while (right > left)
            {
                if (arr[right] % 2 == 0)
                {
                    //found an even on right pointer
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                    left++;
                 

                }
                else
                {
                    right--;
                }

            }

            return arr;
        }

        

    }
}
