﻿// Задача 01. Напишите программу, которая
// 1. на вход принимает 2 числа
// 2. проверяет, является ли первое число квадратом второго.

// Например:
// a=25, b=5 -> да
// a=2, b=10 -> нет
// a=9, b=-3 -> да
// a=-3, b=9 -> нет

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.Write("Результат: ");
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
