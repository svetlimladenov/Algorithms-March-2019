using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Find_All_Paths_in_a_Labyrinth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var lab = new char[rows][];
            for (int i = 0; i < lab.Length; i++)
            {
                var currentRow = Console.ReadLine();
                lab[i] = new char[currentRow.Length];
                for (int j = 0; j < lab[i].Length; j++)
                {
                    lab[i][j] = currentRow[j];
                }
            }

            FindPath(lab,0,0,' ');          
        }

        public static List<char> paths = new List<char>();

        public static void FindPath(char[][] lab,int row, int col,char direction)
        {
            if (row < 0 || col < 0 || row >= lab.Length || col >= lab[0].Length || lab[row][col] == 'M' || lab[row][col] == '*')
            {
                return;
            }

            if (direction != ' ')
            {
                paths.Add(direction);
            }
            

            if (lab[row][col] == 'e')
            {
                Console.WriteLine(string.Join("",paths));
            }
            else
            {
                lab[row][col] = 'M';
                FindPath(lab,row, col + 1,'R');
                FindPath(lab,row + 1,col,'D');  
                FindPath(lab, row, col - 1,'L');
                FindPath(lab,row - 1, col,'U');
              
                lab[row][col] = '-';
            }

            if (direction != ' ')
            {
                paths.RemoveAt(paths.Count - 1);
            }
        }
    }
}
