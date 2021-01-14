using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IK.Repay
{
    public class MaxValWithFive
    {

        public int solution(int N)
        {
            var strN = N.ToString();
            float ans = float.NegativeInfinity;

            for(int i=0;i<strN.Length + 1;i++)
            {
                //substring from i-1 + '5' + i-end
                var cand = strN.Substring(0, i) + '5' + strN.Substring(i, strN.Length-i);
                //skip the '-' for negative numbers
                if (i == 0 && strN[0] == '-')
                    continue;

                ans = Math.Max(ans, Convert.ToInt16(cand));
            }



            return Convert.ToInt32(ans);
        }




        public string removeBadData(string S)
        {
            //Split 'S' on the new line

            var rows = S.Split('\n').ToList();

            List<string> lstValidRecords = new List<string>();
            StringBuilder sb = new StringBuilder();

            //sb.Append(rows[0]);
            sb.Append(rows[0] + "\n");
            foreach (var rowItem in rows.Skip(1))
            {
                //split collumns
                var cols = rowItem.Split(',');
                bool skip=false;
                foreach(var col in cols)
                {
                    if (col.Contains("NULL"))
                    {
                        skip = true;
                        break;
                    }
                }
                if (skip == true)
                    break;

                sb.Append(rowItem);

            }

            //sb.Remove(sb.Length - 3, 3);

            var x = sb.ToString().Trim();

            return sb.ToString();


        }


    }
}
