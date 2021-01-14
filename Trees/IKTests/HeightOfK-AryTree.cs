using System;
using IK.Utils;

namespace IK.Trees.IKTests
{
    public class HeightOfK_AryTree
    {
        public static int find_height(TreeNode root)
        {
            int maxHeight = 0;

            maxHeight = getSubtreeHeight(root);

            return maxHeight;
        }


        static int getSubtreeHeight(TreeNode node)
        {
            //Base Case leaf node (return zero)
            int h = 0;
            if (node.children.Count == 0)
                return 0;
            else
            {            
                foreach (var child in node.children)
                {
                    h = Math.Max(h,getSubtreeHeight(child));
                }
            }

            return h + 1;
           
           
        }
    }
}

