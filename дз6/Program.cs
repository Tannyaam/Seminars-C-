/* // Задача 1 (Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь)

int FindAmountOfPositiveNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count ++;
    }
    return count;
}

Console.Write("Введите количество чисел ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа");
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(FindAmountOfPositiveNum(array));
*/

// Задача 2 (Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования)

int[] CopyArray (int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
        Console.Write(copyArray[i] + " ");
    }
    
    return copyArray;
}

Console.Write("Введите количество чисел ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа");
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

CopyArray(array);