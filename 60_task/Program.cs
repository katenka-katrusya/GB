// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] mas = new int[x, y, z];
    int count = 10;

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int n = 0; n < mas.GetLength(2); n++)
            {
                {
                    mas[i, j, n] = count;
                    count++;
                }
            }
        }
    }
    return mas;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i, j, n]} ({i}, {j}, {n}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Значение x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Значение y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Значение z: ");
int z = int.Parse(Console.ReadLine());

if (x * y * z > 99)
    Console.WriteLine("Размер трёхмерного массива должен быть меньше");
else
{
    int[,,] myArray = GetArray(x, y, z, 10, 99);
    Console.WriteLine("Трёхмерный массив с индексами каждого элемента: ");
    PrintArray(myArray);
}
