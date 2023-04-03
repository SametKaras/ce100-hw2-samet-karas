﻿using System;
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

    public class MatrixChainMultiplicationDP
    {
        /// <summary>
        /// Matrix Chain Multiplication is a dynamic programming algorithm that efficiently computes 
        /// the minimum number of scalar multiplications needed to multiply a sequence of matrices. It
        /// uses memoization to avoid redundant calculations and builds up solutions for larger 
        /// subproblems using solutions to smaller subproblems. The algorithm has a time complexity 
        /// of O(n^3) and a space complexity of O(n^2), where n is the number of matrices in the sequence.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="result"></param>
        /// <param name="enableDebug"></param>
        /// <returns></returns>
        public static int MCMDP(int[] d, out int result, bool enableDebug = false)
        {
            // Initialize the output variable to 0
            result = 0;
            // Get the length of the input array
            int n = d.Length - 1;
            // Initialize a 2D array to store the minimum costs
            int[,] m = new int[n + 1, n + 1];

            // Initialize the diagonal values of the 2D array to 0
            // and the rest to infinity
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    m[i, j] = int.MaxValue;
                }
                m[i, i] = 0;
            }

            // Compute the minimum cost for each sub-matrix of the input matrix
            for (int r = 0; r < n; r++)
            {
                for (int i = 1; i <= n - r; i++)
                {
                    int j = i + r;
                    if (i == j)
                    {
                        m[i, j] = 0;
                    }
                    else
                    {
                        for (int k = i; k < j; k++)
                        {
                            // Compute the minimum cost for multiplying two matrices
                            m[i, j] = Math.Min(m[i, j], m[i, k] + m[k + 1, j] + d[i - 1] * d[k] * d[j]);
                            if (enableDebug)
                            {
                                // Print the minimum cost for the current sub-matrix
                                Console.WriteLine("m[{0}, {1}] = {2}", i, j, m[i, j]);
                            }
                        }
                    }
                }
            }

            // Check if the minimum cost for the whole matrix is infinity
            if (m[1, n] == int.MaxValue)
            {
                // If so, return -1 to indicate an error
                result = -1;
                return result;
            }
            else
            {
                // Otherwise, set the output variable to the minimum cost
                // and return it
                result = m[1, n];
                return result;
            }
        }




    }
}
