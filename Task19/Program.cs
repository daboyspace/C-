// Задача 19. Напишите программу, которая 
// 1. принимает на вход пятизначное число  
// 2. проверяет, является ли оно палиндромом.
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// Например:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 1)
{
    Console.WriteLine("Отрицательные числа не могут быть палиндромом!");
    Environment.Exit(0);
}

String result = СheckPolinom(number) ? "да (данное число является палиндромом)" : "нет (данное число не является палиндромом)";
Console.WriteLine(result);

bool СheckPolinom(int num)
{
    int copyNum = num;
    int shifter = 0;
    int n = 1;


    while (copyNum / 10 != 0)
    {
        copyNum = copyNum / 10;
        n++;
    }
    copyNum = num;

    for (int i = 0; i < n; i++)
    {
        shifter = shifter * 10 + copyNum % 10;
        copyNum = copyNum / 10;
    }

    bool result = shifter == num;
    return result;
}