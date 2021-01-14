using System;
using System.Collections.Generic;
namespace IK.Utils
{
    public static class QuickSort
    {

        public static void Sort_Recursive(int[] ary,int lIndx, int rIndx)
        {

            if (lIndx >= rIndx)
                return;


            int partitionIndx = Partition(ary,lIndx,rIndx);

            //Partition Left side
            Sort_Recursive(ary,lIndx,partitionIndx-1);

			//Partition Right side
            Sort_Recursive(ary, partitionIndx + 1, rIndx);



        }

		public static void Sort_Recursive(string[] ary, int lIndx, int rIndx)
		{

			if (lIndx >= rIndx)
				return;


			int partitionIndx = Partition(ary, lIndx, rIndx);

			//Partition Left side
			Sort_Recursive(ary, lIndx, partitionIndx - 1);

			//Partition Right side
			Sort_Recursive(ary, partitionIndx + 1, rIndx);



		}

		public static void Sort_Recursive(long[] ary, int lIndx, int rIndx)
		{

			if (lIndx >= rIndx)
				return;


			int partitionIndx = Partition(ary, lIndx, rIndx);

			//Partition Left side
			Sort_Recursive(ary, lIndx, partitionIndx - 1);

			//Partition Right side
			Sort_Recursive(ary, partitionIndx + 1, rIndx);



		}



		static void SwapInts(int[] array, int position1, int position2)
		{
			int temp = array[position1]; // Copy the first position's element
			array[position1] = array[position2]; // Assign to the second element
			array[position2] = temp; // Assign to the first element
		}

		static void SwapLongs(long[] array, int position1, int position2)
		{
			long temp = array[position1]; // Copy the first position's element
			array[position1] = array[position2]; // Assign to the second element
			array[position2] = temp; // Assign to the first element
		}

		static void SwapStrings(string[] array, int position1, int position2)
		{
			string temp = array[position1]; // Copy the first position's element
			array[position1] = array[position2]; // Assign to the second element
			array[position2] = temp; // Assign to the first element
		}




		// Generates a random number within a range.      
		static int GetRandomIndex(int min, int max)
		{
			Random _random = new Random();
			return _random.Next(min, max);
		}

        static int Partition(int[] ary, int lIdx,int rIdx){

			    
            int i = lIdx + 1;
            int j = lIdx + 1;

            while(j<=rIdx)
            {
                if (ary[j] < ary[lIdx])
                {
                    SwapInts(ary, j, i);
                    i++;
                    j++;
                }
                else
                    j++;

            }

			SwapInts(ary, i - 1, lIdx);


			return i - 1;
        }

		static int Partition(long[] ary, int lIdx, int rIdx)
		{

			//Get pivot index as middle index
			//int piviot = ary.Length / 2;

			int i = lIdx + 1;
			int j = lIdx + 1;

			while (j <= rIdx)
			{
				if (ary[j] < ary[lIdx])
				{
					SwapLongs(ary, j, i);
					i++;
					j++;
				}
				else
					j++;

			}

			SwapLongs(ary, i - 1, lIdx);


			return i - 1;
		}

		static int Partition(string[] ary, int lIdx, int rIdx)
		{

			//Get pivot index as middle index
			//int piviot = ary.Length / 2;

			

			int i = lIdx + 1;
			int j = lIdx + 1;

			while (j <= rIdx)
			{
				if (ary[j].CompareTo(ary[lIdx])>0)
				{
					SwapStrings(ary, j, i);
					i++;
					j++;
				}
				else
					j++;

			}

			SwapStrings(ary, i - 1, lIdx);


			return i - 1;
		}


		//R,G,B
		//if jValue is B

		static bool NeedtoSwap(char jValue, char lIdexValue)
        {
            bool retValue = false;
            switch (jValue)
			{
				case 'B':
                    if (lIdexValue == 'R' || lIdexValue == 'G')
                    {
                        retValue = true;
                    }
					break;
				case 'G':
					if (lIdexValue == 'R')
					{
						retValue = true;
					}
					break;
				default:
					
					break;
			}
            return retValue;
        }

		static int PartitionEvenOdd(int[] ary, int lIdx, int rIdx)
		{

			//Get pivot index as middle index
			//int piviot = ary.Length / 2;

			int i = lIdx + 1;
			int j = lIdx + 1;

			while (j <= rIdx)
			{
				if (ary[j]%2==0)
				{
					SwapInts(ary, j, i);
					i++;
					j++;
				}
				else
					j++;

			}

			SwapInts(ary, i - 1, lIdx);


			return i - 1;
		}
    }



   
}
