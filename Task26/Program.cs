// Задача 26. Напишите программу, которая
// 1. принимает на вход число
// 2. выдаёт количество цифр в числе.

// Например:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digits(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}

if (number < 0) number = -number;
int result = Digits(number);
Console.WriteLine($"Количество цифр в числе {number} ---> {result}");


