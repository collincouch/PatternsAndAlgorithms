using System;
using System.Collections.Generic;

namespace IK.Recursion.Leet
{
    //46
    public class Permutations
    {
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums)
        {

            helperRecursive(nums, 0, new List<int>());

            return result;
        }


        void helperRecursive(int[] numsSubProblemDefinition,int i, List<int> slate)
        {
            //base case
            if(i==numsSubProblemDefinition.Length)
            {
                result.Add(new List<int>(slate));
                return;
            }

            //recursion
            
            for(int pick=i;pick<numsSubProblemDefinition.Length;pick++)
            {
                //swap pick with i so we have a continous array
                swap(numsSubProblemDefinition, pick, i);
                slate.Add(numsSubProblemDefinition[i]);
                helperRecursive(numsSubProblemDefinition, i + 1, slate);
                slate.RemoveAt(slate.Count - 1);
                //swap back
                swap(numsSubProblemDefinition, pick, i);



            }
        }

        private void swap(int[] numsSubProblemDefinition, int index1, int index2)
        {
            var temp = numsSubProblemDefinition[index1];
            numsSubProblemDefinition[index1] = numsSubProblemDefinition[index2];
            numsSubProblemDefinition[index2] = temp;

        }
    }
}
