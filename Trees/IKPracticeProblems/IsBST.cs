using System;
using IK.Utils;

namespace IK.Trees.DepthFirst
{
    public class IsBST
    {
        public  bool isBST(TreeNode root)
        {


            if (root == null)
                return true;
            bool ret;
            int min = int.MinValue;
            int max = int.MaxValue;

            ret = IsBSTHelper(root, min, max);

            return ret;
        }


        private  bool IsBSTHelper(TreeNode root, int min, int max)
        {

            if (root == null)
                return true;

            if (root.val < min || root.val > max)
                return false;

            //recursion Left
            bool isLeftBinary = true, isRightBinary = true;
            if (root.left_ptr != null)
            {
                isLeftBinary = IsBSTHelper(root.left_ptr, min, root.val);
            }
            if (root.right_ptr != null)
            {
                isRightBinary = IsBSTHelper(root.right_ptr, root.val, max);
            }

            return isLeftBinary && isRightBinary;


        }
    }
}
