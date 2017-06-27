using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, 1, 8, 10, 2 };
            //merge sort
            Sort.MergeSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
            Console.WriteLine();

            int[] arr1 = new int[] { 4, 5, 1, 6, 7, 2, 3 };
            int[] arr2 = new int[] { 4, 5, 1, 8, 10, 2 };
            int[] arr3 = new int[] { 5, 4, 7, 1, 7, 1 };
            //quick sort
            Sort.QuickSort(arr3);
            Array.ForEach(arr3, i => Console.Write(i+ " "));
        }
    }
}
