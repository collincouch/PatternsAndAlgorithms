using System;
using System.Collections.Generic;
using System.Linq;
using IK.Utils;

namespace IK.Amazon.Sorting
{
    public class TopKFrequentElements
    {
        //must perform better than O(n log n)
        Dictionary<int, int> dictFreq = new Dictionary<int, int>();

        public int[] TopKFrequent(int[] nums, int k)
        {

            //iterate over array and add frequency to dictionary
            //O(n)
            foreach(int i in nums)
            {
                if(!dictFreq.ContainsKey(i))
                {
                    dictFreq.Add(i, 1);
                }
                else
                {
                    dictFreq[i] += 1;
                }
            }

            //build Min Heap of size "k"
            // O(n log k)
            Heap minHeap = new Heap(k, MaxOrMin.Min);
            foreach(KeyValuePair<int,int> kvp in dictFreq.OrderBy(key=>key.Value))
            {

                if(!minHeap.IsFull())
                {
                    //if()
                    //minHeap.Add()
                }  
                else
                {
                    if (kvp.Value > minHeap.Peek())
                        minHeap.Add(kvp.Value);
                }
            }


            return new int[] { };

        }


        
    }
}
