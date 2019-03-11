using System;
using System.Linq;

namespace Demo
{
    public class Program
    {
        public static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }

            return arr[index] + Sum(arr, index + 1);
        }

        public static int Factoriel(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * Factoriel(num - 1);
        }

        public static void RecursiveDrawing(int n)
        {
            if (n == 0)
            {
                return;
            }
            //Pre-actions
            Console.WriteLine(new string('*', n));
            RecursiveDrawing(n - 1); //Recursion
            //Post-actions
            Console.WriteLine(new string('#', n));
        }


        public static void Generate(int index, int[] vector)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(' ', vector));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Generate(index + 1, vector);
                }
            }

        }


        public static void GenCominations(int[] set, int[] vector, int vectorIndex, int border)
        {
            if (vectorIndex == vector.Length)
            {
                Console.WriteLine(string.Join(' ',vector));
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[vectorIndex] = set[i];
                    GenCominations(set,vector,vectorIndex + 1, i + 1);
                }
            }
        }

        public static void Main(string[] args)
        {
            //var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //var sum = Sum(arr,0);
            //Console.WriteLine(sum);

            //var factorielInput = int.Parse(Console.ReadLine());
            //var factoriel = Factoriel(factorielInput);
            //Console.WriteLine(factoriel);

            //var num = int.Parse(Console.ReadLine());
            //RecursiveDrawing(num);


            var vector = new int[8];
            Generate(0, vector);

            //var set = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //var count = int.Parse(Console.ReadLine());

            //var vector = new int[count];
            //GenCominations(set, vector, 0, 0);
        }
    }
}
