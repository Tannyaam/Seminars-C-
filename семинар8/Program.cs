// Задача 1 (Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива)

int[,] CreateTwoDinArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
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

int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }

    return array;
}

// int[,] array = CreateTwoDinArray(4, 3, 1, 9);
// ShowArray(array);
// Console.WriteLine();
// array = ChangeLines(array, 2, array.GetLength(0) - 1);
// ShowArray(array);

// Задача 2 (Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя)

int[,] ChangeLinesAndColumns(int[,] array)
{
    int temp;
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
           }
        }
    return array;
}

/*
int[,] array = CreateTwoDinArray(5, 5, 1, 9);
ShowArray(array);
Console.WriteLine();
if(array.GetLength(0) == array.GetLength(1))
{
    array = ChangeLinesAndColumns(array);
    ShowArray(array);
}
else Console.WriteLine("Невозможно транспонировать массив");
*/

// Задача 3 (Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент)

/*
int[,] DeleteLineAndColumnWithMin(int[,] array)
{
    int min = array[0, 0];
    int lineMin = 0;
    int columnMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(min > array[i, j])
            {
                min = array[i, j];
                lineMin = i;
                columnMin = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
        array[i, columnMin] = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        array[lineMin, j] = 0;
    
    return array;
}
*/

int lineMin;
int columnMin;

int FindLineAndColumnWithMin(int[,] array)
{
    int min = array[0, 0];
    lineMin = 0;
    columnMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(min > array[i, j])
            {
                min = array[i, j];
                lineMin = i;
                columnMin = j;
            }
        }
    }

    return lineMin;
    return columnMin;
}

int[,] DeleteLineAndColumnWithMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        array[i, columnMin] = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        array[lineMin, j] = 0;
    
    return array;
}

int[,] array = CreateTwoDinArray(4, 4, 1, 9);
ShowArray(array);
Console.WriteLine();
FindLineAndColumnWithMin(array);
array = DeleteLineAndColumnWithMin(array);
ShowArray(array);