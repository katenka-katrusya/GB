// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120

int SumNumbers(int M, int N)
{
    if (M > N) 
    {
        return 0;
    }
    else 
    {
        return M + SumNumbers(M + 1, N);
    }
}

Console.Write("M = ");
int numM = int.Parse(Console.ReadLine());
Console.Write("N = ");
int numN = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов от {numM} до {numN} = {SumNumbers(numM, numN)}"); 
