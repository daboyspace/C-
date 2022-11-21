// Задача 21. Напишите программу, которая 
// 1. принимает на вход координаты двух точек 
// 2. находит расстояние между ними в 3D пространстве.

// Например:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите 1-е координаты точки А(x, y, z): ");

double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите 2-е координаты точки B(x, y, z): ");

double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());


double distance = Math.Round(Quarter(x1, y1, z1, x2, y2, z2), 2);
Console.WriteLine($"Расстоягие между точками = {distance}");

double Quarter(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double sum = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
    double distance = Math.Sqrt(sum);
    return distance;
}