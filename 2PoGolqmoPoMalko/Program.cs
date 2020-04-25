using System;

namespace _2PoGolqmoPoMalko
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine($"Please enter {n} numbers of the array.");

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int index = int.Parse(Console.ReadLine());

            int number = numbers[index];

            int x = 0;
            int y = 0;

            if (index > 0)
            {
                x = numbers[index - 1];
            }

            if (index < numbers.Length - 1)
            {
                y = numbers[index + 1];
            }

            if (number > x && number > y)
            {
                Console.WriteLine($"Числото е по-голямо от съседното!");
            }
            else if (number < x && number < y)
            {
                Console.WriteLine($"Числото е по-малко от съседното!");
            }
            else
            {
                Console.WriteLine($"Числото е нито по-малко, нито по-голямо от съседното!");
            }
        }
    }
}
