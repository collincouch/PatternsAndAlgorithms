﻿using System;
using System.Collections.Generic;

namespace IK.Recursion.IKPracticeProblems
{
    /// <summary>
    /// Tower of Hanoi is a mathematical puzzle where we have three pegs and n disks.
    /// The objective of the puzzle is to move the entire stack to another peg, obeying the following simple rules:
    ///
    /// Only one disk can be moved at a time.
    /// Each move consists of taking the upper disk from one of the stacks and placing it on top of
    /// another stack i.e.a disk can only be moved if it is the uppermost disk on a stack.
    /// No disk may be placed on top of a smaller disk.
    /// Here, we are given n denoting the number of disks in the first peg, we need to return
    /// all the steps taken to move all disks from the first peg to the third peg.
    ///
    ///
    /// There can be multiple possibilities to complete the given objective. Every valid possibility
    /// to achieve objective will be a valid answer.
    ///
    /// Example
    ///
    /// Input: n = 4
    ///
    /// Output:
    ///
    /// [ [1, 2], [1, 3], [2, 3], [1, 2], [3, 1], [3, 2], [1, 2], [1, 3], [2, 3], [2, 1], [3, 1], [2, 3], [1, 2], [1, 3], [2, 3] ]
    ///
    /// Following steps:
    ///
    /// [1, 2] = Shift top disk of the first peg to top of the second peg.
    /// Picture after this step will be:
    /// First peg: 2 3 4
    /// Second peg: 1
    /// Third peg: Empty
    ///
    /// [1, 3] = Shift top disk of the first peg to top of the third peg.
    /// Picture after this step will be:
    /// First peg: 3 4
    /// Second peg: 1
    /// Third peg: 2
    /// 
    /// Similarly after following remaining steps will find that the final configuration will be
    /// First peg: Empty
    /// Second peg: Empty
    /// Third peg: 1 2 3 4
    /// which is our objective.
    ///
    /// Notes
    /// Input Parameters: There is only one argument in the input, an integer
    /// named n denoting the number of disks in the first peg.
    ///
    /// Output: Return a 2d integer array denoting steps taken to move disks from the
    /// first peg to the third peg. Each row will have two integers denoting from peg
    /// and to peg, for example, if the ith row is [2, 3], then it means in this step,
    /// we moved the top disk on peg 2 to peg 3.
    ///
    /// Constraints:
    /// 1 <= n <= 20
    /// 
    /// </summary>
    public static class TowerOfHanoi
    {
        public static List<List<int>> tower_of_hanoi(int n)
        {
            // Write your code here

            List<List<int>> result = new List<List<int>>();

            RecursiveTowerOfHanoi(n, 1, 3, 2, result);

            return result;
        }

        private static void RecursiveTowerOfHanoi(int n, int from, int to, int temp, List<List<int>> soFar)
        {

            List<int> moves;
            //base case
            //no more pegs on rod
            if (n==1)
            {
                //Console.WriteLine("Move disk 1 from rod " + from
                //                           + " to rod " + to);

                moves = new List<int> { from, to };
                soFar.Add(moves);
                return;
            }

            //Move to the 3rd peg first
            RecursiveTowerOfHanoi(n - 1, from, temp, to, soFar);

            moves = new List<int>() { from, to };
            soFar.Add(moves);

            //Move to the 2nd peg second
            RecursiveTowerOfHanoi(n - 1, temp, to, from,soFar);

        }
    }
}
