// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int numberM = 0;
while (numberM <= 0)
{
    Console.Write("Введите первое натуральное число: ");
    numberM = Convert.ToInt32(Console.ReadLine());
    if (numberM <= 0)
        Console.WriteLine("Неправильный ввод");
}
int numberN = 0;
while (numberN <= 0)
{
    Console.Write("Введите второе натуральное число: ");
    numberN = Convert.ToInt32(Console.ReadLine());
    if (numberN <= 0)
        Console.WriteLine("Неправильный ввод");
}

int SumMtoN(int numb1, int numb2)
{
    if (numb1 > numb2)
    {
        return numb1 + SumMtoN(numb1 - 1, numb2);
    }
    else if (numb1 < numb2)
    {
        return numb1 + SumMtoN(numb1 + 1, numb2);
    }
    else
        return numb2;
}

int sumMtoN = numberM == numberN ? numberM : SumMtoN(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} -> {sumMtoN}");
