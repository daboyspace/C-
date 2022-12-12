// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int numberM = -1;
while (numberM < 0)
{
    Console.Write("Введите первое неотрицательное целое число: ");
    numberM = Convert.ToInt32(Console.ReadLine());
    if (numberM < 0) Console.WriteLine("Неправильный ввод");
}
int numberN = -1;
while (numberN < 0)
{
    Console.Write("Введите второе неотрицательное целое число: ");
    numberN = Convert.ToInt32(Console.ReadLine());
    if (numberN < 0) Console.WriteLine("Неправильный ввод");
}

int AkkermanFunction(int number1, int number2)
{
    if (number1 == 0)
        return number2 + 1;
    else if (number2 == 0)
        return AkkermanFunction(number1 - 1, 1);
    return AkkermanFunction(number1 - 1, AkkermanFunction(number1, number2 - 1));
}

int akkermanFunction = AkkermanFunction(numberM, numberN);
Console.Write($"m = {numberM}, n = {numberN} -> {akkermanFunction}");
