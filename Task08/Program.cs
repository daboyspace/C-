// Задача 08. Напишите программу, которая 
// 1. на вход принимает число (N) 
// 2. на выходе показывает все чётные числа от 1 до N.

// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= num; count++)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count + " ");
    }
}