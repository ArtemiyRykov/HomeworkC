// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    int[] newArray = new int[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        newArray[j] = array[i, j];
    }
    newArray = SortingArray(newArray);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = newArray[j];
    }
}

Console.WriteLine("Упорядоченный массив: ");
PrintArray(array);

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
            array[i, j] = new Random().Next(1, 100);
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

int[] SortingArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
	        {
		        int temp = array[j + 1];
		        array[j + 1] = array[j];
		        array[j] = temp;
    	    }
        }
    }
	return array;
}