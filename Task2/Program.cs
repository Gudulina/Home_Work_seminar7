/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void Print(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
            Console.Write($" {arr[i, j]} ");
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

string FindElement(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    string text = "";

    if (f > row || f <= 0 || s > column || s <= 0)
        text = $"{f} {s} -> нет в массиве";

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (i + 1 == f && j + 1 == s)
            {
                text = $"arr[{f}, {s}] = {arr[i, j]} -> есть в массиве";
                break;
            }
    return text;
}

Console.Write("Введите положение строки: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите положение столбца: ");
int second = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(3, 4, 1, 11);
Print(arr_1);

Console.WriteLine(FindElement(arr_1, first, second));
