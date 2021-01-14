using System;
using System.Collections.Generic;
using System.Linq;
namespace IK.Recursion.IKPracticeProblems
{
    public class PalindromicDecomposition
    {
        public static string[] generate_palindromic_decompositions(string s)
        {
            List<string> decompInProgress = new List<string>();
            List<List<string>> validDecomp = new List<List<string>>();

            var result = helper(s, 0, validDecomp, decompInProgress);

            string[] res = new string[result.Count];

            for (int i = 0; i < result.Count(); i++)
            {
                res[i] = string.Join("|",result[i].ToArray());
            }

            return res;
        }

        

        static List<List<string>> helper(string s, int pointer, List<List<string>> palList,List<string> partialResult){

            //List<string> result = null;
            string prefix = "";
            int len = s.Length;
            List<String> current = new List<String>(partialResult);
            //base case
            if (pointer == len)
                partialResult.Clear();
           
                for (int i = pointer; i < len; ++i)
                {
                   
                    prefix = prefix + s[i];

                // check whether the substring is  
                // palindromic or not 
                if (IsPalindrome(prefix))
                {

                    // if palindrome add it to temp list 
                    partialResult.Add(prefix);
                    if (i + 1 < len)
                    {
                        // recurr to get all the palindromic 
                        // partitions for the substrings 
                        palList = helper(s, i + 1, palList, partialResult);
                    }
                    else
                    {
                        // if end of the string is reached  
                        // add temp to palList 
                        palList.Add(partialResult);
                    }
                    // temp is reinitialize with the  
                    // current i. 
                    partialResult = new List<String>(current);
                }
             }

            return palList;
            
        }

        //static bool isPalindrome(string s, int left, int right)
        //{
        //    while (left < right)
        //    {
        //        if (s[left++] != s[right--]) return false;
        //    }
        //    return true;
        //}


        static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

    }
}
