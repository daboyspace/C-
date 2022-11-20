// Задача 15. Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели 
// 2. проверяет, является ли этот день выходным.

// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int number = input();
Console.WriteLine(DoDay(number));


int input()
{
    int inp = Convert.ToInt32(Console.ReadLine());
    return inp;
}

string DoDay(int number)
{
    if (number < 1 || number > 7) return "Такого дня нет в неделе";


    if (number > 5 && number < 8)
    {
        return "да";
    }
    else return "нет";
}