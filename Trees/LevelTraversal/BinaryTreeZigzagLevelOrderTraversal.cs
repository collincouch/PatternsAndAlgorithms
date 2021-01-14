using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Trees.LevelTraversal
{

    //Leet Code #103
    public class BinaryTreeZigzagLevelOrderTraversal
    {
        public BinaryTreeZigzagLevelOrderTraversal()
        {
        }

        public List<List<int>> getBinaryZigzagOrderTraversal(TreeNode root)
        {
            //initialize
            List<List<int>> result = new List<List<int>>();
            //edge case (null root)
            if (root == null) return null;

            //make a Q and root to it
            Queue<TreeNode> nodeQ = new Queue<TreeNode>();
            //while the Q is not empty
            while (nodeQ.Count != 0)
            {
                //get the count of items in the Q
                int qCount = nodeQ.Count;
                //create a temp array
                List<int> temp = new List<int>();
                //for Q count times:
                for (int i = 0; i < qCount; i++)
                {
                    //remove node from the Q
                    TreeNode node = nodeQ.Dequeue();
                    //add value to the temp arry
                    temp.Add(node.val);
                  

                }
                //add temp to the result
                //if (flip) temp.Reverse();
                result.Add(temp);
            }

            return result;

        }
    }
}
