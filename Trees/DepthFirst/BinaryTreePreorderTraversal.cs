using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Trees.DepthFirst
{
    //Leet Coder #144
    public class BinaryTreePreorderTraversal
    {
        public BinaryTreePreorderTraversal()
        {
        }

        public List<int> preOrderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            //edge case if null
            if (root == null) return result;

            //create a stack to process the node
            Stack<TreeNode> nodeStack = new Stack<TreeNode>();

            //set the current node to the rot node
            TreeNode node = root;

            //while the node is not null or the stack is not empty
            while(node!=null || nodeStack.Count>0)
            {
                //keep pushing the left node onto the stack until you
                //reach a null
                while(node!=null)
                {
                    //preorder or post order operations
                    result.Add(node.val);
                    nodeStack.Push(node);
                    //for preorder, set node to the node.left
                    //for post order, set the node to node.right
                    node = node.left_ptr; 

                }
                //node wil be null, so set it to the parent
                node = nodeStack.Pop();
                //perform the in order operations
                //now travel down the other child node
                node = node.right_ptr;
            }
            return result;


        }
    }
}
