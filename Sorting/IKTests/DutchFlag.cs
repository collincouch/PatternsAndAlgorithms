using System;
using System.Collections.Generic;
namespace IK.Sorting.IKPracticeProblems.IKTests
{
    public static class DutchFlag
    {
		public static void Sort_RecursiveString(List<char> ary)
		{

			PartitionChars(ary);

		}
		

		static void SwapChar(List<char> array, int position1, int position2)
		{
			char temp = array[position1]; // Copy the first position's element
			array[position1] = array[position2]; // Assign to the second element
			array[position2] = temp; // Assign to the first element
		}

		static void PartitionChars(List<char> ary)
		{

			//It's RGB
			int i = 0;//low  the red pointer
			int j = 0;//med  the green pointer
			int k = ary.Count - 1;//high the blue pointer

			while (j <= k)
			{
				if (ary[j] == 'R')
				{
					SwapChar(ary, j, i);
					i++;
					j++;
				}
				else if (ary[j] == 'G')
				{
					j++;
				}
				else//It's a 'B'
				{
					SwapChar(ary, j, k);
					k--;
				}
			}

		
		}

	}
}
