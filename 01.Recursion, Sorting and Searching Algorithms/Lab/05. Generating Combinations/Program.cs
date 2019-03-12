using System;
using System.Linq;

namespace _05._Generating_Combinations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var set = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var vectorLenght = int.Parse(Console.ReadLine());
            var vector = new int[vectorLenght];
            GenCombinations(set,vector,0,0);
        }

        public static void GenCombinations(int[] set, int[] vector, int vectorIndex, int border)
        {
            if (vector.Length == vectorIndex)
            {
                Console.WriteLine(string.Join(" ",vector));
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[vectorIndex] = set[i];
                    GenCombinations(set,vector,vectorIndex + 1, i + 1);
                }
            }
        }
    }
}
