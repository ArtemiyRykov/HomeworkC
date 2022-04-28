// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int integer = number;
while (integer > 0)
{
    sum = sum + integer % 10;
    integer /= 10;
}

Console.Write($"Сумма цифр от {number} = {sum}");