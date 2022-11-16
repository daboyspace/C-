// Задача 02. Напишите программу, которая 
// 1. на вход принимает два числа
// 2. выдаёт какое число большее, а какое меньшее.

// Например:
// a = 5 b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"{a}>{b} ");
}
else
{
    Console.WriteLine($"{b}>{a} ");
}