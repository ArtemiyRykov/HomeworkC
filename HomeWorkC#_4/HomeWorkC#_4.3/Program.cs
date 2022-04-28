// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите числа через запятую: ");
string array = Console.ReadLine();

string NewArray = Replace(array, ',', ' ');

int count = NewArray.Length;
for (int i = 0; i < count; i++)
{
    Console.Write($"{NewArray[i]}");
}




string Replace(string list, char befor, char after)
{
    string result = "";
    int length = list.Length;
    for (int i = 0; i < length; i++)
    {
        if (list[i] == befor) result = result + $"{after}";
        else result = result + $"{list[i]}";
    }
    return result;
}
