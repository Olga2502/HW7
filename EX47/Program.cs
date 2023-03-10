//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for ( int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
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

Console.WriteLine("Введите колво строк: ");
int str = int.Parse(Console.ReadLine());

Console.WriteLine("Введите колво стобцов: ");
int col = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Созданный массив вещественных чисел: ");
double[,] array = GetArray(str, col, -10, 10);
PrintArray(array);
