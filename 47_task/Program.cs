// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    double[,] mas = new double[m, n];

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 1);
        }
    }
    return mas;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }  
}

Console.Write("Количество строк = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов = ");
int n = int.Parse(Console.ReadLine());

double[,] myArray = GetArray(m, n, -9, 9);
PrintArray(myArray);