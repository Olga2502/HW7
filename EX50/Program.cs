//Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void AccepPosit(int[,] inArray, int numst, int numcol)
{
    if (inArray.GetLength(0) > numst && inArray.GetLength(1) > numcol)
    {
        Console.WriteLine($"Значение элемента равно   {inArray[numst, numcol]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет.");
    }
}

Console.Write("Введите количество строк: ");
int st = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(st, col, -10, 10);

Console.WriteLine("Введите номер строки :");
int numst = int.Parse(Console.ReadLine()!) - 1;
Console.WriteLine("Введите номер столбца :");
int numcol = int.Parse(Console.ReadLine()!) - 1;

Console.WriteLine("Массив чисел: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
AccepPosit(array, numst, numcol);

