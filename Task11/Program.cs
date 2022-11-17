// Задача 11. Напишите программу, которая
// 1. выводит случайное трёхзначное число
// 2. удаляет вторую цифру этого числа.

// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int RemoveSecondDigit(int numb)
{
    int firstDigit = numb / 100;
    int secondDigit = numb % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

Console.WriteLine(RemoveSecondDigit(number));