using System;
namespace IK.Sorting.Leet
{
    //252
    public class MeetingRooms
    {
        //Two pointer solutions
        //T(n) = O(n)
        public MeetingRooms()
        {
        }

        public bool CanAttendMeetings(int[][] intervals)
        {
            int i = 0;
            int j = 1;
            Array.Sort(intervals, new Comparison<int[]>((x, y) => { return x[0] < y[0] ? -1 : (x[0] > y[0] ? 1 : 0); }));


            while (j < intervals.Length)
            {
                if (intervals[i][0] <= intervals[j][0] && intervals[i][1] <= intervals[j][0])
                {
                    i++;
                    j++;
                }
                else
                {
                    return false;
                }

            }
            return true;

            
        }
    }
}
