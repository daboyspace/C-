// Задача 11. Напишите программу, которая
// 1. выводит случайное трёхзначное число
// 2. удаляет вторую цифру этого числа.

// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное чило = {number}");
int RemoveSecondDigit(int numb)
{
    int firstDigit = numb / 100;
    int thirdDigit = numb % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}
Console.WriteLine("Удаляем вторую цифру числа");
Console.WriteLine($"Результат = {RemoveSecondDigit(number)}");