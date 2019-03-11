using System;

namespace _02._Recursive_Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }

        public static int Factoriel(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * Factoriel(number - 1);
        }
    }
}
