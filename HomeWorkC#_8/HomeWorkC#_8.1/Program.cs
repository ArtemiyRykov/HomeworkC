// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int minElement = array[0, 0];
int line = 0;
int column = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minElement)
        {
            minElement = array[i, j];
            line = i;
            column = j;
        }
    }
}

Console.WriteLine($"Наименьший элемент массива: {minElement}");
Console.WriteLine($"Координаты наименьшего элемента массива : {line};{column}");

int[,] newArray = new int[m - 1, n - 1];
int newLine = 0;
int newColumn = 0;
for (int i = 0; i < newArray.GetLength(0); i++)
{
    newColumn = 0;
    if (i == line) newLine++;
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if (j == column) newColumn++;
        {
            newArray[i, j] = array[newLine, newColumn];
            newColumn++;
        }
    }
    newLine++;
}
Console.WriteLine("Следующий массив: ");
PrintArray(newArray);

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



