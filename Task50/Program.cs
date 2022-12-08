//  Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//  в двумерном массиве и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.

//  Например, задан массив:
//   1 4 7 2
//   5 9 2 3
//   8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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
                Console.Write($"{matrix[i, j],4}{separatorElems}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(endRow);
    }
}

bool IndexMatrix(int[,] matrix, int rowIndex1, int columnIndex1)
{
    if (rowIndex1 < 0 || columnIndex1 < 0) return false;
    if (rowIndex1 >= matrix.GetLength(0) || columnIndex1 >= matrix.GetLength(1)) return false;
    return true;
}

void StringToTwoNumbers(string str, out int rowIndex1, out int columnIndex1)
{
    string[] arrString = str.Split(',');
    rowIndex1 = Convert.ToInt32(arrString[0]);
    columnIndex1 = Convert.ToInt32(arrString[1]);
}

int[,] array = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array, "", "", "");

Console.Write("Введите индексы строки и столбца через запятую: ");
string numbersString = Console.ReadLine();

int rowIndex, columnIndex;
StringToTwoNumbers(numbersString, out rowIndex, out columnIndex);

Console.WriteLine(IndexMatrix(array, rowIndex, columnIndex) ? $"Элемент массива [{rowIndex},{columnIndex}] = {array[rowIndex, columnIndex]}"
                                                            : "Такого числа в массиве нет");


