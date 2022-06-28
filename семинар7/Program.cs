// Задача 1 (Польз-ль вводит два числа - кол-во строк и столбцов, метод должен создать двумерный массив)

int[,] CreateRandomTwoDemArray (int rows, int columns, int min, int max)
{
    int[,] newMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
        newMatrix[i, j] = new Random().Next(min, max + 1);
        Console.Write(newMatrix[i,j] + " ");
       } 
       Console.WriteLine();
    }
    return newMatrix;
}

// int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9);

// Задача 2 (Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран)

int[,] CreateIndexSumArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = i + j;
    return array;
}

void ShowTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Console.WriteLine("Введите количество строк и столбцов:");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// ShowTwoDimArray(CreateIndexSumArray(rows, columns));

// Задача 3 (Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты)

int[,] ChangeArrayElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
            array[i, j] = array[i, j] * array[i, j];
    return array;
}

// Console.WriteLine("Введите количество строк и столбцов:");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandomTwoDemArray(rows, columns, 1, 9);
// Console.WriteLine();
// ShowTwoDimArray(ChangeArrayElements(array));

// Задача 4 (Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

int FindSumDiagonalElements(int[,] array, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
        sum += array[i, i];
    return sum;
}

Console.Write("Введите размер квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandomTwoDemArray(size, size, 1, 9);
Console.WriteLine();
Console.WriteLine(FindSumDiagonalElements(array, size));