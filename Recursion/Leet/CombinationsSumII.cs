using System;
using System.Collections.Generic;
using System.Linq;

namespace IK.Recursion.Leet
{
    //#40  29:48 in supplimental video
    public class CombinationsSumII
    {

        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            //sort array
            Array.Sort(candidates);
            helper(candidates, 0, new List<int>(), target);

            return result;
        }


        void helper(int[] subProblem,int index, List<int> slate,int target)
        {
            //back track
            if(slate.Sum()==target)//equal to target
            {
                result.Add(new List<int>(slate));
                return;
            }
            else if(slate.Sum()>target)
            {
                return;
            }


            //base case.  Base case is as less than target when bactracking.
            if(index==subProblem.Length)
            {
                return;
            }

            int count = 0;
            //recursion
            //count how many times copies of number appear.
            for (int i = index; i < subProblem.Length; i++)
            {
                if (subProblem[i] != subProblem[index])
                    break;
                count++;
            }


            //recursion
            //exclude
            helper(subProblem, index+count, slate,target);


            //include multiple copies
            for(int c=1;c<= count;c++)
            {
                //choose c copies of subproblem[i]
                slate.Add(subProblem[index]);
                helper(subProblem, index + count, slate,target);

            }


            //remove the multiple copies
            for(int c=1;c<=count;c++)
            {
                slate.RemoveAt(slate.Count - 1);
            }

        }
    }
}
