using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Trees.LevelTraversal
{
    //Leet Code #199
    public class BinaryTreeRightSide
    {
        public BinaryTreeRightSide()
        {
        }

        public List<int> getLevelOrderTraversal(TreeNode root)
        {
            //initialize
            List<int> result = new List<int>();
            //edge case (null root)
            if (root == null) return null;

            //make a Q and root to it
            Queue<TreeNode> nodeQ = new Queue<TreeNode>();
            //while the Q is not empty
            int temp = 0;
            while (nodeQ.Count != 0)
            {
                //get the count of items in the Q
                int qCount = nodeQ.Count;
                //create a temp array
               //List<int> temp = new List<int>();
                //for Q count times:
                for (int i = 0; i < qCount; i++)
                {
                    //remove node from the Q
                    TreeNode node = nodeQ.Dequeue();
                    //add value to the temp arry
                    temp = node.val;
                    //add childrend to Q

                    //if left child exists, add node.left to Q
                    if (node.left_ptr != null) nodeQ.Enqueue(node.left_ptr);
                    //if right child exists, add node.right to the Q
                    if (node.right_ptr != null) nodeQ.Enqueue(node.right_ptr);
                }
                //add temp to the result
                result.Add(temp);
            }

            return result;

        }
    }
}
