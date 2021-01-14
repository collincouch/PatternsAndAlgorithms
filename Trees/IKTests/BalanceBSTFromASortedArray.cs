using System;
using IK.Utils;

namespace IK.Trees.IKTests
{
    public class BalanceBSTFromASortedArray
    {
        static TreeNode build_balanced_bst(int[] a)
        {

            //base case
            //when end < start
            //no elements


            // get middle index

            //left is less than than midle
            //right is greater than middle


            //get middle of left
            //create binary search tree


            //get middel of right
            //create binary search tree


            return helper(a, 0, a.Length - 1);
        }

        static TreeNode helper(int[] a, int start, int end)
        {
            if (end < start)
                return null;

            if (end == start)
                return new TreeNode(a[start]);

            int mid = start + end / 2;

            var root = new TreeNode(a[mid]);

            root.left_ptr = helper(a, start, mid - 1);

            root.right_ptr = helper(a, mid + 1, end);

            return root;

        }
    }
}
