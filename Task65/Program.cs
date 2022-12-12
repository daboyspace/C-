// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void NumbersMToN(int numb1, int numb2)
{
    if (numb1 > numb2)
    {
        Console.Write($"{numb1} ");
        NumbersMToN(numb1 - 1, numb2);
    }
    else if (numb1 < numb2)
    {
        Console.Write($"{numb1} ");
        NumbersMToN(numb1 + 1, numb2);
    }
    else
        Console.Write($"{numb1} ");
}

NumbersMToN(numberM, numberN);
