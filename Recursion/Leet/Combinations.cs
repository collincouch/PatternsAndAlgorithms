using System;
using System.Collections.Generic;

namespace IK.Recursion.Leet
{
    //77
    public class Combinations
    {
        public Combinations()
        {
        }

        //declare global result variable
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> Combine(int n,int k)
        {
            helperRecursion(n, new List<int>(), 0, new List<int>(),k);
            return result;
        }

        void helperRecursion(int n,List<int> subProblem, int index, List<int> problemDefinition,int k)
        {

            //backtrack
            if (subProblem.Count == k)
            {
                result.Add(new List<int>(problemDefinition));
                return;
            }

            for (int i = 1;i<n+1;i++)
            {
                
                //Base recursion case
                if (subProblem.Count == k)
                {
                    //the back tracking means we don't need
                    //the below line as we did for subsets
                    //problem
                    //result.Add(new List<int>(problemDefinition));
                    return;
                }

                //exclude
                helperRecursion(n,subProblem, index + 1, problemDefinition, k);


                //Recursion Case
                //include
                problemDefinition.Add(subProblem[index]);
                helperRecursion(n,subProblem, index + 1, problemDefinition, k);
                problemDefinition.RemoveAt(problemDefinition.Count - 1);

            }



           


            
        }
    }
}
