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
            int[] arr1 = new int[] { 1, 5, 3, 8 };
            int[] arr2 = new int[] { 9, 3, 6, 1, 5, 2, 3, 7 };
            int[] arr3 = new int[] { };
            int[] arr4 = null;


            //merge sort
            Sort.MergeSort(arr1);
            Array.ForEach(arr1, i => Console.Write(i + " "));

            Console.WriteLine();

            
            //quick sort
            Sort.QuickSort(arr2);
            Array.ForEach(arr2, i => Console.Write(i+ " "));
        }
    }
}
