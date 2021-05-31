using System;
using System.Collections.Generic;

//103
namespace IK.Trees.Leet
{
    public class BinaryTreeZigZagLevelOrderTraversal
    {
        List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {

            if (root == null)
                return result;

            bfs(root);

            return result;
        }

        //breadth first search
        private void bfs(TreeNode root)
        {

            //make the queue
            var q = new Queue<TreeNode>();

            //put the root in the queue
            q.Enqueue(root);
       
            //our zig-zag variable so we know when to reverse
            bool right_to_left = false;


            //loop though the queue
            while(q.Count!=0)
            {
                //counter variable
                int nodeCount = q.Count;

                //temp variable to hold the binary children
                var temp = new List<int>();

                //iterate through the binary kids
                for (int i = 0; i < nodeCount; i++)
                {
                    var node = q.Dequeue();
                    temp.Add(node.val);

                    if (node.left != null)
                        q.Enqueue(node.left);

                    if (node.right != null)
                        q.Enqueue(node.right);

                    

                }
                if (right_to_left)
                    temp.Reverse();

                right_to_left = !right_to_left;
                result.Add(temp);
            }
           

            


        }
    }
}
