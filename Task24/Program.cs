// Задача 24. Напишите программу, которая
// 1. принимает на вход число (A)
// 2. выдаёт сумму чисел от 1 до A.

// Например:
// 7 -> 28
// 4 -> 10
// 8 ->36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }

    return sum;
}

int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumDigits}"); 