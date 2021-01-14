using System;
using System.Collections.Generic;
using System.Text;

namespace IK.Amazon.Recursion
{
    public class LetterCombinationsOfAPhoneNumber
    {
        //global result
        List<string> result;
        Dictionary<char, string[]> numberLetters;

        public IList<string> LetterCombinations(string digits)
        {
            result = new List<string>();
            numberLetters = new Dictionary<char, string[]>();
            numberLetters.Add('2', new string[] { "a", "b", "c" });
            numberLetters.Add('3', new string[] { "d", "e", "f" });
            numberLetters.Add('4', new string[] { "g", "h", "i" });
            numberLetters.Add('5', new string[] { "j", "k", "l" });
            numberLetters.Add('6', new string[] { "m", "n", "o" });
            numberLetters.Add('7', new string[] { "p", "q", "r","s"});
            numberLetters.Add('8', new string[] { "t", "u", "v" });
            numberLetters.Add('9', new string[] { "w", "x", "y","z" });



            helperRecusion(digits, 0, new StringBuilder());

            return result;
        }

        //helper recursion
        private void helperRecusion(string digitsDefinition, int i, StringBuilder stringBuilderSlate)
        {
           //base case
           if(digitsDefinition.Length==i)
            {
                result.Add(stringBuilderSlate.ToString());
                return;
            }

        
            string[] charOutAry;

            numberLetters.TryGetValue(digitsDefinition[i], out charOutAry);

            for(int s = 0; s < charOutAry.Length; s++)
            {
                stringBuilderSlate.Append(charOutAry[s]);
                helperRecusion(digitsDefinition, i + 1, stringBuilderSlate);
                stringBuilderSlate.Remove(stringBuilderSlate.Length - 1, 1);
            }
            
        }

        

    }
}
