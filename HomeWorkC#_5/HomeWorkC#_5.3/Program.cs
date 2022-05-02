// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] numbers = new int[4];
FillPrintArray(numbers);

int numbersMax = 0;
int numbersMin = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbersMax < numbers[i])
    {
        numbersMax = numbers[i];
    }
    else if (numbersMin > numbers[i])
    {
        numbersMin = numbers[i];
    }
}
int numberDiff = numbersMax - numbersMin;
Console.WriteLine();
Console.WriteLine($"Максимальное элемент: {numbersMax} ");
Console.WriteLine($"Минимальное элемент: {numbersMin} ");
Console.Write($"Разница между максимальным и минимальным элементов массива: {numberDiff}");


void FillPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]} ");
    }
}