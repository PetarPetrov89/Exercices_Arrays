using System;

namespace Index3
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int[] numbers = new int[20];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = i * 3;
                }

                Console.WriteLine(string.Join(", ", numbers));
          

        }
    }
}
