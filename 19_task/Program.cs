/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Нельзя использовать массивы и строки для решения задачи, исключительно работа с циклами и арифметическими опреациями!!!
14212 -> нет; 12821 -> да; 23432 -> да */

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int a = num % 100 % 10; // 12345 % 100 = 45 % 10 = 5
int a1 = num % 100 / 10; // 12345 % 100 = 45 / 10 = 4
int b = num / 1000 / 10; // 12345 / 1000 = 12 / 10 = 1 
int b1 = num / 1000 % 10; // 12345 / 1000 = 12 % 10 = 2

if (a==b && a1==b1)
{
    Console.Write("Палиндром");
}
else
{
    Console.Write("Не является палиндромом");
}
