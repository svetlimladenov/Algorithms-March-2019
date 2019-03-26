using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Reverse(input, new List<int>(), input.Length - 1);
        }

        public static void Reverse(int[] arr, List<int> reversed,int index) // 1 2 3 4 - 4 3 2 1 
        {
            if (arr.Length == reversed.Count)
            {
                Console.WriteLine(string.Join(" ",reversed));  
                return;
            }
            reversed.Add(arr[index]);
            Reverse(arr, reversed, index - 1);
        }
    }
}
