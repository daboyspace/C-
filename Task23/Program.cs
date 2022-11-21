// Задача 23. Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// Например:
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1)
{
    Console.WriteLine("Нужно ввести число больше 0!!!!");
    Environment.Exit(0);
}

Console.WriteLine($"{n} -> ");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} | {i * i * i}");
}