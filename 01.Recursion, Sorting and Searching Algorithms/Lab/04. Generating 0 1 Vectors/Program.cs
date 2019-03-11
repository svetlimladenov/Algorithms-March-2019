using System;

namespace _04._Generating_0_1_Vectors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var vector = new int[n];

            GenerateVector(vector, 0);
        }

        public static void GenerateVector(int[] vector, int index)
        {
            if (vector.Length == index)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                GenerateVector(vector, index + 1);
            }

        }
    }
}
