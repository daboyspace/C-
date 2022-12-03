        Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
        заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
        значения b1, k1, b2 и k2 задаются пользователем.
        b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Введите данные: ");

Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double y1 = Intersection(b1, k1);
double y2 = Intersection(b2, k2);

Console.WriteLine($"({y1}; {y2})");

double Intersection(double b, double k) {
    double x = -0.5;

    double y = k * x + b;

    return y;
}
