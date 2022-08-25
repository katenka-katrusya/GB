// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());

void Input(int M)
{
    int count = 0;

    for (int i = 0; i < M; i++)
    {
        Console.Write("Ведите число: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля: {count}");
}

Input(M);