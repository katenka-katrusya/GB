// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine());

if (num == 6 || num == 7) {
    Console.WriteLine("Выходной день");
}
else if (num > 7 || num < 1) {
    Console.WriteLine("Некорректная цифра дня недели"); 
}
else {
    Console.WriteLine("Будний день");
}