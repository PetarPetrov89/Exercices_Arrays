using System;

namespace _09_ReadMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            int sumOfMatrix = 0;

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    int element = int.Parse(Console.ReadLine());
                    sumOfMatrix += element;
                    matrix[x, y] = element;
                }
            }

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write($"{matrix[x, y]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(sumOfMatrix);
        }
    }
}
