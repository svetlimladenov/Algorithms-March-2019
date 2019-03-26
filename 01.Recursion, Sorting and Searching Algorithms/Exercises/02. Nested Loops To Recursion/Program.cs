using System;
using System.Linq;

namespace _02._Nested_Loops_To_Recursion
{
    public class Program
    {
        private static int[] loops;

        public static void Main(string[] args)
        {
            int loopsCount = 3;
            loops = new int[loopsCount];
            NestedLoops(loopsCount, 0);
        }

        public static void NestedLoops(int loopsCount, int currentLoop)
        {
            if (currentLoop == loopsCount)
            {
                Print(loops);
                return;
            }

            for (int counter = 1; counter <= loopsCount; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(loopsCount, currentLoop + 1);
            }
        }

        private static void Print(int[] loops)
        {
            Console.WriteLine(String.Join(" ", loops));
        }
    }
}
