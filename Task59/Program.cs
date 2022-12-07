// Задача 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на  пересечении которых расположен наименьший 
// элемент массива.

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

void PrintMatrix(int[,] matrix)

{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("");
    }
}

void RowColumnIndexMinElem(int[,] matrix, out int indexRow, out int indexColumn)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int min = matrix[0, 0];
    indexRow = 0;
    indexColumn = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }

        }
    }
}
int[,] DeleteRowColumnsMinElemMatrix(int[,] matrix, int indexRow, int indexColumn)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrix2 = new int[rows - 1, columns - 1];
    for (int i = 0, m = 0; i < rows - 1; i++, m++)
    {
        if (m == indexRow) m++;
        for (int j = 0, n = 0; j < columns - 1; j++, n++)
        {
            if (n == indexColumn) n++;
            matrix2[i, j] = matrix[m, n];
        }
    }
    return matrix2;
}

int[,] matrix1 = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int rowIndex1, columnIndex2;
RowColumnIndexMinElem(matrix1, out rowIndex1, out columnIndex2);
int[,] matrix3 = DeleteRowColumnsMinElemMatrix(matrix1, rowIndex1, columnIndex2);
PrintMatrix(matrix3);