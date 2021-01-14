using System;
using System.Collections.Generic;
using IK.Sorting.IKPracticeProblems;

namespace IK.Utils
{


    public enum MaxOrMin
    {
        NoFound=0,
        Min=1,
        Max=2
    };


    //public class Heap<T> where T:IComparable<T>
    //{


    //    private readonly T[] _elements;
    //    private int _size;
    //    private MaxOrMin _maxOrMin;
    //    public Heap(int size, MaxOrMin maxOrMin)
    //    {
    //        _elements = new T[size];
    //        _maxOrMin = maxOrMin;
    //    }

    //    private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
    //    private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
    //    private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

    //    private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _size;
    //    private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _size;
    //    private bool IsRoot(int elementIndex) => elementIndex == 0;

    //    private T GetLeftChild(int elementIndex) => _elements[GetLeftChildIndex(elementIndex)];
    //    private T GetRightChild(int elementIndex) => _elements[GetRightChildIndex(elementIndex)];
    //    private T GetParent(int elementIndex) => _elements[GetParentIndex(elementIndex)];

    //    private void Swap(int firstIndex, int secondIndex)
    //    {
    //        var temp = _elements[firstIndex];
    //        _elements[firstIndex] = _elements[secondIndex];
    //        _elements[secondIndex] = temp;
    //    }

    //    public bool IsEmpty()
    //    {
    //        return _size == 0;
    //    }

    //    public bool IsFull()
    //    {
    //        return _size == _elements.Length;
    //    }


    //    public T Peek()
    //    {
    //        if (_size == 0)
    //            throw new IndexOutOfRangeException();

    //        return _elements[0];
    //    }

    //    public T Pop()
    //    {


    //        var result = _elements[0];
    //        _elements[0] = _elements[_size - 1];
    //        _size--;
    //        if (_maxOrMin == MaxOrMin.Min)
    //            MinHeapReCalculateDown();
    //        else
    //            MaxHeapReCalculateDown();

    //        return result;
    //    }

    //    public void Add(T element)
    //    {
    //        if (_size == _elements.Length)
    //            throw new IndexOutOfRangeException();



    //        _elements[_size] = element;
    //        _size++;

    //        if (_maxOrMin == MaxOrMin.Min)
    //            MinHeapReCalculateUp();
    //        else
    //            MaxHeapReCalculateUp();
    //    }

    //    private void MinHeapReCalculateDown()
    //    {
    //        int index = 0;
    //        while (HasLeftChild(index))
    //        {
    //            var smallerIndex = GetLeftChildIndex(index);
    //            if (HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
    //            {
    //                smallerIndex = GetRightChildIndex(index);
    //            }

    //            if (_elements[smallerIndex] >= _elements[index])
    //            {
    //                break;
    //            }

    //            Swap(smallerIndex, index);
    //            index = smallerIndex;
    //        }
    //    }

    //    private void MinHeapReCalculateUp()
    //    {
    //        var index = _size - 1;
    //        while (!IsRoot(index) && _elements[index] < GetParent(index))
    //        {
    //            var parentIndex = GetParentIndex(index);
    //            Swap(parentIndex, index);
    //            index = parentIndex;
    //        }
    //    }

    //    private void MaxHeapReCalculateDown()
    //    {
    //        int index = 0;
    //        while (HasLeftChild(index))
    //        {
    //            var biggerIndex = GetLeftChildIndex(index);
    //            if (HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
    //            {
    //                biggerIndex = GetRightChildIndex(index);
    //            }

    //            if (_elements[biggerIndex] < _elements[index])
    //            {
    //                break;
    //            }

    //            Swap(biggerIndex, index);
    //            index = biggerIndex;
    //        }
    //    }

    //    private void MaxHeapReCalculateUp()
    //    {
    //        var index = _size - 1;
    //        while (!IsRoot(index) && _elements[index] > GetParent(index))
    //        {
    //            var parentIndex = GetParentIndex(index);
    //            Swap(parentIndex, index);
    //            index = parentIndex;
    //        }
    //    }

      
    //}

    public class Heap
    {

      
        private readonly int[] _elements;
        private int _size;
        private MaxOrMin _maxOrMin;
        public Heap(int size,MaxOrMin maxOrMin)
        {
            _elements = new int[size];
            _maxOrMin = maxOrMin;
        }

        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _size;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _size;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private int GetLeftChild(int elementIndex) => _elements[GetLeftChildIndex(elementIndex)];
        private int GetRightChild(int elementIndex) => _elements[GetRightChildIndex(elementIndex)];
        private int GetParent(int elementIndex) => _elements[GetParentIndex(elementIndex)];

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = _elements[firstIndex];
            _elements[firstIndex] = _elements[secondIndex];
            _elements[secondIndex] = temp;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public bool IsFull()
        {
            return _size == _elements.Length;
        }

     
        public int Peek()
        {
            if (_size == 0)
                throw new IndexOutOfRangeException();

            return _elements[0];
        }

