using System;
using System.Collections.Generic;
using System.Text;

namespace IK.Amazon
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int result=0;
            char[] arrS = s.ToCharArray();
            if(arrS.Length>0)
            {
                for(int i=0;i< arrS.Length;i++)
                {
                    //if (i != 0 && arrS[i] == arrS[i - 1])
                    //    continue;
                    int log = longestSubstring(arrS, i);
                    if (log > result)
                        result = log;
                }
                
            }    
            return result;
        }


        static int longestSubstring(char[] s, int startIndx)
        {
            int longestCount = 1;
            Dictionary<int, char> charactersSoFar = new Dictionary<int, char>();

            charactersSoFar.Add(0, s[startIndx]);
            int j = startIndx+1;
            while(j<=s.Length-1)
            {

                if (!charactersSoFar.ContainsValue(s[j])) {
                    charactersSoFar.Add(j, s[j]);
                    longestCount++;
                }
                else
                {
                    return longestCount;
                }
                j++;
            }

            return longestCount;
        }
    }
}
