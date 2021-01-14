using System;
using System.Collections;
using System.Collections.Generic;

namespace IK.Graphs.LectureProblems
{
    //Leet Code #210
    //public static class CourseScheduleII
    //{
    //    //use topological sort for directed graph

    //    //InMap
    //    //key:# of dependences
    //    //0: 0

    //    //Outmap
    //    //key:keys it ponts to
    //    //3:[5]
    //    //2:[3,4]
    //    public static List<int> findOrder(int numCourses,int[][] preRequisites)
    //    {
             
    //        Queue queue = new Queue();
    //        List<int> result = new List<int>();

    //        //key->num of dependences
    //        var inMap = createInMap(preRequisites);
    //        //key -> outgoing nodes
    //        var outMap = createOutMap(preRequisites);

    //        //push all nodes with 0 dependencies into queue
    //        for(int i=0;i<numCourses;i++)
    //        {
    //            if (inMap.get(i) == 0)
    //            {
    //                queue.Enqueue(i);
    //            }
    //        }

    //        while (queue.Count > 0)
    //        {
    //            //remove 0 dependency from course from the queue, take the course
    //            var pop = queue.Dequeue();

    //            //add the course to the final courses result
    //            result.Add(pop);

    //            //explore all the next course from outgoing map
    //            for(var next of outMap.get(pop))
    //            {
    //                //decrease dependency by 1 for course next
    //                inMap.set(next, inMap.get(next) - 1);
    //                //if the course (next) has no dependencies,
    //                //add back to the queue
    //                if (inMap.get(next) == 0)
    //                {
    //                    queue.Enqueue(next);
    //                }
    //            }
    //        }

    //        //if all the courses are taken in result list, return result, otherwise
    //        //return empty array

    //        return result.Count == numCourses ? result : new List<int>();
    //    }

    //    static void createInMap(int[][] preRequisites)
    //    {
    //        //var inMap = new Map();

    //        Dictionary<int, int> inMap = new Dictionary<int, int>();

    //        //construct inMap
    //        for(var i=0;i< preRequisites.Length;i++)
    //        {
    //            for(var j = 0;j<preRequisites[i].Length;j++)
    //            {
    //                inMap.Add(preRequisites[i],)
    //            }
    //            createInMap.set(prerequisite[0], (createInMap.get(prequisite[0]) || 0) + 1);
    //        }

    //        return iMap;
    //    }

    //    static void createOutMap(prerequisites)
    //    {
    //        var outMap = new Map();

    //        //construct outMap
    //        for (prerequisite of prerequisites)
    //        {
    //            if (!outMap.has(prerequisite[1]))
    //            {
    //                outMap.set(prequisite[1], new Set());
    //            }
    //            outnMap[prerequisite[1]].add(prerequisite[0]);
    //        }

    //        return outMap;
    //    }
    //}
}
