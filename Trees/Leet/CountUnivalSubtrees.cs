using System;
namespace IK.Trees.Leet
{

    //Leet 250 
    public class CountUnivalSubtrees
    {
        int globalCount = 0;
        public int CountUnivalSubtrees1(TreeNode root)
        {

            if (root == null)
                return globalCount;


            dfsHelper(root);

            return globalCount;
        }


        private  bool dfsHelper(TreeNode node)
        {
            bool amIUnival = true;
            //Base Case
            if (node.left == null && node.right == null)
            {
                globalCount += 1;
                return true;
            }


            //recursive
            if (node.left != null)
            {
                bool bl = dfsHelper(node.left);
                if (bl == false || (node.val != node.left.val))
                    amIUnival = false;
            }

            //recursive
            if (node.right != null)
            {
                bool bl = dfsHelper(node.right);
                if (bl == false || (node.val != node.right.val))
                    amIUnival = false;
            }

            if (amIUnival == true)
                globalCount += 1;

            return amIUnival;


        }
    }
}
