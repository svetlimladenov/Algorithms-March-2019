using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static int[] SelectionSort(int[] arr, int startIndex)
        {
            if (startIndex == arr.Length - 1)
            {
                return arr;
            }
            var minNumber = int.MaxValue;
            var minNumberIndex = -1;
            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i] < minNumber)
                {
                    minNumber = arr[i];
                    minNumberIndex = i;
                }
            }

            if (startIndex == minNumberIndex)
            {
                SelectionSort(arr, startIndex + 1);
            }

            var currentIndexNumber = arr[startIndex];
            arr[startIndex] = minNumber;
            arr[minNumberIndex] = currentIndexNumber;

            return SelectionSort(arr, startIndex + 1);
        }

        public static int[] SelectionSortEasy(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var minNumber = arr[i];
                var minNumberIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < minNumber)
                    {
                        minNumber = arr[j];
                        minNumberIndex = j;
                    }
                }

                var temp = arr[i];
                arr[i] = minNumber;
                arr[minNumberIndex] = temp;
            }

            return arr;
        }

        public static int[] BubleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var unsortedElement = arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > unsortedElement)
                    {
                        //moves it one step back;
                        var temp = arr[j];
                        arr[j] = unsortedElement;
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }



        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

    }
}
