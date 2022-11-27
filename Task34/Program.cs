// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Например:
// [345, 897, 568, 234] -> 2

Random rnd = new Random();                   
int n = rnd.Next(1, 10);                     
int[] arr = new int[n];

arr =  CreateArray(arr, n);                 
OutputArray(arr, n);                         

Console.WriteLine(SearchColl(arr, n));

int[] CreateArray(int[] arr, int n) 
{
    for (int i = 0; i < n; i++) 
    {
        arr[i] = rnd.Next(100, 999);
    }

    return arr;
}

void OutputArray(int[] arr, int n) 
{        
    Console.Write($"[{arr[0]}, ");

    for (int i = 1; i < n - 1; i++) 
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[n-1]}]");
}

int SearchColl(int[] arr, int n) 
{ 
    int coll = 0;

    for (int i = 0; i < n; i++) 
    {
        if (arr[i] % 2 == 0) coll++;
    }

    return coll;
}