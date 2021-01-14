using System;
namespace IK.Sorting.IKPracticeProblems.IKTests
{
    public static class MergeTwoArrays
    {

        //public static void Merge(int[])


        //Leet Code #88
        public static void merger_first_into_second(int[] arr1, int[] arr2)
        {
            /*
			 * Write your code here.
			 */

            int i = arr1.Length-1;
            int j = i;
            int k = arr2.Length-1;

            while (i > 0)
            {
                if(j>0)
                {
                    if (arr2[j] > arr1[i])
                    {
                        SwapInts(arr2, j, k);
                        j--;
                       
                    }
                    else
                    {
                        SwapInts(arr2, i, k);
                        i--;
                      
                    }
                    k--;
                }
                else
                {
                    SwapInts(arr2, i, k);
                    i--;
                    k--;
                }
              

            }

            
       

        }

        static void SwapInts(int[] array, int position1, int position2)
        {
            int temp = array[position1]; // Copy the first position's element
            array[position1] = array[position2]; // Assign to the second element
            array[position2] = temp; // Assign to the first element
        }

        static void SwapIntsTwoArys(int[] array1, int[] array2, int position1, int position2)
        {
            int tempAry2 = array2[position2]; // Copy the first position's element
            int tempAry1 = array1[position1];
            array1[position1] = tempAry2; // Assign to the second element
            array2[position2] = tempAry1; // Assign to the first element
        }
    }
}

