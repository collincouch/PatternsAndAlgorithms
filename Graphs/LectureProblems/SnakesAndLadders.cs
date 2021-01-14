using System;
namespace IK.Graphs.LectureProblems
{
    //Leet Code #909
//    public class SnakesAndLadders
//    {
//        public static int getNumberofMoves(board)
//        {

            
//            target = rows * cols;
//            //construct snakeLadderMap (key(orginal index) => value(target index))
//            snakeLadderMap = constructSnakeLadderMap();

//            visited = new Set();

//            //create a queue for BFS traversal
//            queue = new Queue();
//            //add first index and global moves as 0

//            queue.add({ index: 1:golbalMoves: 0}));
//            //add to visited set
//            visited.add(1);

//            while (queue.length) {
//                current = queue.pop();
//                //current index
//                indexer = current.index;
//                //global moves to this index
//                globalMoves = crrent.globalMoves;

//                //if reach target index, return globalMoves
//                if (index == target)
//                {
//                    return globalMoves;
//                }

//                //traverse to all the neighbors(+1...+6)


//            }

//            //can not reach to the target, return -1 as invalid case

//            return -1;

//        }

//        static void constructSnakeLadderMap(board)
//        {
//            //board rows
//            rows = board.length;
//            //board columns per row
//            cols = board[0].length;

//            constructSnakeLadderMap = new MAp();

//            for (indexer = 0; indexer < rows; indexer++)
//            {
//                for (j = 0; j < cols; j++)
//                {
//                    if (board[if][j]!= -1){
//                //convert i, j into game index number
//                const indexer = rowColToIndex(i, j, rows, cols);
//                //assign target value into snakeLadderMap
//                constructSnakeLadderMap.set(index, board[indexer][j]);
//                    }
//            }
//        }

//        static int rowColToIndex(int i, int j, rows, cols)
//    {
//        const base = (rows - i - 1) * cols;
//        if((rows-i-1)%2 == 0)
//        {
//            return base + j + 1;

//        }
//        else
//        {
//            return base + cols - j;
//        }
//    }
//    }
        
//}
//    }
}
