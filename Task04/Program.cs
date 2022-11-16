// Задача 04. Напишите программу, которая 
// 1. принимает на вход три числа 
// 2. выдаёт максимальное из этих чисел.

// Например:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.WriteLine("Введите по очереди три числа: ");
Console.Write("1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("3: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine($"max = {a}");
}
else
{
    if (b > a && b > c)
    {
        Console.WriteLine($"max = {b}");
    }
    else
    {
        if (c > b && c > a)
            Console.WriteLine($"max = {c}");
    }
}