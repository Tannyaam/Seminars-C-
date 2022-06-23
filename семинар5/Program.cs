
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

// Задача 1 (Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.)


int FindPositiveSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }

    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }

    return sum;
}

/*
int[] myArray = CreateRandomArray(12, -9, 9);

Console.WriteLine("Сумма положительных чисел в массиве " + FindPositiveSum(myArray));
Console.WriteLine("Сумма отрицательных чисел в массиве " + FindNegativeSum(myArray));
*/

// Задача 2 (Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот)

int[] ReplaceArrayElement(int[] array)
{
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1); // или array[i] *= -1;
        Console.Write(array[i] + " ");
    }
    
    return array;
}

/*
int[] myArray = CreateRandomArray(12, -7, 9);
myArray = ReplaceArrayElement(myArray);
*/


// Задача 3 (Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве)

bool FindNumInArray(int[] array, int num)
{
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        return true;
    }

    return false;
}

// /*
int num = new Random().Next(-7, 9);
Console.WriteLine("Искомое число " + num);
int[] myArray = CreateRandomArray(12, -7, 9);
Console.WriteLine(FindNumInArray(myArray, num));
// */

// Задача 4 (Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99])

int FindAmountOfElements(int[] array, int min, int max)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max)
        count ++;
    }

    Console.WriteLine("Количество элементов " + count);
    return count;
}

/*
int min = 10;
int max = 99;
int[] myArray = CreateRandomArray(12, 0, 10);
Console.WriteLine(FindAmountOfElements(myArray, min, max));
*/
