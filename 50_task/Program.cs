// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// m = 1, n =7 -> такого числа в массиве нет

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

void PositionElement(int[,] arr, int pos1, int pos2)
{
    if (pos1 < arr.GetLength(0) && pos2 < arr.GetLength(1))
    {
        Console.WriteLine($"Элемент найден = {arr[pos1, pos2]}");
    }

    else 
    {
        Console.WriteLine("Такого элемента нет");
    }
}

Console.Write("Введите номер строки: ");
int index1 = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int index2 = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(7, 7, -9, 9);
PrintArray(myArray);
PositionElement(myArray, index1, index2);