using System;
namespace IK.Recursion.IKPracticeProblems
{
    public static class NQueenProblem
    {

        //n Queen Problem
        //Given an integer n, find all the possible ways to position
        //n queens on an n×n chessboard so that no two queens attack each other.

        //A queen in chess can move horizontally, vertically, or diagonally.

        //Do solve the problem using recursion first even if you see some non-recursive approaches.

        //Example One

        //Input: 4
        //Output:
        //[[
        //"--q-",
        //"q---",
        //"---q",
        //"-q--"
        //], [
        //"-q--",
        //"---q",
        //"q---",
        //"--q-"
        //]]

        //There are two distinct ways four queens can be positioned on a 4×4 chessboard without attacking each other.The positions may appear in the output in any order.So the same two positions in different order would be another correct output.

        //Example Two 
        //Input: 2
        //Output: [ ]
        //No way to position two queens on a 2×2 chessboard without them attacking each other - so empty array.

        //public static string[][] find_all_arrangements(int n)
        //{

        //}
    }
}
