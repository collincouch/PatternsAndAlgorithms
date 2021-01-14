using System;
using System.Collections.Generic;
using System.Linq;
using IK.Utils;

namespace IK.Sorting.IKPracticeProblems
{
    public class LexicographicalSort
    {
        public static string[] solve(string[] arr)
        {
            /*
             * Write your code here.
             */

            Dictionary<string, string> lexoDict = new Dictionary<string, string>();
            QuickSort.Sort_Recursive(arr, 0, arr.Length - 1);
            var keyLex = new string[2];
            string[] valueLex = new string[2];
            var value="";
            var count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                //split string on the space
                keyLex = arr[i].Split(' ');
                //add key to dict if it doesn't exist
                if(lexoDict.ContainsKey(keyLex[0]))
                {
                    //update count
                    if (lexoDict.TryGetValue(keyLex[0], out value))
                    {
                        //get count 
                        valueLex = value.Split(',');
                        count = int.Parse(valueLex[0]);
                        count ++;
                        lexoDict[keyLex[0]] = string.Format("{0},{1}", count.ToString(), valueLex[1]);
                    }
                }
                else
                {
                    //add key count and value
                    lexoDict.Add(keyLex[0], string.Format("1,{0}", keyLex[1]));
                }


            }


            string[] result = new string[lexoDict.Count]; 

            result = lexoDict.Select(x => (x.Key + ":" + x.Value)).ToArray();

            return result;
        }
    }
}
