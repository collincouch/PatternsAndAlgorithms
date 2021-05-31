using System;
using System.Collections.Generic;
using IK.Amazon;
using IK.Amazon.Recursion;
using IK.DesignPatterns.IKPracticeProblems.TicTacToe;
using IK.Graphs.IKTests;
using IK.Graphs.LectureProblems;
using IK.Graphs.Leet;
using IK.LeetCodeChallenges;
using IK.LeetCodeChallenges.Dec;
using IK.Recursion.IKPracticeProblems;
using IK.Recursion.Leet;
using IK.Sorting.IKPracticeProblems;
using IK.Sorting.IKPracticeProblems.IKTests;
using IK.Sorting.IKTests;
using IK.Sorting.Leet;
using IK.Trees.Leet;
using IK.Utils;
using static IK.LeetCodeChallenges.Dec.Week3;

namespace IK
{
	class MainClass
	{
		#region Sorting
		public enum SortingProblems
		{
			DutchFlag = 0,
			MergeTwoArrays = 1,
			GroupTheNumbers=2,
		}
        ////Dutch Flag


        //List<char> flagArray = new List<char>(){
        //		'G',
        //		'R',
        //	};

       






        #endregion



        #region Graphs
        public enum GraphProblems
        {
			CourseSchedule = 0,
			GraphValidTree=1,
			IsGraphBipartite=2,
			NumberOfConnectedComponents=3,
			SnakesAndLadders=4
        }
        #endregion
        public static void Main(string[] args)
		{
            IK.Graphs.Leet.GraphValidTree gvt = new IK.Graphs.Leet.GraphValidTree();
            //[[0,1],[1,2],[3,4]]
            //[[0,1], [1,2], [2,3], [1,3], [1,4]]
            int[][] jaggedArray3 =
                {
                    new int[] {0,1},
                   new int[] {1,2},
                   new int[] {2,3},
                   new int[] {1,3},
                   new int[] {1,4},
                };


            //Combine
            Combinations comb = new Combinations();
            var result = comb.Combine(4, 2);
            Console.Write("result",result);

            //var result = gvt.ValidTree(5, jaggedArray3);

            //int[][] jja =
            //{
            //    new int[]{19,20},
            //    new int[]{1,10},
            //    new int[]{5,14},


            //};
            //MeetingRoomsII mm2 = new MeetingRoomsII();

            //var result = mm2.MinMeetingRooms(jja);

            //DutchFlag.Sort_RecursiveString()

            //CombinationsSumII cc2 = new CombinationsSumII();
            //var result = cc2.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);


            //Week3 w3 = new Week3();

            ////ListNode ln3 = new ListNode(3);
            //ListNode ln2 = new ListNode(9);
            //ListNode ln1 = new ListNode(9, ln2);
            //var result = w3.PlusOne(ln1);

            //NQueens nq = new NQueens();
            //var result = nq.SolveNQueens(8);



            //NAryTreeLevelOrderTraversal nt = new NAryTreeLevelOrderTraversal();
            //Node root = new Node();

            //root.val = 1;
            //root.children = new List<Node>()
            //{
            //    new Node() {
            //        val = 3,
            //        children=new List<Node>()
            //        {
            //            new Node() { val = 5 },
            //            new Node() { val = 6 }
            //        }
            //    },
            //    new Node(){val=2},
            //    new Node(){val=4}
            //};




            //var result = nt.LevelOrder(root);


            //BinaryTreeRightSideView bsv = new BinaryTreeRightSideView();
            //Trees.Leet.TreeNode node = new Trees.Leet.TreeNode();

            //node.val = 0;
            //node.left = new Trees.Leet.TreeNode()
            //{
            //    val = 2,
            //    left = new Trees.Leet.TreeNode()
            //    {
            //        val = 1,
            //        left = new Trees.Leet.TreeNode()
            //        {
            //            val = 5
            //        },
            //        right = new Trees.Leet.TreeNode()
            //        {
            //            val = 1
            //        }
            //    }
            //};
            //node.right = new Trees.Leet.TreeNode()
            //{
            //    val = 4,
            //    left = new Trees.Leet.TreeNode()
            //    {
            //        val=3,
            //        right = new Trees.Leet.TreeNode()
            //        {
            //            val = 6
            //        }
            //    },
            //    right = new Trees.Leet.TreeNode()
            //    {
            //        val = -1,
            //        right = new Trees.Leet.TreeNode()
            //        {
            //            val = 8
            //        }
            //    }
            //};

            //bsv.RightSideView(node);


            //BinaryTreeZigZagLevelOrderTraversal btzz = new BinaryTreeZigZagLevelOrderTraversal();

            //btzz.ZigzagLevelOrder(node);
            //         Console.Write("test");

            //var result = w3.SortedSquares(new int[] { -7, -3, 2, 3, 11 });

            //Repay.MaxValWithFive rp = new Repay.MaxValWithFive();
            //var result = rp.solution(-999);

            //GenerateParentheses gp = new GenerateParentheses();
            //var result = gp.GenerateParenthesis(3);

            //SubsetsII ss2 = new SubsetsII();
            //var result = ss2.SubsetsWithDup(new int[] { 1, 2, 2 });

            //PermutationsII p = new PermutationsII();
            //var result = p.PermuteUnique(new int[] { 1, 2, 3 });

            //LetterCombinationsOfAPhoneNumber lcp = new LetterCombinationsOfAPhoneNumber();
            //var result = lcp.LetterCombinations("2");

            //Subsets ss = new Subsets();
            //var result = ss.Subsets1(new int[] { 1, 2, 3 });

            //LetterCasePermutation lcp = new LetterCasePermutation();

            //var result = lcp.LetterCasePermutation1("a1b2");

            //         List<char> flagArray = new List<char>(){
            //		'G', 'B', 'G', 'G', 'R', 'B', 'R', 'G'
            //	};

            //DutchFlagTwo.dutch_flag_sort(flagArray);




            //KthLargestElementInAStream k = new KthLargestElementInAStream(7,new int[] { -10,1,3,1,4,10,3,9,4,5,1 });

            //var x = k.Add(3);
            //var result = k.Add(2);




            //var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("pwwkew");

            //KthLargestElementInAnArray kLarg = new KthLargestElementInAnArray();

            //var result = KthLargestElementInAnArray.FindKthLargest(new int[] { 3,2,3,1,2,4,5,5,6 }, 4);

            //KClosestPointsToOrgin kclosestToOrgin = new KClosestPointsToOrgin();
            //int[][] points = new int[][]
            //         {
            //             new int[] { 3, 3},
            //             new int[] { 5, -1},
            //	new int[] { -2, 4},
            //};
            //var result = kclosestToOrgin.KClosest(points, 2);

            //List<List<int>> neighbors = new List<List<int>>();
            //neighbors.Add(new List<int> { 1, 1});
            //neighbors.Add(new List<int> { 0, 1 });
            //neighbors.Add(new List<int> { 1, 0 });
            //NearestNeighbor.nearest_neighbours(0, 0, 2, neighbors);

            //List<long> f_billion = new List<long>() { 5, 2, 1, 3, 0 };
            //var result = FourBillion.find_integer(f_billion);


            //var result = TowerOfHanoi.tower_of_hanoi(4);

            //var result = TwoSum.GetTwoSumIndices(new int[] { 3,3 }, 6);
            //var result = Sorting.Leet.ThreeSum.GetThreeSum(new int[] { -2,0,0,2,2});



            //int[] arr = new int[] { 8, 4, 9, 5, 2, 9, 5, 7, 10 };
            ////GroupingTheNumbers.solve(arr);

            //TopK.topK(arr, 5);

            //int[][] graph = new int[][]
            //{
            //	new int[] { 1, 3},
            //	new int[] { 0, 2},
            //	new int[] { 1, 3},
            //	new int[] { 0, 2},
            //};
            //IsGraphBipartite.IsBipartite(graph);

            //Console.WriteLine("Hello World!");

            //string[] dictionary = new string[3] {"caa", "aaa", "aab"};
            //OrderOfCharactersInAlienDictionary.find_order(dictionary);



            //int[] input1 = new int[7] {20,5, 2, 9,1,3,4 };

            //new string[7] { "R", "B", "G", "G", "R", "B", "B" };
            //QuickSort.Sort_Recursive(input1,0,input1.Length-1);
            //var returnVal = Solution.SortArray(input1);

            //int kLargest = KLargest.GetKLargest(input1, 3);

            //QuickSort.Sort_RecursiveString(input2,0,input2.Count-1);

            //int[] ary1 = new int[1] { 1 };

            //int[] ary2 = new int[2] { 2, 0 };

            //MergeTwoArrays.merger_first_into_second(ary1, ary2);

            //Recursion.ChessBoardDriver(8);
            //Console.Write("test");

            //Recursion.generate_all_expressions("123", 11);

            //int[][] jaggedArray3 =
            //	{
            //		new int[] { 6,10,15},
            //		new int[] { 7,9,18 },
            //		//new int[] { 11,10,9,0 }
            //	};

            //MergeKSortedArrays.mergeArrays(jaggedArray3);

            //PalindromicDecomposition.generate_palindromic_decompositions("aab");

            //TopK.topK(new int[5] { 1, 5, 4, 4, 2 },2);

            //ThreeSum.findZeroSum(new int[4] { -2, 2, 0, -2 });

            //PossibleToAcheiveSum.check_if_sum_possible(new long[3] { 2, 4, 8 }, 6);
            //WellFormedBrackets.find_all_well_formed_brackets(3);

            //SubsetOfASet.generate_all_subsets("");
            //string[] lexArray = new string[4] { "akshay 1", "akshay 11", "akshay 111", "akshay 1111" };
            //new string[5] { "key1 abcd", "key2 zzz", "key1 hello", "key3 world", "key1 hello" }
            //LexicographicalSort.solve(lexArray);

            //TreeNode root10 = new TreeNode(10);
            //TreeNode t20 = new TreeNode(20);
            //TreeNode t40 = new TreeNode(40);
            //TreeNode t50 = new TreeNode(50);
            //TreeNode t30 = new TreeNode(30);

            //root10.left_ptr = t20;
            //root10.right_ptr = t30;
            //t20.left_ptr = t40;
            //t20.right_ptr = t50;
            //PrintAllPathsOfATree.binaryRecursion(root10);

            //TicTacToe.TestTicTacToe();
            Console.Write("test");
		}
	}

