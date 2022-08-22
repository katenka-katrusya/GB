// Задача 6. Напишите программу, которая на вход принимает на вход и выдаёт, является ли число чётным

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
Console.WriteLine($"{number} - число четное");
else 
Console.WriteLine($"{number} - число нечетное");
