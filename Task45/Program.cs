// Задача 45. Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] CoppyArray(int[] arr)
{
    int[] tempArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        tempArray[i] = arr[i];
    }
    return tempArray;
}

int[] array1 = CreateArrayRndInt(5, 1, 10);
PrintArray(array1);
int[] array2 = CoppyArray(array1);
array2[0] = 2022;
PrintArray(array2);