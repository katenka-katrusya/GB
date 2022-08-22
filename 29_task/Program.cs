/* Задача 29. Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33] */

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальную границу: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите максимальную границу: ");
int b = int.Parse(Console.ReadLine());

void RandomArray()
{
    int[] array = new int[n];
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(a, b);
        }
    }
    Console.WriteLine($"[{String.Join(", ", array)}]");
}
RandomArray();
