// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] array3D = new int[4, 2, 4];
int count = 10;

for (int i = 0; i < array3D.GetLength(0); i++)
{
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            array3D[i, j, k] = count;
            count++;
        }
    }
}

PrintArray(array3D);

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.WriteLine($"{i} {j} {k} - {array3D[i, j, k]}");
            }
        }
    }
}