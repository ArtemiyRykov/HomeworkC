// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

int m = Input("Введите число m: ");
int n = Input("Введите число n: ");

if(m >= 0 && n >= 0)
{
    Console.WriteLine($"Функции Аккермана равна : {Akkerman(n, m)}");
}
else
{
    Console.WriteLine($"При отрицательных чисел функция Акермана не работает");
}

int Akkerman(int n, int m)
{
    if (n == 0) 
        return m + 1;
    else if (n > 0 && m == 0) 
        return Akkerman(n - 1, 1);
    else if (n > 0 && m > 0) 
        return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n,m);
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
