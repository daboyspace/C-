// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
                Console.Write($"{matrix[i, j],3}{separatorElems}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(endRow);
    }
}

void PrintTwoMatrices(int[,] matrix, int[,] matrix2, string beginRow, string separatorElems, string separatorMatrices, string endRow)
{
    int maxRow = matrix.GetLength(0) > matrix2.GetLength(0)
                ? matrix.GetLength(0)
                : matrix2.GetLength(0);
    for (int i = 0; i < maxRow; i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(0))
            {
                if (j < matrix.GetLength(1) - 1)
                    Console.Write($"{matrix[i, j],3}{separatorElems}");
                else Console.Write($"{matrix[i, j],3}");
            }
            else Console.Write($"{" ",3}");
        }
        Console.Write($"{separatorMatrices}");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (i < matrix2.GetLength(0))
            {
                if (j == 0)
                    Console.Write($"{matrix2[i, j],2}{separatorElems}");
                else if (j < matrix2.GetLength(1) - 1)
                    Console.Write($"{matrix2[i, j],3}{separatorElems}");
                else Console.Write($"{matrix2[i, j],3}");
            }
        }
        Console.WriteLine(endRow);
    }
}

bool CheckMultMatrices(int[,] matrix, int[,] matrix2)
{
    return matrix.GetLength(1) == matrix2.GetLength(0);
}

int[,] MultMatrices(int[,] matrix, int[,] matrix2)
{
    int rows1 = matrix.GetLength(0);
    int columns1 = matrix.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);
    int[,] multMatrices = new int[rows1, columns2];
    for (int i = 0, n = 0; i < rows1; i++, n++)
    {
        for (int j = 0; j < columns2; j++)
        {
            ;
            for (int k = 0, m = 0; k < rows2; k++, m++)
            {
                if (m >= columns1) m = 0;
                multMatrices[i, j] += matrix[n, m] * matrix2[k, j];
            }
        }
    }
    return multMatrices;
}

int[,] matrix01 = CreateMatrixRndInt(2, 2, 1, 9);
int[,] matrix02 = CreateMatrixRndInt(2, 2, 1, 9);
PrintTwoMatrices(matrix01, matrix02, "", "", " |", "");

Console.WriteLine();
bool checkMultMatrices01 = CheckMultMatrices(matrix01, matrix02);
if (checkMultMatrices01 != true)
    Console.WriteLine(@$"Правила умножения матриц не соблюдены:
Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы");
else
{
    int[,] multMatrices01 = MultMatrices(matrix01, matrix02);
    PrintMatrix(multMatrices01, "", " ", "");
}
