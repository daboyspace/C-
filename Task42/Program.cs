// Задача 42. Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string Binary(int numb)
// {
//     string bin = string.Empty;
//     while (numb > 0)
//     {
//         bin = numb % 2 + bin;
//         numb /= 2;
//     }
//     return bin;
// }

void PrintArray(int[] arr, string beginStr, string separatorElems, string endstr)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems} ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endstr);
}
int[] Binary(int numb)
{
    int numb1 = numb;
    int digits = 0;
    while (numb1 > 0)
    {
        numb1 /= 2;
        digits += 1;
    }
    int[] bin = new int[digits];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[bin.Length - i - 1] = numb % 2;
        numb /= 2;
    } 
    return bin;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(number);
// Console.WriteLine(Binary(number));
PrintArray(binary, "", "", "");
