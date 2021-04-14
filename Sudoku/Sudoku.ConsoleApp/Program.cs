using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.ConsoleApp
{
    class Program
    {
        private static bool isValidSudoku(int[,] sudoku)
        {
            if (!isValidBlock(sudoku))
                return false;

            for (int linha = 0; linha < 9; linha++)
            {
                int[] sudokuRow = Enumerable.Range(0, sudoku.GetLength(1)).Select(x => sudoku[linha, x]).ToArray();    //gets entire row

                if (!isValidRow(sudokuRow))
                    return false;
            }

            for (int coluna = 0; coluna < 9; coluna++)
            {
                int[] sudokuColumn = Enumerable.Range(0, sudoku.GetLength(0)).Select(x => sudoku[x, coluna]).ToArray();    //gets entire column

                if (!isValidColumn(sudokuColumn))
                    return false;
            }

            return true;
        }

        private static bool isValidBlock(int[,] sudoku)     //idk lol
        {
            for (int s = 0; s < 9; s += 3)
            {
                for (int m = 0; m < 9; m += 3)
                {
                    HashSet<int> blocos = new HashSet<int>();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (!blocos.Add(sudoku[i + s, j + m]))
                                Console.WriteLine("A block has an invalid value.");
                                return false;
                        }
                    }
                }
            }

            return true;
        }

        private static bool isValidRow(int[] row)
        {
            int[] numberOccurrences = new int[9];      //all numbers must appear only once in the row

            for (int number = 0; number < 9; number++)
            {
                int value = row[number];
                numberOccurrences[value - 1]++;
            }

            foreach (int val in numberOccurrences)
            {
                if (val != 1)
                    Console.WriteLine("A row has an invalid value.");
                    return false;
            }

            return true;
        }

        private static bool isValidColumn(int[] column)
        {
            int[] numberOccurences = new int[9];      //all numbers must appear only once in the column

            for (int number = 0; number < 9; number++)
            {
                int value = column[number];
                numberOccurences[value - 1]++;
            }

            foreach (int val in numberOccurences)
            {
                if (val != 1)
                    Console.WriteLine("A column has an invalid value.");
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[,] sudokuMatrix = new int[9, 9] {
                     {1,3,2,5,7,9,4,6,8},
                     {4,9,8,2,6,1,3,7,5},
                     {7,5,6,3,8,4,2,1,9},
                     {6,4,3,1,5,8,7,9,2},
                     {5,2,1,7,9,3,8,4,6},
                     {9,8,7,4,2,6,5,3,1},
                     {2,1,4,9,3,5,6,8,7},
                     {3,6,5,8,1,7,9,2,4},
                     {8,7,9,6,4,2,1,5,3}};

            if (isValidSudoku(sudokuMatrix))
            {
                Console.WriteLine("SIM");
            }
            else
            {
                Console.WriteLine("NÃO");
            }
            Console.ReadLine();
        }
    }
}
