// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumberDesc(int num)
{
    if (num > 1)
    {
        Console.Write($"{num}, ");
        NaturalNumberDesc(num - 1);
    }
    else if (num == 1)
        Console.Write($"{num}");
    return;
}

int numberN = 0;
while (numberN <= 0)
{
    Console.Write("Введите натуральное число: ");
    numberN = Convert.ToInt32(Console.ReadLine());
    if (numberN <= 0)
        Console.WriteLine("Неправильный ввод");
}

Console.Write($"N = {numberN} -> ");
NaturalNumberDesc(numberN);
