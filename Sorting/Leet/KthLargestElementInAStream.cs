using System;
using System.Collections.Generic;
using IK.Utils;

namespace IK.Sorting.Leet
{

    //#703
    public class KthLargestElementInAStream
    {

        private Heap _maxHeap;

        /// <summary>
        /// I will use a min heap
        /// </summary>
        /// <param name="k"></param>
        /// <param name="nums"></param>
        public KthLargestElementInAStream(int k, int[] nums)
        {
            //initialize heap
            _maxHeap = new Heap(k, MaxOrMin.Min);
          
            //add values to heap
            for(int i=0;i<nums.Length;i++)
            {
                if(_maxHeap.IsEmpty()  || !_maxHeap.IsFull())
                    _maxHeap.Add(nums[i]);
                else
                {
                    if (nums[i] > _maxHeap.Peek())
                        Add(nums[i]);
                }
            }

        }

        public int Add(int val)
        {

            int kLargest;
            if(!_maxHeap.IsFull())
                _maxHeap.Add(val);
            else
            {
                if (val > _maxHeap.Peek())
                {
                    _maxHeap.Pop();
                    _maxHeap.Add(val);
                }
            }
           

            kLargest = _maxHeap.Peek();

            return kLargest;
               

            


        }
    }
}
