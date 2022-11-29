// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// Например:
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Random rnd = new Random();
int n = rnd.Next(3, 10);

double[] arr = new double[n];
arr = CreateArray(arr, n);
OutputArray(arr, n);

Console.WriteLine($"Разница = {RazMinMax(arr, n)}");

double[] CreateArray(double[] arr, int n)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-100, 100);
        arr[i] += Math.Round(rnd.NextDouble(), 1);
    }

    return arr;
}

void OutputArray(double[] arr, int n)
{
    Console.Write($"[{arr[0]}, ");

    for (int i = 1; i < n - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[n - 1]}]");
}

double RazMinMax(double[] arr, int n)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < n; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }

    Console.WriteLine($"Максимальное число в массиве: {max}");
    Console.WriteLine($"Минимальное число в массиве: {min}");

    double result = max - min;
    return result;
}