// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int tempSumm = 0;
for (var i = 0; i < array.GetLength(1); i++)
{
    tempSumm += array[0, i];
}

int position = 0;
for (var i = 0; i < array.GetLength(0); i++)
{
    int lineSumm = 0;
    for (var j = 0; j < array.GetLength(1); j++)
    {
        lineSumm += array[i, j];
    }
     Console.WriteLine($"Строка {i} = {lineSumm}");
    if(tempSumm > lineSumm)
    {
        tempSumm = lineSumm;
        position = i;
    }
}
Console.WriteLine($"Строка {position} с наименьшей суммой элементов = {tempSumm} ");

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}