// Задача 09. Напишите программу, которая
// 1. выводит случайное число из отрезка [10, 99]
// 2. показывает наибольшую цифру числа.

// Например: 
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайно число из отрезка 10-99 --> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit} ");
else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit} ");

