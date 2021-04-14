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
        static void Main(string[] args)
        {
            /*string sudokuString =
                "1 3 2 5 7 9 4 6 8 \n" +
                "4 9 8 2 6 1 3 7 5 \n" +
                "7 5 6 3 8 4 2 1 9 \n" +
                "6 4 3 1 5 8 7 9 2 \n" +
                "5 2 1 7 9 3 8 4 6 \n" +
                "9 8 7 4 2 6 5 3 1 \n" +
                "2 1 4 9 3 5 6 8 7 \n" +
                "3 6 5 8 1 7 9 2 4 \n" +
                "8 7 9 6 4 2 1 5 3 \n";*/

            int[,] sudokuMatrix = new int[9,9] {
                     {1,3,2,5,7,9,4,6,8},
                     {4,9,8,2,6,1,3,7,5},
                     {7,5,6,3,8,4,2,1,9},
                     {6,4,3,1,5,8,7,9,2},
                     {5,2,1,7,9,3,8,4,6},
                     {9,8,7,4,2,6,5,3,1},
                     {2,1,4,9,3,5,6,8,7},
                     {3,6,5,8,1,7,9,2,4},
                     {8,7,9,6,4,2,1,5,3}};

            bool isSudoku = isValidSudoku(sudokuMatrix);
            if(isSudoku)
            {
                Console.WriteLine("SIM");
            }
            else
            {
                Console.WriteLine("NÃO");
            }
            Console.ReadLine();
        }

        private static bool isValidSudoku(int[,] sudoku)
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
                                return false;
                        }
                    }
                }
            }

            for (int linha = 0; linha < 9; linha++)
            {
                int[] ocorrenciaDoNumero = new int[9];      //cada numero só pode aparecer 1 vez na linha

                for (int termo = 0; termo < 9; termo++)
                {
                    int valor = sudoku[linha, termo];
                    ocorrenciaDoNumero[valor - 1]++;
                }

                foreach (int val in ocorrenciaDoNumero)
                {
                    if (val != 1)
                        return false;
                }
            }

            for (int coluna = 0; coluna < 9; coluna++)
            {
                int[] ocorrenciaDoNumero = new int[9];      //cada numero só pode aparecer 1 vez na coluna

                for (int termo = 0; termo < 9; termo++)
                {
                    int valor = sudoku[termo, coluna];
                    ocorrenciaDoNumero[valor - 1]++;
                }

                foreach (int val in ocorrenciaDoNumero)
                {
                    if (val != 1)
                        return false;
                }
            }

            return true;
        }
    }
}
