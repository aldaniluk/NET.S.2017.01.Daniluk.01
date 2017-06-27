using System;

namespace Logic
{
    /// <summary>
    /// Class is created for sorting int arrays
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// Sorting int arrays using Quick Sort
        /// </summary>
        /// <param name="array">array of int values</param>
        public static void QuickSort(int[] array)
        {
            QuickSortHelper(array, 0, array.Length - 1);
        }

        private static void QuickSortHelper(int[] array, int left, int right)
        {
            if (right == left) return;
            int pivot = Part(array, left, right);
            QuickSortHelper(array, left, pivot);
            QuickSortHelper(array, pivot + 1, right);
        }

        private static int Part(int[] array, int left, int right)
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

        private static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }



        /// <summary>
        /// Sorting int arrays using Merge Sort
        /// </summary>
        /// <param name="array">array of int values</param>
        public static void MergeSort(int[] array)
        {
            Divide(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Auxiliary method for MergeSort. It divides an array.
        /// </summary>
        /// <param name="array">array of int values</param>
        /// <param name="left">the most left element in subarray</param>
        /// <param name="right">the most right element in subarray</param>
        private static void Divide(int[] array, int left, int right)
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
        private static void Merge(int[] array, int left, int middle, int right)
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
    }
}
