using System;

namespace equalsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = ReadArrayFromConsole();

            int[] array2 = ReadArrayFromConsole();

            bool result = CompareArrays(array1, array2);

            Console.WriteLine(result);
        }


        public static int[] ReadArrayFromConsole()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine($"Please enter {n} numbers of the array.");

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }

        public static bool CompareArrays(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            bool result = true;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
