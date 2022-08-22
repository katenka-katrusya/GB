/* Задача 27. Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
452 - 11; 82 - 10 */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Sum(int n)
{
    int a = 0;

    while (n > 0 || n < 0)
    {
        int d = n % 10;    // 452%10=2 45%10=5 4%10=4
        n /= 10;            // 452/10=45 45/10=4 4/10=0
        a += d;            // 0+2=2 2+5=7 7+4=11
    }
    return a;
}

Console.WriteLine(Sum(num));
