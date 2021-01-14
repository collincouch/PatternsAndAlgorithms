using System;
using IK.Utils;

namespace IK.Trees.DepthFirst
{
    //Leet code 543
    public class DiameterOfBinaryTree
    {
        public DiameterOfBinaryTree()
        {
        }

        int maxDiameter = 0;

        public int getMaxDiameterOfTree(TreeNode root)
        {
            maxDiameter = 0;

            if (root == null) return maxDiameter;

            getSubtreeDiameter(root);

            return maxDiameter;
        }

        private int getSubtreeDiameter(TreeNode node)
        {
            //Base Case leaf node (return zero)
            if (node.left_ptr == null && node.right_ptr == null)
                return 0;

            //recursive


            //init lH, rH, myD = 0
            int lH=0, rH=0, myD = 0;


            //if( left child, then lH = dfs(node.left+ 1)
            if (node.left_ptr != null) lH = getSubtreeDiameter(node.left_ptr) + 1;

            //if(right child, rH = dfs(node.right + 1)
            if (node.right_ptr != null) rH = getSubtreeDiameter(node.right_ptr) + 1;


            //myD = lH + rH
            myD = lH + rH;


            //maxDiameter = max(myD,maxDiameter)
            maxDiameter = Math.Max(myD, maxDiameter);


            return Math.Max(lH, rH);
        }

    }
}
