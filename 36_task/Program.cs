/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;                                      
}

int Position(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arr[i];
        }
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int s = int.Parse(Console.ReadLine());

Console.Write("Введите минимальную границу массива: ");
int minS = int.Parse(Console.ReadLine());

Console.Write("Введите максимальную границу массива: ");
int maxS = int.Parse(Console.ReadLine());

int[] array = GetArray(s, minS, maxS);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {Position(array)}");