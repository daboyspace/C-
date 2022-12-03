        // Задача 41: Пользователь вводит с клавиатуры M чисел. 
        // Посчитайте, сколько чисел больше 0 ввёл пользователь.

        // Например:
        // 0, 7, 8, -2, -2 -> 2
        // -1, -7, 567, 89, 223-> 3



Console.Write("Сколько чисел будете записывать?: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];


array = Input(array, n);
Output(array, n);

int result = SearchForMoreThanZero(array, n);
Console.WriteLine($"Чисел больше ноля: {result}");



int[] Input(int[] array, int n)
{
    Console.WriteLine("Введите числа:");

    for (int i = 0; i < n; i++)
    {
        Console.Write($"[{i + 1}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}


void Output(int[] array, int n)
{
    Console.Write($"[{array[0]}, ");

    for (int i = 1; i < n - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }

    Console.WriteLine($"{array[n - 1]}]");
}


int SearchForMoreThanZero(int[] array, int n)
{
    int coll = 0;

    for (int i = 0; i < n; i++)
    {
        if (array[i] > 0) coll++;
    }

    return coll;
}
