using System;
using System.Collections.Generic;
using System.Text;
namespace IK.Recursion.IKTests
{
    public class PossibleToAcheiveSum
    {
        public static bool check_if_sum_possible(long[] arr, long k)
        {
               //helperSum()

            return true;
        }


        static void helper_check_if_sum_possible(int numOfDice, int targetSum, int runningSum, StringBuilder soFar)
        {
            //runningSum + numDice*1>targetSum
            //runningSum * 6<targetSum

            if (runningSum + numOfDice * 1 > targetSum)
            {
                return;
            }
            if (runningSum * 6 < targetSum)
            {
                return;
            }
            if (runningSum > targetSum)
                return;

            if (numOfDice == 0)
            {
                if (runningSum == targetSum)
                {
                    Console.Write(soFar.ToString() + "\n");
                }
            }
            else
            {
                for (int val = 1; val <= 6; val++)
                {
                    soFar.Append(val);
                    //helperDice(numOfDice - 1, targetSum, runningSum + val, soFar);
                    soFar.Remove(soFar.Length - 1, 1);
                }
            }


        }

    }
}
