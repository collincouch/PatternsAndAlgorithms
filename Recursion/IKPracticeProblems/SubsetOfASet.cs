using System;
using System.Text;
using System.Collections.Generic;
namespace IK.Recursion.IKPracticeProblems
{
    public class SubsetOfASet
    {
        public static string[] generate_all_subsets(string s)
        {
            List<string> subSets = new List<string>();
            generate_all_subsets_helper(s,0, new StringBuilder(),subSets);

            var result = subSets.ToArray();
            return result;
        }

        static void generate_all_subsets_helper(string s, int indx, StringBuilder soFar,
            List<string> subSets)
        {

         
            if (s.Length == 0)
            {
                subSets.Add(string.Empty);
                return;
            }
            //base case
            if (indx == s.Length)
            {
                subSets.Add(soFar.ToString());
            }
            else
            {
                //exclude
                generate_all_subsets_helper(s, indx + 1, soFar, subSets);

                //include
                soFar.Append(s[indx]);
                generate_all_subsets_helper(s, indx + 1, soFar, subSets);
                soFar.Remove(soFar.Length-1,1);
            }
        }

        //static void generate_all_subsets_helper(string s, StringBuilder soFar,
        //    List<string> subSets)
        //{

        //    //base case
        //    if (s.Length==0)
        //    {
        //        subSets.Add(soFar.ToString());
        //    }
        //    else
        //    {
        //        //exclude
        //        generate_all_subsets_helper(s.Substring(0,s.Length-1), soFar, subSets);

        //        //include
        //        soFar.Append(s);
        //        generate_all_subsets_helper(s.Substring(0, s.Length-1), soFar, subSets);
        //        soFar.Remove(soFar.Length - 1, 1);
        //    }
    //}


    }
}
