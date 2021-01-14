using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Trees.DepthFirst
{

    //Leet code #113
    public class PathSumTwo
    {
        public PathSumTwo()
        {
        }

        //bool psFlag = false;
        List<List<int>> psResult = new List<List<int>>();
        public List<List<int>> getPathSum(TreeNode root, int target)
        {
            psResult.Clear();
            if (root == null) return psResult;

            //getPathSumDFS(root, target,rSum:0, psResult);

            return psResult;
        }


        private void getPathSumDFS(TreeNode node, int target, int rSum,Stack<int> slate)
        {





            rSum += node.val;

            slate.Push(node.val);

            //base case: leaf node
            if (node.left_ptr == null && node.right_ptr == null)
            {
                if (target == rSum) psResult.Add(new List<int>(slate));
                return;
            }
            if (node.left_ptr != null) getPathSumDFS(node.left_ptr, target, rSum,slate);
            if (node.right_ptr != null) getPathSumDFS(node.right_ptr, target, rSum,slate);

            slate.Pop();
        }
    }
}
