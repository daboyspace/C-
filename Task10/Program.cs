// Задача 10.
// Напишите программу, которая 
// 1. принимает на вход трёхзначное число 
// 2. на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = input();

Console.WriteLine(GetTwo(number));

int input()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetTwo(int number)
{
    int two = (number % 100) / 10;
    return two;
}