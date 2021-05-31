using System;
using System.Collections.Generic;

namespace IK.Trees.Leet
{
    //#102

    //T(n) = O(n)
    //S(n) = O(n)
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;

        }
    }

    public class BinaryTreeLevelOrderTraversal
    {
        List<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            return result;
        }

        private void bfs(TreeNode root)
        {


            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while(q.Count!=0)
            {
                int numNodes = q.Count;
                var temp = new List<int>();

                for(int i =0;i<numNodes;i++)
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





        }
    }
}
