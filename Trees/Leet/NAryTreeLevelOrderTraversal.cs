using System;
using System.Collections.Generic;
using System.Linq;

namespace IK.Trees.Leet
{

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    public class NAryTreeLevelOrderTraversal
    {

        List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> LevelOrder(Node root)
        {

            if (root == null)
                return result;

            bfs(root);

            return result;
        }

        //T(n)=O(n)
        //S(n)=O(n)
        private void bfs(Node root)
        {

            //FIFO
            var q = new Queue<Node>();

            //put the node in the queue.
            q.Enqueue(root);

            //iterate until queue is empty;
            while(q.Count!=0)
            {
                int numNodes = q.Count;
                var temp = new List<int>();

                //repeat for each node 
                for (int i=0;i<numNodes;i++)
                {
                    //pop off node in queue.
                    var node = q.Dequeue();
                    temp.Add(node.val);
                    //iterate the n-ary children
                    if(node.children!=null && node.children.Any())
                    {
                        foreach (var c in node.children)
                        {
                            q.Enqueue(c);
                        }
                    }
                    
                    
                }

                result.Add(temp);
            }
        }
    }

   
}