        public int Pop()
        {


            var result = _elements[0];
            _elements[0] = _elements[_size - 1];
            _size--;
            if (_maxOrMin == MaxOrMin.Min)
                MinHeapReCalculateDown();
            else
                MaxHeapReCalculateDown();

            return result;
        }

        public void Add(int element)
        {
            if (_size == _elements.Length)
                throw new IndexOutOfRangeException();



            _elements[_size] = element;
            _size++;

            if (_maxOrMin == MaxOrMin.Min)
                MinHeapReCalculateUp();
            else
                MaxHeapReCalculateUp();
        }

        private void MinHeapReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                if (_elements[smallerIndex] >= _elements[index])
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        private void MinHeapReCalculateUp()
        {
            var index = _size - 1;
            while (!IsRoot(index) && _elements[index] < GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        private void MaxHeapReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (_elements[biggerIndex] < _elements[index])
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        private void MaxHeapReCalculateUp()
        {
            var index = _size - 1;
            while (!IsRoot(index) && _elements[index] > GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }

    public class HeapDouble
    {
        private readonly List<Point> _elements;
        private int _count;
        private MaxOrMin _maxOrMin;

       

        public HeapDouble(MaxOrMin maxOrMin)
        {
            _elements = new List<Point>();
            _maxOrMin = maxOrMin;
        }

        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _count;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _count;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private Point GetLeftChild(int elementIndex) => _elements[GetLeftChildIndex(elementIndex)];
        private Point GetRightChild(int elementIndex) => _elements[GetRightChildIndex(elementIndex)];
        private Point GetParent(int elementIndex) => _elements[GetParentIndex(elementIndex)];

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = _elements[firstIndex];
            _elements[firstIndex] = _elements[secondIndex];
            _elements[secondIndex] = temp;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public Point Peek()
        {
            if (_count == 0)
                throw new IndexOutOfRangeException();

            return _elements[0];
        }

        public int Size { get { return _count; } }

        public List<Point> Elements { get { return _elements; } }

        public Point Pop()
        {


            var result = _elements[0];

            _elements.Remove(result);
            _count--;


            if (_maxOrMin == MaxOrMin.Min)
                MinHeapReCalculateDown();
            else
                MaxHeapReCalculateDown();

            return result;
        }

        public void Add(Point element)
        {


            _elements.Add(element);
            _count++;
 

            if (_maxOrMin == MaxOrMin.Min)
                MinHeapReCalculateUp();
            else
                MaxHeapReCalculateUp();
        }

        private void MinHeapReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index).distance < GetLeftChild(index).distance)
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                if (_elements[smallerIndex].distance >= _elements[index].distance)
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        private void MinHeapReCalculateUp()
        {
            var index = _count - 1;
            while (!IsRoot(index) && _elements[index].distance < GetParent(index).distance)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        private void MaxHeapReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index).distance > GetLeftChild(index).distance)
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (_elements[biggerIndex].distance < _elements[index].distance)
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        private void MaxHeapReCalculateUp()
        {
            var index = _count - 1;
            while (!IsRoot(index) && _elements[index].distance > GetParent(index).distance)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }

    //public class HeapSort
    //{
    //    public int heapSize;
    //    public List<Point> arr;
    //    public HeapSort(int k)
    //    {
    //        heapSize = k;
    //        arr = new List<Point>();
    //    }
    //    public void Enqueue(Point c)
    //    {
    //        if (arr.Count == heapSize && c.distance < Peek().distance) Dequeue();
    //        if (arr.Count < heapSize)
    //        {
    //            arr.Add(c);
    //            int index = arr.Count - 1;
    //            while (index > 0)
    //            {
    //                int parent = (index - 1) / 2;
    //                if (arr[parent].distance > arr[index].distance) break;
    //                swap(index, parent);
    //                index = parent;
    //            }
    //        }
    //    }
    //    public Point Peek()
    //    {
    //        return (arr.Count > 0) ? arr[0] : null;
    //    }
    //    public Point Dequeue()
    //    {
    //        Cord first = arr[0];
    //        Cord last = arr[arr.Count - 1];
    //        arr[0] = last;
    //        arr.RemoveAt(arr.Count - 1);
    //        Heapify(0);
    //        return first;
    //    }
    //    private void Heapify(int index)
    //    {
    //        int leftChild = 2 * index + 1;
    //        int rightChild = 2 * index + 2;
    //        int largerIndex = index;
    //        if (leftChild < arr.Count && arr[leftChild].dist > arr[largerIndex].dist) largerIndex = leftChild;
    //        if (rightChild < arr.Count && arr[rightChild].dist > arr[largerIndex].dist) largerIndex = rightChild;
    //        if (index != largerIndex)
    //        {
    //            swap(index, largerIndex);
    //            Heapify(largerIndex);
    //        }
    //    }
    //    private void swap(int from, int to)
    //    {
    //        Cord temp = arr[from];
    //        arr[from] = arr[to];
    //        arr[to] = temp;
    //    }
    //}
}
