int[,] CreateTwoDinArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max);
    return array;
}

void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
}

// Задача 1 (Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива)

int[,] SortingFromMinToMax(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, j] > array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            temp = 0;
            }
        }
    }
    return array;
}

/*
Console.WriteLine("Введите количество строк и столбцов массива");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное и максимальное значение, которое могут принимать элементы массива");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateTwoDinArray(rows, columns, min, max);
ShowArray(array);
Console.WriteLine();
array = SortingFromMinToMax(array);
ShowArray(array);
*/


// Задача 2 (Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов)

void FindRowWithMinSum(int[,] array)
{
    int sumMin = 0;
    int rowWithMinSum = 0;
    int sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
        sumMin += array[0, j];

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if(sumMin > sum)
        {
            sumMin = sum;
            rowWithMinSum = i;
        }
        sum = 0;
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (rowWithMinSum + 1));
}

/*
Console.WriteLine("Введите количество строк и столбцов для прямоугольного массива");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное и максимальное значение, которое могут принимать элементы массива");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateTwoDinArray(rows, columns, min, max);
ShowArray(array);
FindRowWithMinSum(array);
*/

// Задача 3 (Заполните спирально массив 4 на 4)


int[,] SpiralFilling(int size, int firstNum)
{
    int[,] array = new int[size, size];
    int iLast = 0;
    int jLast = 0;

    array[0, 0] = firstNum;

    for (int j = 1; j < size; j++)   // заполнение 00, 01, 02, 03
    {
        array[iLast, j] = array[iLast, j - 1] + 1;
        jLast = j;
    }

    for (int i = 1; i < size; i++)   // заполнение 13, 23, 33
    {
        if (array[i, jLast] == 0) array[i, jLast] = array[i - 1, jLast] + 1;
        iLast = i;
    }

    for (int j = size - 2; j >= 0; j--)   // заполнение 32, 31, 30
    {
        if (array[iLast, j] == 0) array[iLast, j] = array[iLast, j + 1] + 1;
        jLast = j;
    }

    for (int i = size - 2; i > 0; i--)   // заполнение 20, 10
    {
        if (array[i, jLast] == 0) array[i, jLast] = array[i + 1, jLast] + 1;
        iLast = i;
    }

    for (int j = 1; j < size - 1; j++)   // заполнение 11, 12
    {
        if (array[iLast, j] == 0) array[iLast, j] = array[iLast, j - 1] + 1;
        jLast = j;
    }

    for (int i = 1; i < size - 1; i++)   // заполнение 22
    {
        if(array[i, jLast] ==0) array[i, jLast] = array[i - 1, jLast] + 1;
        iLast = i;
    }

    for (int j = size - 3; j > 0; j--)   // заполнение 21
    {
        if(array[iLast, j] ==0) array[iLast, j] = array[iLast, j + 1] + 1;
    }

    return array;
}

Console.WriteLine("Введите количество строк и столбцов для квадратного массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение первого элемента");
int firstNum = Convert.ToInt32(Console.ReadLine());
int[,] array = SpiralFilling(size, firstNum);
ShowArray(array);