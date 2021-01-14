using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Sorting.IKPracticeProblems
{
    /// <summary>
    /// Four Billion
    //Given four billion of 32-bit integers, return any one that’s not among them.Assume you have 1 GiB (1024^3 bytes) of memory.

    //Follow up: what if you only have 10 MiB of memory?

    //Example One

    //Input: [0, 1, 2, 3]

    //Output: 4


    //Any number in the[4..2 ^ 32) range is a correct answer.

    //Example Two

    //Input: [4294967295, 399999999, 0]

    //Output: 1

    //Here again 1 is just one of many correct answers.

    //Notes

    //The function has one argument, an array of 32-bit long unsigned integers.Return a number that’s not among them.

    //Constraints:

    //1 <= length of input array <= 200000
    //0 <= element of input array < 2^32

    /// </summary>
    public static class FourBillion
    {
        public static long find_integer(List<long> arr)
        {

            long num = 1;
            long res = 0;
            foreach (long i in arr)
            {
                res = res ^ num ^ i;
                num++;
            }

            if (res == 0) return num;
            return res;

        }


    }
}
