using System;
using IK.Utils;

namespace IK.Trees.DepthFirst
{
   //Leet Code #112
    public class PathSum
    {
        public PathSum()
        {
        }

        bool psFlag = false;
        public bool getPathSum(TreeNode root, int target)
        {
            psFlag = false;

            if (root == null) return psFlag;

            getPathSumDFS(root ,target,rSum:0);

            return psFlag;
        }


        private void getPathSumDFS(TreeNode node, int target, int rSum)
        {
            if (psFlag) return;

            rSum += node.val;

            //base case: leaf node
            if(node.left_ptr==null && node.right_ptr==null)
            {
                if (target == rSum) psFlag = true;
                return;
            }
            if (node.left_ptr != null) getPathSumDFS(node.left_ptr, target, rSum);
            if (node.right_ptr != null) getPathSumDFS(node.right_ptr, target, rSum);
        }
       
    }
}
