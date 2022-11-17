// Задача 14. Напишите программу, которая
// 1. принимает на вход число
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiplicity(number) ? "да" : "нет");

bool Multiplicity(int num1)
{
    return (num1 % 7 ==0) && (num1 % 23 ==0);
}