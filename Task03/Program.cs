// Задача 03. Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.

// Например:
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели:");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay == 1)
    Console.WriteLine("Понедельник");
else if (numDay == 2)
    Console.WriteLine("Вторник");
else if (numDay == 3)
    Console.WriteLine("Среда");
else if (numDay == 4)
    Console.WriteLine("Четверг");
else if (numDay == 5)
    Console.WriteLine("Пятница");
else if (numDay == 6)
    Console.WriteLine("Суббота");
else if (numDay == 7)
    Console.WriteLine("Воскресенье");
else Console.WriteLine("Не нашли");
