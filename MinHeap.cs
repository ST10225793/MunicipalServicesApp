using System;
using System.Collections.Generic;

namespace MunicipalServicesApp
{
    public class PriorityItem
    {
        public int Priority { get; set; } // 1 = Critical, 2 = High, 3 = Medium, 4 = Low
        public Issue Request { get; set; }

        public PriorityItem(int priority, Issue request)
        {
            Priority = priority;
            Request = request;
        }
    }

    public class MinHeap
    {
        private List<PriorityItem> heap = new List<PriorityItem>();

        public int Count => heap.Count;

        public void Insert(int priority, Issue request)
        {
            heap.Add(new PriorityItem(priority, request));
            HeapifyUp(heap.Count - 1);
        }

        public PriorityItem ExtractMin()
        {
            if (heap.Count == 0) return null;
            PriorityItem minItem = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return minItem;
        }

        public PriorityItem PeekMin()
        {
            if (heap.Count == 0) return null;
            return heap[0];
        }

        public List<PriorityItem> GetAllSorted()
        {
            List<PriorityItem> tempHeap = new List<PriorityItem>(heap);
            List<PriorityItem> sortedList = new List<PriorityItem>();
            
            // Extract from copy
            MinHeap copy = new MinHeap();
            foreach (var item in tempHeap)
            {
                copy.Insert(item.Priority, item.Request);
            }

            while (copy.Count > 0)
            {
                sortedList.Add(copy.ExtractMin());
            }

            return sortedList;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[index].Priority >= heap[parent].Priority) break;

                PriorityItem temp = heap[index];
                heap[index] = heap[parent];
                heap[parent] = temp;
                index = parent;
            }
        }

        private void HeapifyDown(int index)
        {
            while (index * 2 + 1 < heap.Count)
            {
                int leftChild = index * 2 + 1;
                int rightChild = index * 2 + 2;
                int smallest = index;

                if (heap[leftChild].Priority < heap[smallest].Priority)
                    smallest = leftChild;

                if (rightChild < heap.Count && heap[rightChild].Priority < heap[smallest].Priority)
                    smallest = rightChild;

                if (smallest == index) break;

                PriorityItem temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;
                index = smallest;
            }
        }
    }
}
