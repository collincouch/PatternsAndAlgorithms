using System;
using System.Collections.Generic;
namespace IK.Recursion.IKTests
{
    public class WellFormedBrackets
    {
        public static string[] find_all_well_formed_brackets(int n)
        {
            List<string> partialSol = new List<string>();

            int numOfParens = n;

            HelperParens(numOfParens, numOfParens,partialSol, new System.Text.StringBuilder());

            string[] retVal = partialSol.ToArray();

            return retVal;
        }


        static void HelperParens(int remainingOpen, int remainingClosed, List<string> partialSol, System.Text.StringBuilder soFar)
        {

            if (remainingOpen > remainingClosed)
                return;

            if (remainingOpen == 0 && remainingClosed == 0)
            {
                partialSol.Add(soFar.ToString());
                //Console.Write(soFar.ToString() + "\n");

            }
            else
            {
                if (remainingOpen > 0)
                {
                    soFar.Append("(");
                    HelperParens(remainingOpen - 1, remainingClosed,partialSol, soFar);
                   soFar.Remove(soFar.Length - 1, 1);
                }

                if (remainingClosed > 0)
                {
                    soFar.Append(")");
                    HelperParens(remainingOpen, remainingClosed - 1,partialSol, soFar);
                    soFar.Remove(soFar.Length - 1, 1);
                }
            }

           

        }
    }
}
