using System;
using System.Collections.Generic;
using System.Text;

namespace IK.Recursion.Leet
{
    //#784
    public class LetterCasePermutation
    {
        List<string> result;
        public IList<string> LetterCasePermutation1(string S)
        {
            result = new List<string>();

            helperRecursion(S, 0, new StringBuilder());

            return result;
        }


        void helperRecursion(string subProblem, int i, StringBuilder problemDefinition)
        {
            //Base case for leaf level node
            if(i==subProblem.Length)
            {
                result.Add(problemDefinition.ToString());
                return;
            }

           
            //Recursive case.  internal nodes
            if(Char.IsNumber(subProblem[i]))
            {
                helperRecursion(subProblem, i + 1, problemDefinition.Append(subProblem[i].ToString()));
                problemDefinition.Remove(problemDefinition.Length - 1, 1);
            }
            else
            {
                //lower case permutation
                helperRecursion(subProblem, i + 1, problemDefinition.Append(subProblem[i].ToString().ToLower()));
                problemDefinition.Remove(problemDefinition.Length-1, 1);
                //upper case permutation
                helperRecursion(subProblem, i + 1, problemDefinition.Append(subProblem[i].ToString().ToUpper()));
                problemDefinition.Remove(problemDefinition.Length - 1, 1);
            }


        }
    }
}
