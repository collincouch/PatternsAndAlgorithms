using System;
using System.Collections.Generic;
using System.Text;

namespace IK.Recursion.Leet
{
    //51  2:00:00 in optional clas
    public class NQueens
    {

        //IList<IList<string>> result = new List<IList<string>>();
        //public IList<IList<string>> SolveNQueens(int n)
        //{

        //    helperRecursion(0, n, new List<int>());
        //    return result;
        //}


        //void helperRecursion(int queensPlaced,int n,Set List<int> slate)
        //{

        //    //back track
        //    //check if last queen is on same columns as other queens
        //    var lastQueen = slate.Count-1;
        //    for(int earlierQueensPlaced=0;earlierQueensPlaced<=lastQueen-1;earlierQueensPlaced++)
        //    {
        //        //is there a conflict between earlier queens and last queen?
        //        //They are already seperated by rows
        //        //check for column conflict
        //        if(slate[earlierQueensPlaced]==slate[lastQueen])
        //        {
        //            return;
        //        }

        //        //check for diagnal conflict
        //        var rowDif = Math.Abs(lastQueen - earlierQueensPlaced);
        //        var colDif = Math.Abs(Convert.ToInt32(slate[lastQueen]) - Convert.ToInt32(slate[earlierQueensPlaced]));

        //        if (rowDif == colDif)
        //            return;
                
        //    }


        //    //base case
        //    if(queensPlaced == n)
        //    {
               
        //        result.Add(new List<string>(formatSlate(slate,n)));
        //        return;
        //    }


        //    //Dictionary to hold columns that have already been used.
        //    //this will help time complexity
        //    Dictionary<int, int> pickedSoFar = new Dictionary<int, int>();


        //    //recursion
        //    //index of slate will represent row, value will represent column.
        //    for(int col=0;col<n; col++)
        //    {
        //        if (pickedSoFar.ContainsKey(col))
        //            continue;
        //        else
        //        {
        //            //add to picked so far
        //            pickedSoFar.Add(col, col);
        //            //swap with 
        //            slate.Add(col);
        //            helperRecursion(queensPlaced + 1, n, slate);
        //            slate.RemoveAt(slate.Count - 1);
        //        }
                
        //    }
        //}

        //private IEnumerable<string> formatSlate(List<int> slate,int n)
        //{
        //    List<string> result = new List<string>();
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append('.', n);

            

        //    foreach(var queen in slate)
        //    {
        //        var initialCol = sb.ToString().ToCharArray();
        //        initialCol[queen] = 'Q';

        //        result.Add(new string(initialCol));
        //    }
           
        //    return result;

        //}


        
    }
}
