using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8 };
            int maxNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }

            }
            Console.WriteLine(maxNumber);
        }
    }
}
