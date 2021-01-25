using System;
namespace IK.Trees.Leet
{
    //108
    public class ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {


            if (nums.Length == 0)
                return null;

            var result = constructBinaryTreeHelper(nums, 0, nums.Length - 1);

            return result;

        }

        //T(n) = O(n)
        //S(n) = O(log n)
        private TreeNode constructBinaryTreeHelper(int[] ary, int startIndx, int endIndx)
        {

            //base case
            if(startIndx>endIndx)
            {
                return null;
            }

            //recursive
            int midIndx = (startIndx + endIndx) / 2;

            var rootNode = new TreeNode(ary[midIndx]);
            rootNode.left = constructBinaryTreeHelper(ary, startIndx, midIndx - 1);
            rootNode.right = constructBinaryTreeHelper(ary, midIndx + 1, endIndx);


            return rootNode;


        }

    }
}
