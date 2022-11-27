// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random rnd = new Random();                
int n = rnd.Next(1, 10);                     
int[] arr = new int[n];

arr =  CreateArray(arr, n);                  
OutputArray(arr, n);                        

Console.WriteLine(SearchSum(arr, n));


int[] CreateArray(int[] arr, int n) 
{        
    for (int i = 0; i < n; i++) 
    {
        arr[i] = rnd.Next(-100, 100);
    }

    return arr;
}

void OutputArray(int[] arr, int n) 
{         
    Console.Write($"[{arr[0]}, ");

    for (int i = 1; i < n - 1; i++) 
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[n-1]}]");
}

int SearchSum(int[] arr, int n) 
{          
    int sum = 0;

    for (int i = 0; i < n; i++) 
        if (i % 2 != 0) sum += arr[i];
    
    return sum;
}