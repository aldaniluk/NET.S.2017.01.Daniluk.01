using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Sort
    {
        public static void QuickSort(int[] array)
        {

        }

        public static void MergeSort(int[] array)
        {
            Divide(array, 0, array.Length - 1);
        }
        private static void Divide(int[] array, int left, int right)
        {
            if (right.CompareTo(left) == 0) return;
            int middle = left + (right - left) / 2;
            Divide(array, left, middle);
            Divide(array, middle + 1, right);
            Merge(array, left, middle, right);
        }
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
