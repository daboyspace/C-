// Задача 25. Напишите цикл, который 
// 1. принимает на вход два числа (A и B) 
// 2. возводит число A в натуральную степень B.

// Например:
// 3, 5 -> 243 
// 2, 4 -> 16

Console.Write($"Введите чило, которое хотите возвести в степень: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.Write($"Введите степень, в которую хотите возвести число: ");
double degree = Convert.ToInt32(Console.ReadLine());



double result = RiseDegree(number, degree);
Console.WriteLine($"---> {result}");




double RiseDegree(double number, double degree) 
{
    if (degree == 0) return 1; 

    double copyNum = number;
    
    if (degree > 0) { 
        for (int i = 1; i < degree; i++) {
            number *= copyNum;
        }
    } else 
    {
        degree *= -1; 
        for (int i = 1; i < degree; i++) 
        {
            number *= copyNum;
        }

        number = 1 / number;
    }

    return number; 
}