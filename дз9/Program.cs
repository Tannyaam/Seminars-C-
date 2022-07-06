// Задача 1 (Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N)

int SumFromMToN(int m, int n)
{
    if(m == n + 1)
        return 0;
    else return m + SumFromMToN(m + 1, n);
}

/*
Console.Write("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumFromMToN(m, n));
*/

// Задача 2 (Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр)

int CountOfNumbers(int n)
{
    if(n == 0)
        return 0;
    else return 1 + CountOfNumbers(n / 10);
}

Console.Write("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CountOfNumbers(n));