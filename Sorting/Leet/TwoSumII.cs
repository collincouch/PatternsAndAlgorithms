using System;
namespace IK.Sorting.Leet
{

    //167
    public class TwoSumII
    {
        public TwoSumII()
        {
        }

        public int[] TwoSum(int[] numbers, int target)
        {

            //numbers is sorted
            int i = 0;
            int j = numbers.Length - 1;
            int[] answer = new int[2];

            while (i < j)
            {
                if (numbers[i] + numbers[j] > target)
                    j--;
                else if (numbers[i] + numbers[j] < target)
                    i++;
                else
                {

                    answer[0] = i + 1;
                    answer[1] = j + 1;
                    break;

                }



            }

            return answer;


        }
    }
}
