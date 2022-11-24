// Задача 28. Напишите программу, которая
// 1. принимает на вход число N
// 2. выдаёт произведение чисел от 1 до N.

// Например:
// 4 -> 24
// 5 -> 120

int number = 0;
while (number <= 0)
{
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) Console.WriteLine("Введены неверные данные");
}
int MultDigits(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}

int multDigits = MultDigits(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {multDigits}");
