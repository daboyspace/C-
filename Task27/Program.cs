// Задача 27. Напишите программу, которая 
// 1. принимает на вход число 
// 2. выдаёт сумму цифр в числе.

// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(number);
Console.WriteLine(sum);

int SumNumbers(int num)
{
    int copyNum = num;
    int sum = 0;
    int n = 1;
    while (copyNum / 10 != 0)
    {
        copyNum = copyNum / 10;
        n++;
    }
    copyNum = num;
    for (int i = 0; i < n; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}