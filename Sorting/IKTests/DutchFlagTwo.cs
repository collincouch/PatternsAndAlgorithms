using System;
using System.Collections.Generic;

namespace IK.Sorting.IKTests
{
    public class DutchFlagTwo
    {
        public static void dutch_flag_sort(List<char> balls)
        {

            int i = 0;//Red
            int j = 0;//Green
            int k = balls.Count;//blue

            while (j <=k)
            {
                if(balls[j]=='R')
                {
                    swap(balls, i, j);
                    i++;
                    j++;
                }
                else if (balls[j] == 'G')
                {
                    j++;
                }
                else
                {
                    swap(balls, j, k);
                    k--;
                }
            }

        }


     

        private static void swap(List<char> balls, int index1, int index2)
        {
            var temp = balls[index1];
            balls[index1] = balls[index2];
            balls[index2] = temp;
        }
    }
}
