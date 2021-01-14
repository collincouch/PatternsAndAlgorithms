using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace IK.Recursion.LectureProblems
{
    //Print all decimal numbers with n digits in ascending order
    //N = 2
    //Output 
    public static class Recursion
    {
        public static void driver(int numDig)
        {
            helper(numDig, new StringBuilder());
        }

        static void helper(int numDig, StringBuilder soFar)
        {
            if (numDig == 0)
            {
                Console.Write(soFar.ToString() + "\n");
            }
            else
            {
                for (int val = 0; val <= 9; val++)
                {
                    soFar.Append(val);
                    helper(numDig - 1, soFar);
                    soFar.Remove(soFar.Length - 1, 1);
                }
            }
        }

        static void helperSubset(int[] input, int idx, StringBuilder soFar)
        {
            if (idx == input.Length)
            {
                Console.Write(soFar.ToString() + "\n");
            }
            else
            {
                helperSubset(input, idx + 1, soFar);//exclude

                //include
                soFar.Append(input[idx]);
                helperSubset(input, idx + 1, soFar);
                soFar.Remove(soFar[idx], 1);
            }
        }

		static void helperPermutation(int[] input, int idx, StringBuilder soFar)
		{
			if (idx == input.Length)
			{
				Console.Write(soFar.ToString() + "\n");
			}
			else
			{
                for (int i = idx; i < input.Length;i++)
                {
                    SwapInts(input,idx,i);
                    soFar.Append(input[idx]);
                    helperPermutation(input,idx+1,soFar);
                    soFar.Remove(soFar[idx] - 1, 1);
                    SwapInts(input,idx,i);
                }
				
				
			}
		}

		static void helperPermutationNoDublicates(int[] input, int idx, StringBuilder soFar)
		{
			if (idx == input.Length)
			{
				Console.Write(soFar.ToString() + "\n");
			}
			else
			{
                Dictionary<int, int> cache = new Dictionary<int, int>();
				for (int i = idx; i < input.Length; i++)
				{
                    if (cache.ContainsKey(input[i]))//check for dups
                        continue;
                    
                    cache.Add(i,input[idx]);
					SwapInts(input, idx, i);
					soFar.Append(input[idx]);
					helperPermutation(input, idx + 1, soFar);
					soFar.Remove(soFar[idx] - 1, 1);
					SwapInts(input, idx, i);
				}


			}
		}


		static void SwapInts(int[] array, int position1, int position2)
		{
			int temp = array[position1]; // Copy the first position's element
			array[position1] = array[position2]; // Assign to the second element
			array[position2] = temp; // Assign to the first element
		}


		public static void diceDriveProbem(int numOfDice, int targetSum)
		{
            helperDice(numOfDice, targetSum, 0,new StringBuilder());
		}


        static void helperDice(int numOfDice, int targetSum, int runningSum, StringBuilder soFar){
            //runningSum + numDice*1>targetSum
            //runningSum * 6<targetSum

            if(runningSum + numOfDice * 1>targetSum)
            {
                return;
            }
			if (runningSum * 6 < targetSum)
			{
				return;
			}
            if (runningSum > targetSum)
                return;

            if (numOfDice == 0)
            {
                if(runningSum==targetSum)
                {
                    Console.Write(soFar.ToString() + "\n");
                }
            }
            else
            {
                for (int val = 1; val <= 6; val++)
                {
                    soFar.Append(val);
                    helperDice(numOfDice-1,targetSum,runningSum+val,soFar);
                    soFar.Remove(soFar.Length-1,1);
                }
            }


        }

        public static void ParensDriver(int numOfParens)
        {
            HelperParens(numOfParens,numOfParens, new StringBuilder());
        }


		static void HelperParens(int remainingOpen, int remainingClosed, StringBuilder soFar)
		{
			//runningSum + numDice*1>targetSum
			//runningSum * 6<targetSum

			if (remainingOpen > remainingClosed)
				return;

			if (remainingOpen == 0 && remainingClosed == 0)
			{

				Console.Write(soFar.ToString() + "\n");

			}
			else
			{
                if (remainingOpen > 0)
                {
                    soFar.Append("(");
                    HelperParens(remainingOpen - 1, remainingClosed, soFar);
                    soFar.Remove(soFar.Length - 1, 1);
                }

                if (remainingClosed > 0)
                {
                    soFar.Append(")");
                    HelperParens(remainingOpen, remainingClosed - 1, soFar);
                    soFar.Remove(soFar.Length - 1, 1);
                }
			}

			
		}


		public static void ChessBoardDriver(int boardSize)
		{
            HelperChessBoard(boardSize, 0, new List<int>());
		}


		static void HelperChessBoard(int boardSize,int currRow,List<int> soFar)
		{
			//runningSum + numDice*1>targetSum
			//runningSum * 6<targetSum

            if (currRow==boardSize)
				Console.Write(soFar.ToString() + "\n");
			else
			{
                for (int col = 0; col < boardSize;col++)
                {
                    if (isSafeToPlaceQueenAt(soFar, currRow, col))
                    {
                        soFar.Add(col);
                        HelperChessBoard(boardSize, currRow + 1, soFar);
                        soFar.Remove(soFar.Count - 1);
                    }
                }
			}

		}

        static bool isSafeToPlaceQueenAt(List<int> board,int row2,int col2)
        {
            foreach(int col1 in board)
            {
                if (col1 == col2)
                    return false;
                
            }

            for (int row1 = 0; row1 < board.Count;row1++)
			{
                int xDist = Math.Abs(row1 - row2);
                int yDist = Math.Abs(col2 - board.Find(x => x.Equals(row1)));

                if (xDist == yDist)
                    return false;


			}


            return true;
                
        }

        public static string[] generate_all_expressions(string s, long target)
        {
            char[] nums = s.ToArray();
            List<string> result = new List<string>();
            var test = generate_all_expressions_helper(nums, target, 0, 0,0,result);
            return test;

          
        }

        static string[] generate_all_expressions_helper(char[] numAry, long target, int evaluated, int idx, int previous,List<string> soFar)
        {
            string curr;
            int curr_int;
            List<string> result = new List<string>();

            if(idx==numAry.Length)
            {
                if (evaluated == target)
                {
                    result.Add(soFar.ToString());
                   
                }
              
            }
           
            for (int i = idx; i < numAry.Length-1; i++)
            {
                curr = numAry[i].ToString();
                curr_int = int.Parse(curr);
                if (idx == 0) {
                    soFar.Add(numAry[curr_int].ToString());
                    generate_all_expressions_helper(numAry, target, curr_int, i+1, curr_int,soFar);
                    soFar.RemoveAt(0);

                }
                else
                {
                    soFar.Add("*" + curr);
                    generate_all_expressions_helper(numAry, target, (evaluated - previous) + (previous * curr_int), i + 1, previous * curr_int, soFar);
                    soFar.RemoveAt(0);
                }
            }

            return result.ToArray();
            
        }

    }

}
