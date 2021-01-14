using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Recursion.Leet
{

    //90
    public class SubsetsII
    {
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {

            //sort array
            Array.Sort(nums);

            recursionHelper(nums, 0, new List<int>());

            return result;
        }


        void recursionHelper(int[] subProblemDef,int i, List<int> slate)
        {
            //base case
            if(i==subProblemDef.Length)
            {
                result.Add(new List<int>(slate));
                return;
            }

            int count=0;
            //recursion
            //count how many times copies of number appear.
            for(int index=i;index<subProblemDef.Length;index++)
            {
                if (subProblemDef[index] != subProblemDef[i])
                    break;
                count++;
            }

            //exclude call
            recursionHelper(subProblemDef, i + count, slate);

            //multiple inclusion call
            for(int c=1;c<=count;c++)
            {
                //choose c copies of subproblem[i]
                slate.Add(subProblemDef[i]);
                recursionHelper(subProblemDef, i + count, slate);

            }

            //clean up
            for(int c=1;c<=count;c++)
            {
                slate.RemoveAt(slate.Count - 1);
            }

        }
    }
}
