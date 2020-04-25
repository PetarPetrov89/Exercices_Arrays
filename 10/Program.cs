using System;
using System.Linq;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] firstJaggedArray = GetJaggedArray(rows);
            int[][] secondJaggedArray = GetJaggedArray(rows);

            bool check = IsFittingPossible(firstJaggedArray, secondJaggedArray);

            if (check)
            {
                //Принтираме двата общо като цял блок
                for (int i = 0; i < firstJaggedArray.Length; i++)
                {
                    Console.WriteLine($"{string.Join(", ", firstJaggedArray[i].Concat(secondJaggedArray[i]))}");
                }
            }
            else
            {
                //Принтираме общия брой елементи на двата jagged масива
                Console.WriteLine($"Total amount of cells{CalcTotalCells(firstJaggedArray) + CalcTotalCells(secondJaggedArray)}");
            }
        }

        private static int CalcTotalCells(int[][] jaggedArray)
        {
            int cellsCount = 0;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                cellsCount += jaggedArray[i].Length;
            }

            return cellsCount;
        }

        private static bool IsFittingPossible(int[][] firstJaggedArray, int[][] secondJaggedArray)
        {
            bool isFit = true;

            int firstRowCellCount = firstJaggedArray[0].Length + secondJaggedArray[0].Length;

            for (int i = 1; i < firstJaggedArray.Length; i++)
            {
                if (firstJaggedArray[i].Length + secondJaggedArray[i].Length != firstRowCellCount)
                {
                    return false;
                }
            }

            return isFit;
        }

        private static int[][] GetJaggedArray(int rows)
        {
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine()
                    .Split(' ')
                    .Select(el => int.Parse(el))
                    .ToArray();
            }

            return jaggedArray;
        }
    }
}
