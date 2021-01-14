using System;
using System.Collections.Generic;

namespace IK.Trees.Leet
{
    public class BinaryTreeRightSideView
    {

        List<int> result = new List<int>();

        public IList<int> RightSideView(TreeNode root)
        {

            if (root == null)
                return result;

            bfs(root);

            return result;
        }

        private void bfs(TreeNode root)
        {

            //declare a queue to hold the tree
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var temp = new List<int>();

            while (q.Count != 0)
            {
                int numNodes = q.Count;
                for(int i = 0; i < numNodes; i++)
                {
                    var node = q.Dequeue();
                    temp.Add(node.val);

                    if (node.left != null)
                        q.Enqueue(node.left);

                    if (node.right != null)
                        q.Enqueue(node.right);

                  
                }

                //we only want the right side taverse
                result.Add(temp[temp.Count - 1]);
            }


        }
    }
}
