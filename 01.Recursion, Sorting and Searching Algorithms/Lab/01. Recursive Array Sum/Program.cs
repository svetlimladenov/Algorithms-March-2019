using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Sum(input,0));
        }


        public static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }

            return arr[index] + Sum(arr, index + 1);
        }
    }
}
