using System;
using IK.Utils;

namespace IK.Trees.DepthFirst
{

    //Leet Code #108
    public class ConvertSortedArrayToBinarySearchTree
    {
        public ConvertSortedArrayToBinarySearchTree()
        {
        }


        public TreeNode arrayToBST(int[] input)
        {
            return makeTree(input, 0, input.Length - 1);
        }


        private TreeNode makeTree(int[] input,int s, int e)
        {
            if (s > e)
                return null;
            else if (s == e)
                return new TreeNode(input[s]);
            else
            {
                //find root index
                int rootIndex = (s + e) / 2;

                // create a root node
                TreeNode root = new TreeNode(input[rootIndex]);

                //recursively add left nodes
                root.left_ptr = makeTree(input, s, rootIndex - 1);

                //recursively add right nodes
                root.right_ptr = makeTree(input, rootIndex + 1, e);

                //return root

                return root;

            }
        }
    }
}
