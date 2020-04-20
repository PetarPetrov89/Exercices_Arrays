using System;

namespace Exercices_Arrays
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

            Console.WriteLine("Please enter the number that you are looking for");

            int x = int.Parse(Console.ReadLine());

            int result = 0;

            foreach (var number in numbers)
            {
                if (number == x)
                {
                    result++;
                }
            }

            Console.WriteLine($"The number {x} is {result} times in the array");
        }
    }
}
