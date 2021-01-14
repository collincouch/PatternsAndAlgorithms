using System;
using System.Collections.Generic;
using System.Text;

namespace IK.Recursion.Leet
{
    public class GenerateParentheses
    {
        List<string> result = new List<string>();
        public IList<string> GenerateParenthesis(int n)
        {
            
            helperRecursion(n,n, new StringBuilder());
            return result;
        }

        void helperRecursion(int lftPCount, int rgtPCount,StringBuilder slate)
        {
            //backtracking
            if (lftPCount > rgtPCount)
                return;

            //base case
            if (lftPCount==0 && rgtPCount==0)
            {
                result.Add(slate.ToString());
                //return;
            }

            //recursion


            if (lftPCount >0)
            {

                slate.Append("(");
                helperRecursion(lftPCount - 1, rgtPCount, slate);
                slate.Remove(slate.Length - 1, 1);
            }

            if(rgtPCount>0)
            {
                slate.Append(")");
                helperRecursion(lftPCount, rgtPCount -1, slate);
                slate.Remove(slate.Length - 1, 1);
            }



            }
    }
}
