using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Trees.IKTests
{
    public class KSmallestElementOfBST
    {
        public static int kth_smallest_element(TreeNode root, int k)
        {
            List<int> resultLst = new List<int>();

            //kSmallestRecursion(root, resultLst);

            resultLst.Sort();

            int result = resultLst[k-1];

            return result;


        }

        static void kSmallestRecursionBruteFoce(TreeNode node, List<int> soFar)
        {

            if(node.left_ptr==node && node.right_ptr==null)
            {
                soFar.Add(node.val);
                return;
            }

            soFar.Add(node.val);

            if(node.left_ptr!=null)
            {
                //kSmallestRecursion(node.left_ptr, soFar);
            }

            if(node.right_ptr!=null)
            {
                //kSmallestRecursion(node.right_ptr, soFar);
            }

            
                
        }

        static int kSmallestRecursion(TreeNode node, int currK)
        {

            if (node==null)
            {
                return 0;
            }

            currK = kSmallestRecursion(node.left_ptr, currK);

            return currK;

        }
    }
}
