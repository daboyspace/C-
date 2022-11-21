// Задача 22. Напишите программу, которая 
// 1. принимает на вход число (N)
// 2. выдаёт таблицу квадратов чисел от 1 до N.

// Например:
// 5 -> 1,4,9,16,25
// 2 -> 1,4

int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число N");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}
void Quarter(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"Число - {count} и его квадрат {count * count}");
        count++;
    }
}
Quarter(n);