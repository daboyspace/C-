// Задача 12. Напишите программу, которая
// 1. будет принимать на вход два числа
// 2. выводить, является ли первое число кратным второму
// 3. если число первое не кратно числу второму, то программа выводит остаток от деления.

// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Ведите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int number1, int number2)
{
    return number1 % number2 == 0;
}

// int MultiplicitySecond(int number1, int number2)
// {
//     return number1 % number2;
// }

bool result = Multiplicity(num1, num2);
Console.WriteLine(result ? "Первое число кратно второму" : $"не кратно, остаток = {num1 % num2}" );

// int result2 = MultiplicitySecond(num1, num2);
// Console.WriteLine(result2 == 0 ? "Первое число кратно второму" : $"не кратно, остаток = {result2}");