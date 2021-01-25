using System;
using IK.Trees.Leet;

namespace IK.Trees.IKPracticeProblems
{
    public class ConvertBinaryTreeToCircularDoubleLinkedList
    {
        public static TreeNode BTtoLL(TreeNode root)
        {

            inOrderDFSHelper(root);

            return root;
        }

        //I'll do an in order traveral and update the left and right pointers
        //to get the circular double linked list
        private static void inOrderDFSHelper(TreeNode node)
        {

            //base case
            if(node.left==null && node.right==null)
            {
                return;
            }


            //recursion
            //get the root
            //TreeNode rootNode 
            //if(node.left==null)


        }
    }
}
