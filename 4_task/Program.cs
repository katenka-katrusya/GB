// Задача 4. Напишите программу, кот. принимает на вход три числа и выдаёт максимальное из этих чисел

int numberA = new Random().Next(1, 100); // 1 2 3 4 ... 99
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);
int numberC = new Random().Next(1, 100);
Console.WriteLine(numberC);
int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.Write($"Максимально число = {max}");
