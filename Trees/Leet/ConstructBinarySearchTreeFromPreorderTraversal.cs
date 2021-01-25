using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Trees.Leet
{

    //Leet 1008
    public class ConstructBinarySearchTreeFromPreorderTraversal
    {

        Dictionary<int, int> inOrderIndexValue = new Dictionary<int, int>();

        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (preorder.Length == 0)
                return null;


            //we will sort the pre-order array to get the inorder array, then use both arrays
            //to construct the binary search tree.
            int[] inOrder = new int[preorder.Length];

            preorder.CopyTo(inOrder, 0);

            quickSort(inOrder);

            //populate the global dictionary for index locations of inorder traversal
            for(int i = 0;i<inOrder.Length;i++)
            {
                inOrderIndexValue.Add(inOrder[i], i);
            }
            


            var returnNode = constructHelper(preorder, 0, preorder.Length - 1,inOrder,0,inOrder.Length - 1);

            return returnNode;
        }



        private TreeNode constructHelper(int[] pAry, int pStartIndex, int pEndIndex,
            int[] iAry,int iStartIndex, int iEndIndex)
        {

            //base case  we can use any of the array indexes since they are same size
            if (pStartIndex > pEndIndex)//case 0
                return null;

            if (pStartIndex == pEndIndex)//case 1
                return new TreeNode(pAry[pStartIndex]);


            //recursion

            //get the root node
            var rootNode = new TreeNode(pAry[pStartIndex]);

            //look up the root index from inorder array
            int rootIndex = inOrderIndexValue[iAry[rootNode.val]];

            //count the number of left and right nodes
            int numLeft = rootIndex - iStartIndex;
            int numRight = iEndIndex - rootIndex;

            //get the left and right nodes
            rootNode.left = constructHelper(pAry, pStartIndex + 1, pStartIndex + 1 + numLeft,
                iAry, iStartIndex, rootIndex-1);

            rootNode.right = constructHelper(pAry, pStartIndex + numLeft + 1, pEndIndex,
                iAry, rootIndex + 1, rootIndex + 1 + numRight);


            return rootNode;




        }

        private void quickSort(int[] ary)
        {

            int piviotIdx = quickSortHelper(ary, 0, ary.Length);


            //go left
            quickSortHelper(ary, 0, piviotIdx - 1);
            //go right
            //quickSortHelper(ary,piviotIdx+1,)
        }

        private int quickSortHelper(int[] ary, int startIndex, int endIndex)
        {
            //get random piviot
            var random = new Random();
            int piviotIndx = random.Next(startIndex, endIndex);

            //move to the left
            swap(ary, startIndex, piviotIndx);


            int i = startIndex + 1;
            int j = startIndex + 1;

            while(j<endIndex)
            {
                if(j<ary[startIndex])
                {
                    swap(ary, i, j);
                    j++;
                    i++;
                }
                else
                {
                    j++;
                }
            }


            //move piviot back into correct spot
            swap(ary, i-1, startIndex);

            //return piviot index
            return i - 1;

        }

        private void swap(int[] ary, int index1, int index2)
        {
            var temp = ary[index1];
            ary[index1] = ary[index2];

            ary[index2] = temp;
        }
    }
}
