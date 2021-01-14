using System;
using System.Collections.Generic;

namespace IK.Recursion.Leet
{
    public class PermutationsII
    {
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> PermuteUnique(int[] nums)
        {

            helperRecursive(nums, 0, new List<int>());
            return result;
        }


        void helperRecursive(int[] subProblemDef, int i, List<int> permutationsSoFar)
        {
            //base case
            if(i==subProblemDef.Length)
            {
                result.Add(new List<int>(permutationsSoFar));
                return;
            }

            Dictionary<int, int> pickedSoFar = new Dictionary<int, int>();
            for(int picked=i;picked<subProblemDef.Length;picked++)
            {
                if (pickedSoFar.ContainsKey(subProblemDef[picked]))
                    continue;
                else
                {
                    pickedSoFar.Add(subProblemDef[picked], subProblemDef[picked]);
                    //swap with i
                    swap(subProblemDef, picked, i);
                    //add to partial solution
                    permutationsSoFar.Add(subProblemDef[i]);
                    //recusion
                    helperRecursive(subProblemDef, i + 1, permutationsSoFar);
                    //remove from partial solution
                    permutationsSoFar.RemoveAt(permutationsSoFar.Count - 1);
                    //swap back
                    swap(subProblemDef, picked, i);

                }

            }
        }

        private void swap(int[] subProblemDef, int index1, int index2)
        {
            var temp = subProblemDef[index1];
            subProblemDef[index1] = subProblemDef[index2];
            subProblemDef[index2] = temp;
        }
    }
}
