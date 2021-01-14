using System;
using System.Collections.Generic;

namespace IK.Trees.Leet
{

    public class BinaryTreeLevelOrderTraversal2
    {

        List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null)
                return result;

            bfs(root);
            return result;
        }


        private void bfs(TreeNode root)
        {

            var q = new Queue<TreeNode>();

            q.Enqueue(root);

            while (q.Count != 0)
            {
                int numNode = q.Count;
                var temp = new List<int>();

                for(int i=0;i<numNode;i++)
                {
                    var node = q.Dequeue();
                    temp.Add(node.val);

                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }

              
                result.Add(temp);
            }

            result.Reverse();
        }
    }
}
