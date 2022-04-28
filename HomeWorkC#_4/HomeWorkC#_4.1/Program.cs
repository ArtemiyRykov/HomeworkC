// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int power = Exponentiation(numberA, numberB);

Console.Write($"{numberA}^{numberB} = {power}");


/*
int sum = numberA;
int index = 1;
while (index < numberB)
{
    sum *= numberA;
    index++;
}
Console.Write($"{numberA}^{numberB} = {sum}");
*/


/*
int i = numberB;
int sum;
for (sum = 1; i >= 1; i--) sum *= numberA;

Console.Write($"{numberA}^{numberB} = {sum}");
*/

int Exponentiation(int foting, int degree)
{
    int sum = foting;
    int index = 1;
    while (index < degree)
    {
        sum *= foting;
        index++;
    }

    return sum;
}