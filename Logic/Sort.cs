using System;
using System.Reflection;
using System.Runtime.CompilerServices;

//Открытый ключ(алгоритм хэширования: sha1):
//0024000004800000940000000602000000240000525341310004000001000100fbb6bcfabc8208
//02f5696582ce9d8df105e7a0aa2698250a09f7675f55f9fdcd453195c8c088b793685a4998784a
//e2ba0fa79739ba3f3b5f0c61cc0eea75424d4153d2e64158318c21620d13b9af42c901161fecd1
//fc48ec547a004c85e470e8f233782e03205e4ca4ebfc527ad81b81943eb2ceae07ec11aa8307f3
//10dc5bbb
//Токен открытого ключа: f6ade7453c7f4178

namespace Logic
{
    /// <summary>
    /// Class is created for sorting int arrays
    /// </summary>
    public static class Sort
    {
        #region QuickSort (public)
        /// <summary>
        /// Sorting int arrays using Quick Sort
        /// </summary>
        /// <param name="array">array of int values</param>
        public static void QuickSort(int[] array)
        {
            ArrayChecker(array);
            QuickSortHelper(array, 0, array.Length - 1); 
        }
        #endregion

        #region MergeSort (public)
        /// <summary>
        /// Sorting int arrays using Merge Sort
        /// </summary>
        /// <param name="array">array of int values</param>
        public static void MergeSort(int[] array)
        {
            ArrayChecker(array);
            Divide(array, 0, array.Length - 1);
        }
        #endregion

        #region QuickSort Helpers (internal)
        /// <summary>
        /// Helper private method for QuickSort. 
        /// </summary>
        /// <param name="array">array of int values</param>
        /// <param name="left">the most left element in subarray</param>
        /// <param name="right">the most right element in subarray</param>
        internal static void QuickSortHelper(int[] array, int left, int right)
        {
            if (right <= left) return;
            int pivot = Part(array, left, right);
            QuickSortHelper(array, left, pivot - 1);
            QuickSortHelper(array, pivot + 1, right);
        }

        /// <summary>
        /// Helper method for QuickSort. It divides the array into 2 subarrays and all items 
        /// smaller than a pivot put into the left, others - into the right 
        /// </summary>
        /// <param name="array">array of int values</param>
        /// <param name="left">the most left element in subarray</param>
        /// <param name="right">the most right element in subarray</param>
        /// <returns>an index of a pivot</returns>
        internal static int Part(int[] array, int left, int right)
        {
            //it will be divider into 2 subarrays
            int divider = left;
            
            //choose a pivot (an element in a middle of the array)
            int pivotindex = left + (right - left) / 2;
            int pivot = array[pivotindex];
            Swap(array, pivotindex, right); //put a pivot in the end of the array

            for(int i = left; i <= right; i++)
            {
                if(array[i] < pivot)
                {
                    Swap(array, i, divider++);
                }
            }
            Swap(array, divider, right);
            return divider;
        }

        /// <summary>
        /// Helper method for QuickSort. It swaps two elements one with other.
        /// </summary>
        /// <param name="array">array of int values</param>
        /// <param name="a">one int value to swap</param>
        /// <param name="b">other int value to swap</param>
        internal static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        #endregion

        #region MergeSort Helpers (internal)
        /// <summary>
        /// Auxiliary method for MergeSort. It divides an array.
        /// </summary>
        /// <param name="array">array of int values</param>
        /// <param name="left">the most left element in subarray</param>
        /// <param name="right">the most right element in subarray</param>
        internal static void Divide(int[] array, int left, int right)
        {
            if (right.CompareTo(left) == 0) return;
            int middle = left + (right - left) / 2;
            Divide(array, left, middle);
            Divide(array, middle + 1, right);
            Merge(array, left, middle, right);
        }

        /// <summary>
        /// Auxiliary method for MergeSort. It merges two subarrays into one.
        /// </summary>
        /// <param name="array">array of int values</param>
        /// <param name="left">the most left element in subarray</param>
        /// <param name="middle">the middle element in subarray</param>
        /// <param name="right">the most right element in subarray</param>
        internal static void Merge(int[] array, int left, int middle, int right)
        {
            int positionL = left;
            int positionR = middle + 1;
            int[] result = new int[right - left + 1];
            int positionResult = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (positionL > middle)
                {
                    result[positionResult++] = array[positionR++];
                }
                else if (positionR > right)
                {
                    result[positionResult++] = array[positionL++];
                }
                else if (array[positionL].CompareTo(array[positionR]) < 0)
                {
                    result[positionResult++] = array[positionL++];
                }
                else
                {
                    result[positionResult++] = array[positionR++];
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                array[left + i] = result[i];
            }
            return;
        }
        #endregion

        #region ArrayChecker
        /// <summary>
        /// Checker for an input array.
        /// </summary>
        /// <param name="array">array of int values</param>
        internal static void ArrayChecker(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentNullException("Array is null.");
            }
            if(array.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }
        }
        #endregion
    }
}
