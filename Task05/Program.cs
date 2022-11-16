// Задача 05. Напишите программу, которая
// 1. на вход принимает одно число (N)
// 2. на выходе показывает все целые числа в промежутке от -N до N.

// Например:
// 4-> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2-> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Count = -number;
if (number >= 0)
{
    while (Count <= number)
    {
        Console.Write($"{Count} ");
        Count++;
    }
}
else Console.Write("Введено некорректное значение");
// else
// {
//     while (Count >= number)
// {
//     Console.Write(Count+" ");
//     Count--;
// }
// }