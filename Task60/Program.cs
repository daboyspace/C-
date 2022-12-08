// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

bool CheckNumberArray(int[] array, int number)
{
    bool repeated = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            return true;
        }
    }
    return repeated;
}

int[,,] CreateThreeDArrayUnicRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] threeDArray = new int[rows, columns, depth];
    int[] allNumbers = new int[rows * columns * depth];
    Random rnd = new Random();
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int temp = 0;
                bool repeated = true;
                while (repeated == true)
                {
                    temp = rnd.Next(min, max + 1);
                    repeated = CheckNumberArray(allNumbers, temp);
                }
                threeDArray[i, j, k] = temp;
                allNumbers[index++] = temp;
            }
        }
    }
    return threeDArray;
}

void PrintThreeDArray(int[,,] threeDArray)
{
    int rows = threeDArray.GetLength(0);
    int columns = threeDArray.GetLength(1);
    int depth = threeDArray.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write($"{threeDArray[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] threeDArray1 = CreateThreeDArrayUnicRndInt(2, 2, 2, 10, 99);
PrintThreeDArray(threeDArray1);
