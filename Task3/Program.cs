/*
Задача 3: Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MatrixProduct(int[,] arrFirst, int[,] arrSecond)
{
    int rowSize = arrFirst.GetLength(0);
    int columnSize = arrFirst.GetLength(1);
    int[,] matrix = new int[rowSize, columnSize];

    for (int i = 0; i < rowSize; i++)       
        for (int j = 0; j < columnSize; j++)
            matrix[i, j] = arrFirst[i, j] * arrSecond[i, j];            
    return matrix;
}


Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = MassNums(row, column, 0, 5);
Print(arr1);
int[,] arr2 = MassNums(row, column, 0, 5);
Print(arr2);

int[,] mult = MatrixProduct(arr1, arr2);
Print(mult);