	public static class Solution
	{
		public static int[] SortArray(int[] nums)
		{

			mergeSort(nums, 0, nums.Length - 1);

			return nums;

		}

		static void mergeSort(int[] ary, int lIdx, int rIdx)
		{
			//the exit plan :)
			if (lIdx >= rIdx)
				return;

			//get middle pointer
			int mIdx = lIdx + (rIdx - lIdx) / 2;
			//get random index

			//divide left
			mergeSort(ary, lIdx, mIdx);

			//divide right
			mergeSort(ary, mIdx + 1, rIdx);

			merge(ary, lIdx, mIdx, rIdx);
		}




		static void merge(int[] ary, int lIdx, int mIdx, int rIdx)
		{
			int[] temp = new int[ary.Length];
			int i = lIdx;
			int j = mIdx + 1;
			int k = lIdx;

			//need to copy one array into another and therefore allocate space
			//O(n)
			Array.Copy(ary, temp, ary.Length);

			Console.Write(temp);

			while (i <= mIdx && j <= rIdx)
			{


				if (temp[i] <= temp[j])
				{
					ary[k] = temp[i];
					i++;
				}
				else
				{
					ary[k] = temp[j];
					j++;
				}

				k++;
			}



			while (i <= mIdx)
			{
				ary[k] = temp[i];
				i++;
				k++;
			}

			while (j <= rIdx)
			{
				ary[k] = temp[j];
				j++;
				k++;

			}


		}


	}

	static class SortingProblems{


	}
}
