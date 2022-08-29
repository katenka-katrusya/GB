// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int row, int column, int minValue, int maxValue) 
{
    int[,] mas = new int[row, column];

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return mas;                                      
}

void PrintArray(int[,] array)
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

double[] FindAverage(int[,] arr)
{
    double[] middle = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)  
        {
            sum += arr[i, j];    
        }
        middle[j] = Math.Round(sum / arr.GetLength(0), 1);      
    }
    return middle;
}

Console.Write("Количество строк = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов = ");
int columns = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 9);
PrintArray(myArray);
double[] average = FindAverage(myArray);
Console.WriteLine($"Среднее арифметическое каждого столбца: " + String.Join("; ", average));