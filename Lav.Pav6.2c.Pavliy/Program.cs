﻿using ClassLibrary1;

try
{
    int[,] matrix = new int[6, 4];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    string vector = Matrix.GetRowWithMaxSum(matrix);
    Console.WriteLine($"Ответ: {vector}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}