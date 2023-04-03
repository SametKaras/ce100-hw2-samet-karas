using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw2_algo_lib_cs
{
    public class HeapSortFuncion
    {
        /// <summary>
        /// Heap Sort is a sorting algorithm that first turns the input array into a maximum heap 
        /// structure. It then repeatedly extracts the maximum element from the heap and places it at 
        /// the end of the array. This process continues until all elements are sorted in non-decreasing order.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="parent_index"></param>
        /// <param name="enableDebug"></param>
        /// <returns></returns>
        public static int MaxHeap(int[] arr, int n, int parent_index, bool enableDebug = false)
        {
            // Assume the parent node is the largest initially
            int largest = parent_index;
            // Calculate the indices of the left and right child nodes
            int left = 2 * parent_index + 1;
            int right = 2 * parent_index + 2;

            // Check if the left child node is larger than the parent node
            if (left < n && arr[left] > arr[largest])
                largest = left;

            // Check if the right child node is larger than the largest node so far
            if (right < n && arr[right] > arr[largest])
                largest = right;

            // If the largest node is not the parent node, swap the two nodes and recursively check the subtree
            if (largest != parent_index)
            {
                int temp = arr[parent_index];
                arr[parent_index] = arr[largest];
                arr[largest] = temp;

                // If debug mode is enabled, print a message indicating the swapped elements
                if (enableDebug)
                    Console.WriteLine("Swapping elements: {0} and {1}", arr[parent_index], arr[largest]);

                // Recursively check the subtree for heap property
                return MaxHeap(arr, n, largest, enableDebug);
            }

            // Return 0 to indicate that the subtree satisfies the heap property
            return 0;
        }

        public static int HeapSort(int[] arr, bool enableDebug = false)
        {
            int n = arr.Length;

            // Convert the input array into a max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                MaxHeap(arr, n, i, enableDebug);

            // Extract the maximum element from the heap and place it at the end of the array
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // If debug mode is enabled, print a message indicating the swapped elements
                if (enableDebug)
                    Console.WriteLine("Swapping elements: {0} and {1}", arr[0], arr[i]);

                // Check that the remaining elements still satisfy the heap property
                if (MaxHeap(arr, i, 0, enableDebug) != 0)
                {
                    // If the heap property is violated, return -1 to indicate an error
                    return -1;
                }
            }

            // Return 0 to indicate success
            return 0;
        }


    }

}
