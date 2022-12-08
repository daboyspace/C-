// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],2}{separatorElems}");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine(endRow);
    }
}

int SumFirstRowMatrix(int[,] matrix)
{
    int columns = matrix.GetLength(1);
    int minsum = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            minsum += matrix[i, j];
        }
    }
    return minsum;
}

int MinElemRowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int minsum = SumFirstRowMatrix(matrix);
    int minElemRow = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            minElemRow = i;
        }
    }
    return minElemRow;
}

int[,] matrix1 = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrix1, "", "", "");

int minElemRowMatrix = MinElemRowMatrix(matrix1);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minElemRowMatrix + 1} строка");
