// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] StringToNumbersArray(string str, string separator)
{
    string[] arrString = str.Split($"{separator}");
    double[] arr = new double[arrString.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(arrString[i]);
    }
    return arr;
}

double EquationX(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;
}

double EquationY(double b1, double k1, double b2, double k2)
{
    double y = k2 * (-(b1 - b2) / (k1 - k2)) + b2;
    return y;
}

Console.Write($"Введите значения b1, k1, b2 и k2 через запятую: ");
string numbersString = Console.ReadLine();

double[] array = StringToNumbersArray(numbersString, ",");

double b1 = array[0];
double k1 = array[1];
double b2 = array[2];
double k2 = array[3];

double equationX = Math.Round(EquationX(b1, k1, b2, k2), 1);
double equationY = Math.Round(EquationY(b1, k1, b2, k2), 1);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({equationX}; {equationY})");
