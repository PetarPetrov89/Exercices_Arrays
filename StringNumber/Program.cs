using System;

namespace StringNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string reversed = ReverseText(word);

            Console.WriteLine(reversed);
        }

        public static string ReverseText(string text)
        {
            char[] reversed = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char x = text[i];

                reversed[text.Length - 1 - i] = x;
            }
            return string.Join("", reversed);
        }
    }
}
