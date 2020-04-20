using System;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 5, 6 };
            int[] array2 = new int[] { 6, 6, 7, 2, 3 };

            int[] resultArray = new int[array1.Length];

            //Array.Reverse(array2);

            ReverseIntArray(array2);

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = array1[i] + array2[i];
            }

            Console.WriteLine(string.Join(", ", resultArray));
        }

        public static void ReverseIntArray(int[] numbers)
        {
            int[] reversed = (int[])numbers.Clone();

            for (int i = 0; i < numbers.Length; i++)
            {
                int x = reversed[i];

                numbers[numbers.Length - 1 - i] = x;
            }
        }
    }
}
