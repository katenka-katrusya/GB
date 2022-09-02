// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] res = new int[rows, columns];

    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
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

int[,] ElementsDescendingRow(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int n = 0; n < mas.GetLength(1) - 1; n++)
            {
                if (mas[i, n] < mas[i, n + 1])
                {
                    int temp = mas[i, n];
                    mas[i, n] = mas[i, n + 1];
                    mas[i, n + 1] = temp;
                }
            }
        }
    }
    return mas;
}

Console.Write("Количество строк = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов = ");
int columns = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 9);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Упорядоченный массив: ");
int[,] newArray = ElementsDescendingRow(myArray);
PrintArray(newArray);
