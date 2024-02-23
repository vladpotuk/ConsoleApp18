using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        
        int min = array[0, 0];
        int max = array[0, 0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                }

                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }

        
        Console.WriteLine("Мінімальне значення: " + min);
        Console.WriteLine("Максимальне значення: " + max);

        Console.ReadLine();
    }
}
