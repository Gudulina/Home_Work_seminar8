/*
Задача 2: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

void Print(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void SmallerAmount(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    int amount = 10000;
    int num;
    int smallest = 0;

    for (int i = 0; i < rowSize; i++)
    {   
        num = 0;
        for (int j = 0; j < columnSize; j++)
            num += arr[i, j];            

        if (amount > num)
        {
            amount = num;
            smallest = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {smallest + 1}");
}

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 10);
Print(arr_1);

SmallerAmount(arr_1);
