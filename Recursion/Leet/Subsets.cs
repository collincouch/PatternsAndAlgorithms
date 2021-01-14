using System;
using System.Collections.Generic;

namespace IK.Recursion.Leet
{
    //78
    public class Subsets
    {
        //declare global result variable
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> Subsets1(int[] nums)
        {
            helperRecursion(nums, 0, new List<int>());
            return result;
        }

        void helperRecursion(int[] subProblem,int index,List<int> problemDefinition)
        {
            //Base recursion case
            if(subProblem.Length==index)
            {
                result.Add(new List<int>(problemDefinition));
                return;
            }

            //Recursion Case
            //include
            problemDefinition.Add(subProblem[index]);
            helperRecursion(subProblem, index + 1, problemDefinition);
            problemDefinition.RemoveAt(problemDefinition.Count - 1);

            //exclude
            helperRecursion(subProblem, index + 1, problemDefinition);
        }
    }
}
