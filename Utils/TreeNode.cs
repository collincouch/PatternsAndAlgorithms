using System;
using System.Collections.Generic;

namespace IK.Utils
{
    public class TreeNode
    {

        public TreeNode()
        {
        }

        public TreeNode(int value)
        {
            val = value; 
        }

        public int val { get; set; }

        public TreeNode left_ptr { get; set; }
        public TreeNode right_ptr { get; set; }
        public List<TreeNode> children { get; set; }
    }
}
