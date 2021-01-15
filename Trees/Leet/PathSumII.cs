using System;
using System.Collections.Generic;

namespace IK.Trees.Leet
{
    public class PathSumII
    {
        List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {

            if (root == null)
                return result;

            dfsHelper(root, sum, new List<int>());

            return result;
           
        }

        //T(n) = O(n log n)
        //S(n) = O(n log n)

        private void dfsHelper(TreeNode node, int target, List<int> slate)
        {

            //base case when we are are at the leaf level node

            if(node.left==null && node.right==null)
            {
                if(node.val==target)
                {
                    slate.Add(node.val);
                    result.Add(new List<int>(slate));
                    slate.RemoveAt(slate.Count - 1);
                }

                return;
            }


            //recursion
            slate.Add(node.val);
            if (node.left != null)
                dfsHelper(node.left, target - node.val, slate);

            if (node.right != null)
                dfsHelper(node.right, target - node.val, slate);
            slate.RemoveAt(slate.Count - 1);
        }
    }
}
