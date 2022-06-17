/* Задача 1 (Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.)

int FindDegree (int num1, int num2)
{
    int i = 1;
    int result = 1;

    while(i <= num2)
    {
        result = result * num1;
        i++;
    }
    return result;
}

Console.Write("Введите число, которое нужно возвести в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(num1 + " в степени " + num2 + " равно " + FindDegree(num1, num2));
*/

// Задача 2 (Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.)

int size = 8;
int [] array = new int [size];

Console.WriteLine("Введите границы интервала, числа которого могут попастся в массиве (например, от 0 до 7): ");
Console.Write("от ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("до (включительно) ");
int num2 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(num1, (num2 + 1));
}

for (int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}