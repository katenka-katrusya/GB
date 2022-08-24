// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue) 
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(), 2);
    }
    return res;                                      
}

double Maximum(double[] mas)
{
    double maxNum = mas[0];

    foreach (var item in mas)
    {
        maxNum = maxNum < item ? item : maxNum;
    }
    return maxNum;
}

double Minimum(double[] mas)
{
    double minNum = mas[0];

    foreach (var item in mas)
    {
        minNum = minNum > item ? item : minNum;
    }
    return minNum;
}

Console.Write("Введите размер массива: ");
int s = int.Parse(Console.ReadLine());

Console.Write("Введите минимальную границу массива: ");
int minS = int.Parse(Console.ReadLine());

Console.Write("Введите максимальную границу массива: ");
int maxS = int.Parse(Console.ReadLine());

double[] array = GetArray(s, minS, maxS);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Maximum(array) - Minimum(array)}");
