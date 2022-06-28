// Задача 1 (Задайте двумерный массив размером m×n, заполненный случайными вещественными числами)

double[,] CreateRandomDoubleArray(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * (max - min) + min;
            array[i, j] = Math.Round(array[i, j], 1);
        }
    return array;
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

/*
Console.WriteLine("Введите количество строк и столбцов массива");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное и максимальное значение, которое могут принимать элементы массива");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateRandomDoubleArray(rows, columns, min, max));
*/

// Задача 2 (Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет)

void FindElement(double[,] array, int rowNumber, int columnNumber)
{
    if (rowNumber < array.GetLength(0) && columnNumber < array.GetLength(1))
        Console.WriteLine(array[rowNumber, columnNumber]);
    else Console.WriteLine("Такого элемента нет");
}

/*
Console.WriteLine("Введите количество строк и столбцов массива");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное и максимальное значение, которое могут принимать элементы массива");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateRandomDoubleArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine("Введите номер строки и столбца искомого элемента");
int rowNumber = Convert.ToInt32(Console.ReadLine());
int columnNumber = Convert.ToInt32(Console.ReadLine());
FindElement(array, rowNumber, columnNumber);
*/

// Задача 3 (Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце)

int[,] CreateRandomIntArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void FindAverageOfColomns(int[,] array)
{
    double sum = 0;
    double average = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        
        average = Math.Round(sum / array.GetLength(0), 2);
        Console.Write(average + "  ");
        sum = 0;
        average = 0;
    }
}

void PrintIntArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк и столбцов массива");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное и максимальное значение, которое могут принимать элементы массива");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandomIntArray(rows, columns, min, max);
PrintIntArray(array);
FindAverageOfColomns(array);
