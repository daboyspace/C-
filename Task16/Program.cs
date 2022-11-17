// Задача 16. Напишите программу, которая 
// 1. принимает на вход два числа
// 2. проверяет, является ли одно число квадратом другого.

// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Введите первое число: ");
int num1 = Convert.Toint32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.Toint32(Console.ReadLine());

Console.WriteLine(square(num1, num2) ? "да" : "нет");

bool square(int firstNum, int secondNum)
{
    return (firstNum == secondNum * secondNum)(secondNum == firstNum * firstNum);
}