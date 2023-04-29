
using System;

class Zad_2_4
{
    static void Main()
    {
        Random rand = new Random();
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = rand.Next(1001);
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        int[,] digits = new int[5, 3];
        for (int i = 0; i < 5; i++)
        {
            int number = numbers[i];
            for (int j = 2; j >= 0; j--)
            {
                digits[i, j] = number % 10;
                number /= 10;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(digits[i, j] + " ");
            }
            Console.WriteLine();
        }
    Console.ReadKey();
    }
}

