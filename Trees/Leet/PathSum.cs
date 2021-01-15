using System;
namespace IK.Trees.Leet
{
    public class PathSum
    {
        bool sumExists = false;
        public bool HasPathSum(TreeNode root, int sum)
        {

            if (root == null)
                return sumExists;

            dfs(root, sum);

            return sumExists;
        }


        //Depth First Search
        private void dfs(TreeNode node, int target)
        {


            //Base case occurs when we reach the leaf node
            if (node.left == null && node.right == null)
            {
                //if the leaf level node value equals the target, we know we've
                //found the solution
                if (target == node.val)
                    sumExists = true;

                return;
            }
                


            //recursion
            //will subtract node value from target
            if (node.left != null)
                dfs(node.left,target-node.val);

            if (node.right != null)
                dfs(node.right,target-node.val);

        }
    }
}
