// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// m = 3, n = 4.

// 1 7 -2 -85

// 1 -3 8 -9

// 8 7 -7 9

Console.WriteLine("Колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Колличество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -99, 100);
PrintArray(array);
Console.WriteLine();

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2 */

Console.Write("ведите индекс строки: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int y = int.Parse(Console.ReadLine()!);
if(x < array.GetLength(0) && y < array.GetLength(1))
{
    Console.WriteLine($"По заданным координатам находится число: {array[x,y]}!");
}
else
{
    Console.WriteLine("Таких координат в массиве нет!");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Methods

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}
