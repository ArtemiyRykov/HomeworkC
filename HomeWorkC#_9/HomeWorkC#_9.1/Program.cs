// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = Input("Введите значение N: ");
int m = 1;

Console.WriteLine(OutputNumbers(n, m));

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputNumbers(int n, int m)
{
    if (m == n)
    {
        return m;
    }
    Console.Write(OutputNumbers(n, m + 1) + ", ");
    return m;
}