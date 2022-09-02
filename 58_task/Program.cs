// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FirstArray(int rows, int columns, int minValue, int maxValue)
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

int[,] SecondArray(int rows, int columns, int minValue, int maxValue)
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

int[,] ArrayMultiplication(int[,] firstArr, int[,] secondArr)
{
    int[,] result = new int[firstArr.GetLength(0), secondArr.GetLength(1)];

        for (int i = 0; i < firstArr.GetLength(0); i++)
        {
            for (int j = 0; j < secondArr.GetLength(1); j++)
            {
                for (int n = 0; n < secondArr.GetLength(0); n++)
                {
                    result[i, j] += firstArr[i, n] * secondArr[n, j];
                }
            }
        }
        return result;
}

Console.WriteLine("Число строк первого массива: ");
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine("Число столбцов первого массива: ");
int columns1 = int.Parse(Console.ReadLine());
Console.WriteLine("Число строк второго массива: ");
int rows2 = int.Parse(Console.ReadLine());
Console.WriteLine("Число столбцов второго массива: ");
int columns2 = int.Parse(Console.ReadLine());

int[,] firArray = FirstArray(rows1, columns1, 0, 9);
Console.WriteLine("Первый массив: ");
PrintArray(firArray);
Console.WriteLine();
int[,] secArray = SecondArray(rows2, columns2, 0, 9);
Console.WriteLine($"Второй массив: ");
PrintArray(secArray);
Console.WriteLine();
int[,] newArray = ArrayMultiplication(firArray, secArray);

if (firArray.GetLength(1) == secArray.GetLength(0))
{
    Console.WriteLine($"Произведение массивов: ");
    PrintArray(newArray);
}
else
{
    Console.Write("Произведение массивов не может быть найдено. Число столбцов 1 массива должно совпадать с числом строк 2 массива");
}
