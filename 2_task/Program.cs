// Задача 2. Напишите программу, кот. на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
double numA = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double numB = double.Parse(Console.ReadLine());
if (numA > numB)
Console.WriteLine($"{numA} - максимальное число, {numB} - минимальное число");
else
Console.WriteLine($"{numB} - максимальное число, {numA} - минимальное число");
