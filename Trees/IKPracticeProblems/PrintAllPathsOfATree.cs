using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Trees.IKPracticeProblems
{
    public class PrintAllPathsOfATree
    {


        static List<List<int>> result = new List<List<int>>();

        static List<List<int>> allPathsOfABinaryTree(TreeNode root)
        {

            if (root == null)
                return result;


            dfsHelper(root, new List<int>());

            return result;
        }

        private static void dfsHelper(TreeNode node,List<int> slate)
        {
            //base case
            if (node.left_ptr == null && node.right_ptr == null)
            {
                slate.Add(node.val);
                result.Add(new List<int>(slate));
                slate.RemoveAt(slate.Count - 1);

            }


            //recursive case
            slate.Add(node.val);
            if (node.left_ptr != null)
                dfsHelper(node.left_ptr, slate);

            if (node.right_ptr != null)
                dfsHelper(node.right_ptr, slate);

            slate.RemoveAt(slate.Count - 1);

                

        }
    }
}
