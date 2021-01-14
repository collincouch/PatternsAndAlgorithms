using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Trees.IKPracticeProblems
{
    public class PrintAllPathsOfATree
    {



        public static void binaryRecursion(TreeNode node, List<List<int>> result, List<int> pathToLeaf)
        {


            //base case
            if (node.left_ptr == null && node.right_ptr == null)
            {
                //we are at leaf
                pathToLeaf.Add(node.val);
                result.Add(pathToLeaf);
                pathToLeaf.RemoveAt(pathToLeaf.Count - 1);
                return;
            }

            pathToLeaf.Add(node.val);

            //go left
            if (node.left_ptr != null)
                binaryRecursion(node.left_ptr, result, pathToLeaf);

            //go right
            if (node.right_ptr != null)
                binaryRecursion(node.right_ptr, result, pathToLeaf);



            pathToLeaf.Remove(pathToLeaf.Count - 1);





        }
    }
}
