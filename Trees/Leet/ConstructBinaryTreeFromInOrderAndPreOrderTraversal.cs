using System;
using System.Collections.Generic;

namespace IK.Trees.Leet
{

    //Leet Code 105
    public class ConstructBinaryTreeFromInOrderAndPreOrderTraversal
    {

        //global dictionary to store values and index from in-order array
        Dictionary<int, int> inOrderIdxDic = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {

            if (preorder.Length == 0 || inorder.Length == 0)
                return null;
            //initialize ditionary with values
            for(int i=0;i< inorder.Length;i++)
            {
                inOrderIdxDic.Add(inorder[i], i);
            }

            var result = constructorHelper(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);

            return result;
        }


        //T(n) = O(n)
        //S(n) = O(n)
        private TreeNode constructorHelper(int[] pAry,int pStartIdx, int pEndIdx,
            int[] iAry, int iStartIdx, int iEndIdx)
        {


            //Base case - it doesn't matter if we use pStart or iStart since both arrays are same size
            if (pStartIdx > pEndIdx)//size 0;
                return null;
            if (pStartIdx == pEndIdx)//size 1
                return new TreeNode(pAry[pStartIdx]);



            //recursive section

            // root node is always the first in a pre-order traversal
            var rootNode = new TreeNode(pAry[pStartIdx]);

            //get the index from the dictionary
            int rootIndx = inOrderIdxDic[rootNode.val];

            //get number of nodes on left and right
            int numOfLeftNodes = rootIndx - iStartIdx;
            int numOfRightNodes = iEndIdx - rootIndx;


            //recursive call to left node
            rootNode.left = constructorHelper(pAry, pStartIdx + 1, pStartIdx + numOfLeftNodes,
                iAry, iStartIdx, rootIndx - 1);

            //recursive call to right node
            rootNode.right = constructorHelper(pAry, pStartIdx + numOfLeftNodes + 1, pEndIdx,
                iAry, rootIndx + 1, rootIndx + 1 + numOfRightNodes);


            return rootNode;

        }
    }
}
