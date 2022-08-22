/* Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
3, 5 -> 243 (3⁵); 2, 4 -> 16 */

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int res = 1;

if (a <= 0 || b <= 0)
{
    Console.WriteLine("Неправильно введённое число");
}

else
{
    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }
    Console.WriteLine(res);
}