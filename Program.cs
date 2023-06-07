using System;

class Program
{
    static void Main()
    {
        int size = 4; 

        int[,] matrix = new int[size, size];

        CompleteMatrix(matrix);

        Console.WriteLine("Заполненная матрица:");
        PrintMatrix(matrix);

        Console.ReadLine();
    }

    static void CompleteMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == j)
                {
                    matrix[i, j] = i + 1;
                }

                if (i + j == size - 1)
                {
                    matrix[i, j] = j + 1; 
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
