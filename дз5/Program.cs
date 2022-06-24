// Задача 1 (Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве)

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size]; // объявление/создание массива

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    
    Console.WriteLine();
    return newArray;
}


int FindCountOfEvenNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    
    return count;
}

// int[] myArray = CreateRandomArray(10, 100, 999);
// Console.WriteLine("Количество четных чисел в массиве " + FindCountOfEvenNum(myArray));

// Задача 2 (Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях)

// нечетная позиция с т.з. программирования (отсчет начинается с 0) или с т.з. обычного пользователя (начинается с 1)?
// решение сделано для отсчета с 0

int FindSumOfOddPositionNum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2) 
    {
        sum += array[i];
    }

    return sum;
}

// int[] myArray = CreateRandomArray(10, 1, 10);
// Console.WriteLine("Сумма чисел на нечетных позициях в массиве равна " + FindSumOfOddPositionNum(myArray));

// Задача 3 (Задайте массив вещественных (дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива)

double FindDiffBetweenMinAndMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double dif = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }

    dif = max - min;
    dif = Math.Round(dif, 2);
    return dif;

}

double[] CreateRandomArrayDouble(int size, int min, int max)
{
    double[] newArray = new double[size]; 

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble() * (max - min) + min;
        newArray[i] = Math.Round(newArray[i], 2);
        Console.Write(newArray[i] + "  ");
    }
    
    Console.WriteLine();
    return newArray;
}

double[] myArray = CreateRandomArrayDouble(10, 1, 10);
Console.WriteLine("Разница между максимальным и минимальным элементом в массиве равна " + FindDiffBetweenMinAndMax(myArray));