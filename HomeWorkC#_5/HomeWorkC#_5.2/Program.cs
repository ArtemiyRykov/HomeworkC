// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int[4];
FillPrintArray(numbers);

int sum = 0;
for (int i = 1; i < numbers.Length; i++)
{
    sum = numbers[i] + sum;
    i++;
}

Console.WriteLine();
Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях = {sum}");


void FillPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }

}