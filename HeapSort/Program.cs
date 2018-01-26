/*
 * 堆排序
 */
using System;
using System.Collections.Generic;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int> { 19, 8, 3, 50, 12, 59, 20, 32, 34, 75, 2 };
            var heap = new Heap(a);
            heap.Sort();
            foreach (var x in heap.Data)
                Console.Write(x + " ");
            Console.Read();
        }
    }
}
