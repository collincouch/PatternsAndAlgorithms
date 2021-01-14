using System;
using IK.Utils;

namespace IK.Trees.DepthFirst
{
    //Leet code 250
    public class CountUnivalueSubstrees
    {
        public CountUnivalueSubstrees()
        {
        }

        int uCount = 0;

        public int getUnivalueSubtreeCount(TreeNode root)
        {
            uCount = 0;

            if (root == null) return uCount;

            getSubtreeUval(root);

            return uCount;
        }


        private bool getSubtreeUval(TreeNode node)
        {
            //base case (leaf)
            //increment uCount
            //return true
            if (node.left_ptr==null && node.right_ptr==null)
            {
                uCount++;
                return true;
            }



            //recursion

            //init lU, rU, myU = true
            bool lU = true, rU = true, myU = true;

            //if left child
                //lU = dfs(node.left)
            if(node.left_ptr!=null)
            {
                lU = getSubtreeUval(node.left_ptr);
                myU = (node.val==node.left_ptr.val) && lU;
            }

            //if right child
                //rU = dfs(node.right)
            if(node.right_ptr!=null)
            {
                rU = getSubtreeUval(node.right_ptr);
                myU = myU && (node.val ==node.right_ptr.val) && rU;
            }

          

            //if yes, then increment uCount
            if (myU) uCount++;
            //return myU
            return myU;
        }
    }
}
