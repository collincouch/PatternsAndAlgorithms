using System;
namespace IK.Trees.DepthFirst
{
    //Leet Code #105
    public class ConstructBinaryTreeFromPreorderAndInOrderTrav
    {
        public ConstructBinaryTreeFromPreorderAndInOrderTrav()
        {
        }

        //HashMap of InOrder Array
        //Key=arryvalue Val = idx

        //RI = Map.Get(POary[s])
        //LftTeeCount = RI - Start
        //RghTreeCount = End - RootIndx

        //Root.Left = dfs(PoArruy,s+1,s+ leftCount,IOArray,s,RI-1)

        //Root.Right = dfs(PoArray,s+ leftCount + 1,end,IOArray,rootIndex +1,end);

    }
}
