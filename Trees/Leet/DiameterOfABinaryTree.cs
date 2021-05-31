using System;
using System.Collections.Generic;

namespace IK.Trees.Leet
{
    public class DiameterOfABinaryTree
    {

        //T(n) = O(n)
        //S(n) = O(n)
        public DiameterOfABinaryTree()
        {
        }

        int golbalDiameter = 0;

        public int GetDiameter(TreeNode node)
        {
            if (node == null)
                return 0;

            dfsHelper(node);

            return golbalDiameter;
        }


        private int dfsHelper(TreeNode node)
        {
            int rh=0;
            int lh=0;
            //base case when we are are at the leaf level node
            if (node.left == null && node.right == null)
            {
                return 0;
            }


            //recursion: internal node
            int mydia = 0;
            if (node.left != null)
            {
                lh = dfsHelper(node.left);
                mydia += lh + 1;
            }
               
           
            if (node.right != null)
            {
                rh = dfsHelper(node.right);
                mydia += rh + 1;
            }

            //compute local solution
            golbalDiameter = Math.Max(golbalDiameter, mydia);

            //compute my own height
            return Math.Max(lh, rh);
        }
    }
}
